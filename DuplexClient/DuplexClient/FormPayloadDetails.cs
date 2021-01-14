using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplexClient
{
    public partial class FormPayloadDetails : Form
    {
        Form1 form1;
        public FormPayloadDetails(Form1 f1)
        {
            InitializeComponent();
            form1 = f1;
        }

        private void btn_StartTelemetry_Click(object sender, EventArgs e)
        {
            int serviceInd = int.Parse(form1.textBox_PayloadNum.Text);
            try { form1.payloadClients[serviceInd].StartTelemetry(serviceInd, form1.payloadConfigs[serviceInd]); }
            catch (Exception ex) { }
        }

        private void btn_StopTelemetry_Click(object sender, EventArgs e)
        {
            int serviceInd = int.Parse(form1.textBox_PayloadNum.Text);
            try { form1.payloadClients[serviceInd].StopTelemetry(serviceInd, form1.payloadConfigs[serviceInd]); }
            catch (Exception ex) { }
        }

        private void btn_Decommission_Click(object sender, EventArgs e)
        {
            int serviceInd = int.Parse(form1.ServiceNum.Text);
            form1.f2.KillProcessAndChildren(form1.PayloadIDs[serviceInd]);
            form1.decommission();
        }

        private void btn_StartData_Click(object sender, EventArgs e)
        {
            int serviceInd = int.Parse(form1.textBox_PayloadNum.Text);
            try { form1.payloadClients[serviceInd].StartData(serviceInd, form1.payloadConfigs[serviceInd]); }
            catch (Exception ex) { }
        }

        private void btn_StopData_Click(object sender, EventArgs e)
        {
            int serviceInd = int.Parse(form1.textBox_PayloadNum.Text);
            try { form1.payloadClients[serviceInd].StopData(serviceInd, form1.payloadConfigs[serviceInd]); }
            catch (Exception ex) { }
        }
    }
}
