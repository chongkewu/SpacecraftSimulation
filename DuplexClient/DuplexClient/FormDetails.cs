using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace DuplexClient
{
    public partial class FormDetails : Form
    {
        Form1 form1;
        public FormDetails(Form1 f1)
        {
            InitializeComponent();
            form1 = f1;
        }

        private void btnStartTele_Click(object sender, EventArgs e)
        {
            int serviceInd = int.Parse(form1.ServiceNum.Text);
            try { form1.clients[serviceInd].StartTelemetry(serviceInd, form1.launchConfig); }
            catch (Exception ex) { }

        }

        private void btnStopTele_Click(object sender, EventArgs e)
        {
            int serviceInd = int.Parse(form1.ServiceNum.Text);
            try { form1.clients[serviceInd].StopTelemetry(serviceInd, form1.launchConfig); }
            catch (Exception ex) { }
        }

        private void btn_Deorbit_Click(object sender, EventArgs e)
        {
            int serviceInd = int.Parse(form1.ServiceNum.Text);
            KillProcessAndChildren(form1.procIDs[serviceInd]);
            form1.deorbit();
        }
        public void KillProcessAndChildren(int pid)
        {
            using (var searcher = new ManagementObjectSearcher
                ("Select * From Win32_Process Where ParentProcessID=" + pid))
            {
                var moc = searcher.Get();
                foreach (ManagementObject mo in moc)
                {
                    KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
                }
                try
                {
                    var proc = Process.GetProcessById(pid);
                    proc.Kill();
                }
                catch (Exception e)
                {
                    // Process already exited.
                }
            }
        }

        private void btn_DeployPayload_Click(object sender, EventArgs e)
        {
            // run payload software
            int serviceInd = int.Parse(form1.ServiceNum.Text);
            form1.Deploypayload(serviceInd);
        }
    }
}
