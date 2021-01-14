using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using DuplexClient.PayloadService;

namespace DuplexClient
{
    // [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class Form1 : Form, ReportService.IReportServiceCallback, PayloadService.IPayloadServiceCallback
    {
        public const int MaxClientNum = 5;
        public FormDetails f2 = null;
        public int selectedNum = 0;
        public List<Spacecraft> spacecrafts { get; set; }

        private FormPayloadDetails f3;
        public int payloadSelectedNum = 0;
        public List<Payload> payloads { get; set; }
        public Form1()
        {
            spacecrafts = GetSpacecrafts();
            payloads = GetPayloads();
            InitializeComponent();
        }

        private List<Spacecraft> GetSpacecrafts()
        {
            var list = new List<Spacecraft>();
            list.Add(new Spacecraft()
            {
                Id = 0,
                Name = "",
                Orbit = 0,
                Status = "waiting"
            });
            list.Add(new Spacecraft()
            {
                Id = 1,
                Name = "",
                Orbit = 0,
                Status = "waiting"
            });
            list.Add(new Spacecraft()
            {
                Id = 2,
                Name = "",
                Orbit = 0,
                Status = "waiting"
            });
            list.Add(new Spacecraft()
            {
                Id = 3,
                Name = "",
                Orbit = 0,
                Status = "waiting"
            });
            list.Add(new Spacecraft()
            {
                Id = 4,
                Name = "",
                Orbit = 0,
                Status = "waiting"
            });

            return list;
        }

        private List<Payload> GetPayloads()
        {
            var list = new List<Payload>();
            list.Add(new Payload()
            {
                Id = 0,
                Name = "",
                Status = "waiting"
            });
            list.Add(new Payload()
            {
                Id = 1,
                Name = "",
                Status = "waiting"
            });
            list.Add(new Payload()
            {
                Id = 2,
                Name = "",
                Status = "waiting"
            });
            list.Add(new Payload()
            {
                Id = 3,
                Name = "",
                Status = "waiting"
            });
            list.Add(new Payload()
            {
                Id = 4,
                Name = "",
                Status = "waiting"
            });
            return list;
        }

        public ReportService.ReportServiceClient[] clients = new ReportService.ReportServiceClient[MaxClientNum];
        

        public void Progress(ReportService.TelemetryData telemetry, int serviceInd)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            if (serviceInd == selectedNum)
            {
                string strToProcess = " Altitude: " + telemetry.altitude.ToString() + '@'
                                         + " latitude: " + telemetry.latitude.ToString() + '@'
                                         + " longtitude: " + telemetry.longtitude.ToString() + '@'
                                         + " temperature: " + telemetry.temperature.ToString() + '@'
                                         + " timeToOrbit: " + telemetry.timeToOrbit.ToString() + '@';
                var result = strToProcess.Replace("@", Environment.NewLine);
                this.f2.textBox1.Text = result;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var spacecrafts = this.spacecrafts;
            dataGridView1.DataSource = spacecrafts;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dataGridView_Payload.DataSource = this.payloads;
            dataGridView_Payload.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public string[] LVconfigTexts = new string[MaxClientNum];
        private bool isConfigLoaded()
        {
            selectedNum = int.Parse(ServiceNum.Text);
            foreach (var spacecraft in spacecrafts)
            {
                if (selectedNum == spacecraft.Id)
                {
                    return !string.IsNullOrEmpty(spacecraft.Name);
                }
            }
            return false;
        }
        public string exefile = "";
        public int[] procIDs = new int[MaxClientNum];
        private void exeClick(object sender, EventArgs e)
        {
            if (!isConfigLoaded())
            {
                MessageBox.Show("Please select a json configuration file with json name \"Name\", \"Orbit\" and \"PayloadConfig\"");
                return;
            }
            OpenFileDialog openDialog = new OpenFileDialog();
            if (exefile == "")
            {
                openDialog.Title = "Locate the LaunchVehicle.exe of service";
                openDialog.Filter = "exe Files (*.exe)|*.exe" + "|" +
                                    "Text Files (*.txt)|*.txt" + "|" +
                                    "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                    "All Files (*.*)|*.*";
                openDialog.InitialDirectory = Directory.GetCurrentDirectory();
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    exefile = openDialog.FileName;
                }
            }
            //exefile = @"C:\Users\44266\source\repos\Experiment\04_PayLoadSoftware\ReportService\Host\bin\Debug\Host.exe";
            string strCmdText;
            string strExeArg;
            //For Testing
            strExeArg = " " + ServiceNum.Text;
            strCmdText = "/K " + exefile + strExeArg;
            
            //System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            bool started = false;
            var p = new Process();

            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = strCmdText;
            started = p.Start();

            try
            {
                var procId = p.Id;
                procIDs[int.Parse(ServiceNum.Text)] = procId;
            }
            catch (InvalidOperationException)
            {
                started = false;
            }
            catch (Exception ex)
            {
                started = false;
            }

            //update client
            int serviceInd = int.Parse(ServiceNum.Text);
            
            InstanceContext instanceContext = new InstanceContext(this);
            //this.clients[0] = new ReportService.ReportServiceClient(instanceContext);
            EndpointAddress endpoint = new EndpointAddress(new Uri("net.tcp://localhost:809"+serviceInd.ToString()+"/ReportService"));
            this.clients[serviceInd] = new ReportService.ReportServiceClient(instanceContext, new NetTcpBinding(), endpoint);

            Spacecraft spf = (Spacecraft)dataGridView1.CurrentRow.DataBoundItem;
            spf.Status = "Active";
            dataGridView1.Refresh();
            this.clients[serviceInd].LaunchVehicle(serviceInd, launchConfig);

        }

        private void btnViewDetails_click(object sender, EventArgs e)
        {
            if (f2 != null)
            {
                f2.Close();
            }
            var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Spacecraft;
            if (selectedRow.Status == "waiting"){
                MessageBox.Show("Spacecraft "+ ServiceNum.Text + " is waiting for launch now.");
                return;
                
            }
            FormDetails formDetails = new FormDetails(this);
            f2 = formDetails;
            selectedNum = int.Parse(ServiceNum.Text);
            formDetails.Show();
        }
        public string configFile= "";
        public ReportService.LaunchVehicleConfig launchConfig;

        private bool isConfigExist(string Name)
        {
            foreach (var spacecraft in spacecrafts)
            {
                if (Name == spacecraft.Name)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            
            openDialog.Title = "Locate the LaunchVehicleConfig.json of Config file";
            openDialog.Filter = "json Files (*.json)|*.json" + "|" +
                                "Text Files (*.txt)|*.txt" + "|" +
                                "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                "All Files (*.*)|*.*";
            openDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                configFile = openDialog.FileName;
                
                string json = File.ReadAllText(configFile);
                ReportService.LaunchVehicleConfig LVconfig = JsonConvert.DeserializeObject<ReportService.LaunchVehicleConfig>(json);
                this.launchConfig = LVconfig;
                if (isConfigExist(LVconfig.Name)) {
                    string msg = LVconfig.Name;
                    MessageBox.Show("Spacecraft " + msg + " config already in use!");
                    return;
                }

                ConfigTextBox.Text = configFile;
                int serviceInd = int.Parse(ServiceNum.Text);
                LVconfigTexts[serviceInd] = configFile;

                Spacecraft spf = (Spacecraft)dataGridView1.CurrentRow.DataBoundItem;
                spf.Name = LVconfig.Name;
                spf.Orbit = LVconfig.Orbit;
                dataGridView1.DataSource = spacecrafts;
                dataGridView1.Refresh();
                // load payloadConfig
                string payloadJson = File.ReadAllText(LVconfig.PayloadConfig);
                PayloadConfig PLconfig = JsonConvert.DeserializeObject<PayloadConfig>(payloadJson);
                int payloadInd = int.Parse(textBox_PayloadNum.Text);
                payloadConfigs[payloadInd] = PLconfig;
                Payload payload = (Payload)dataGridView_Payload.CurrentRow.DataBoundItem;
                payload.Name = PLconfig.Name;
                dataGridView_Payload.Refresh();
            }
            
        }
        public PayloadConfig[] payloadConfigs = new PayloadConfig[MaxClientNum];

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = dataGridView1.SelectedRows[0].DataBoundItem as Spacecraft;
                ServiceNum.Text = selectedRow.Id.ToString();
                ConfigTextBox.Text = LVconfigTexts[selectedRow.Id];
                textBox_PayloadNum.Text = ServiceNum.Text;
                dataGridView_Payload.CurrentCell = dataGridView_Payload.Rows[selectedRow.Id].Cells[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        public void deorbit()
        {
            Spacecraft spf = (Spacecraft)dataGridView1.CurrentRow.DataBoundItem;
            spf.Name = "";
            spf.Orbit = 0;
            spf.Status = "waiting";
            dataGridView1.Refresh();
            var serviceInd = int.Parse(ServiceNum.Text);
            LVconfigTexts[serviceInd] = "";
            ConfigTextBox.Text = "";

            
        }

        public void decommission()
        {
            Payload pld = (Payload)dataGridView_Payload.CurrentRow.DataBoundItem;
            pld.Name = "";
            pld.Status = "waiting";
            dataGridView_Payload.Refresh();
            var serviceInd = int.Parse(ServiceNum.Text);
            payloadConfigs[serviceInd] = null;
            payloadOnOrbits[serviceInd] = false;
        }

        public void PayloadProcess(TelemetryData telemetry, int serviceInd)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            if (serviceInd == int.Parse(textBox_PayloadNum.Text))
            {
                string strToProcess = " Altitude: " + telemetry.altitude.ToString() + '@'
                                         + " latitude: " + telemetry.latitude.ToString() + '@'
                                         + " longtitude: " + telemetry.longtitude.ToString() + '@'
                                         + " temperature: " + telemetry.temperature.ToString() + '@';
                var result = strToProcess.Replace("@", Environment.NewLine);
                this.f3.textBox_Tele.Text = result;
            }
        }


        public string PayloadExefile = "";
        public int[] PayloadIDs = new int[MaxClientNum];

        public bool[] payloadOnOrbits = new bool[MaxClientNum];
        public PayloadServiceClient[] payloadClients = new PayloadServiceClient[MaxClientNum];
        public void Deploypayload(int serviceID)
        {
            if (!payloadOnOrbits[serviceID])
            {
                MessageBox.Show("The spacecraft haven't reach the orbit yet! please wait");
                return;
            }
            OpenFileDialog openDialog = new OpenFileDialog();
            //MessageBox.Show("PayloadExefile: "+PayloadExefile);
            if (PayloadExefile == "")
            {
                openDialog.Title = "Locate the Payload.exe";
                openDialog.Filter = "exe Files (*.exe)|*.exe" + "|" +
                                    "Text Files (*.txt)|*.txt" + "|" +
                                    "Image Files (*.png;*.jpg)|*.png;*.jpg" + "|" +
                                    "All Files (*.*)|*.*";
                openDialog.InitialDirectory = Directory.GetCurrentDirectory();
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    PayloadExefile = openDialog.FileName;
                }
            }
            //PayloadExefile = @"C:\Users\44266\source\repos\Experiment\04_PayLoadSoftware\PayloadService\Host\bin\Debug\Host.exe";
            string strCmdText;
            string strExeArg;
            //For Testing
            strExeArg = " " + ServiceNum.Text;
            strCmdText = "/K " + PayloadExefile + strExeArg;

            var p = new Process();

            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = strCmdText;
            bool started = p.Start();

            try
            {
                PayloadIDs[int.Parse(ServiceNum.Text)] = p.Id;
            }
            catch (InvalidOperationException)
            {
            }
            catch (Exception ex)
            {
            }

            int serviceInd = int.Parse(textBox_PayloadNum.Text);

            InstanceContext instanceContext = new InstanceContext(this);
            //this.clients[0] = new ReportService.ReportServiceClient(instanceContext);
            EndpointAddress endpoint = new EndpointAddress(new Uri("net.tcp://localhost:900" + serviceInd.ToString() + "/PayloadService"));
            this.payloadClients[serviceInd] = new PayloadServiceClient(instanceContext, new NetTcpBinding(), endpoint);

            this.payloadClients[serviceInd].LaunchPayload(serviceInd, payloadConfigs[serviceInd], launchConfig.Orbit, baseLatitude, baseLongtitude);
            Payload payload = (Payload)dataGridView_Payload.CurrentRow.DataBoundItem;
            payload.Status = "Active";
            dataGridView_Payload.Refresh();
        }

        public int baseLatitude;
        public int baseLongtitude;
        public void reachOrbit(int serviceInd, int latitude, int longtitude)
        {
            foreach (var spacecraft in spacecrafts)
            {
                if (serviceInd == spacecraft.Id)
                {
                    payloadOnOrbits[serviceInd] = true;
                    MessageBox.Show("Spacecraft " + spacecraft.Name + " reach the desginated orbit successfully.");
                    this.baseLatitude = latitude;
                    this.baseLongtitude = longtitude;
                }
            }
        }


        private void dataGridView_Payload_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedRow = dataGridView_Payload.SelectedRows[0].DataBoundItem as Payload;
                textBox_PayloadNum.Text = selectedRow.Id.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        private void btn_ViewPayload_Click(object sender, EventArgs e)
        {
            if (f3 != null)
            {
                f3.Close();
            }
            var selectedRow = dataGridView_Payload.SelectedRows[0].DataBoundItem as Payload;
            if (selectedRow.Status == "waiting")
            {
                MessageBox.Show("Payload " + textBox_PayloadNum.Text + " is waiting for deployed.");
                return;
            }
            FormPayloadDetails formPayloadDetails = new FormPayloadDetails(this);
            f3 = formPayloadDetails;
            payloadSelectedNum = int.Parse(textBox_PayloadNum.Text);
            formPayloadDetails.Show();
        }

        public void PayloadProcessData(PayloadData PLData, int ServiceInd, string PLtype)
        {
            if (ServiceInd != int.Parse(textBox_PayloadNum.Text))
            {
                return;
            }
            if (PLtype == "Spy")
            {
                this.f3.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                this.f3.pictureBox1.Image = Image.FromStream(new MemoryStream(PLData.imageByte));
            }
            else if (PLtype == "Communication")
            {
                TextBox.CheckForIllegalCrossThreadCalls = false;
                string strToProcess = "Uplink: " + PLData.com.Uplink.ToString() + " MB@"
                                         + "Downlink: " + PLData.com.Downlink.ToString() + " MB@";
                var result = strToProcess.Replace("@", Environment.NewLine);
                this.f3.textBox_Data.Text = result;

            }
            else
            {
                TextBox.CheckForIllegalCrossThreadCalls = false;
                string strToProcess = "Rainfall: " + PLData.sci.Rain.ToString() + " mm@"
                + "Humidity: " + PLData.sci.Humidity.ToString() + "%@"
                                         +"Snow: " + PLData.sci.Snow.ToString() + " in@";
                var result = strToProcess.Replace("@", Environment.NewLine);
                this.f3.textBox_Data.Text = result;
            }
        }
    }
}
