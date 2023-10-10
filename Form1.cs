using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Net.NetworkInformation;

namespace RedTeamGUI
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
            //Hostname
            String strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            toolStripStatusLabel8.Text = strHostName;

            //LocalNetwork RFS = new LocalNetwork("","");
            //Local IP
            string myIP;
            myIP = Dns.GetHostByName(strHostName).AddressList[0].ToString();
            toolStripStatusLabel2.Text = myIP;
            //Username
            String myUserName = Environment.UserName;
            toolStripStatusLabel4.Text = myUserName;
            //Domain
            String SID = System.Security.Principal.WindowsIdentity.GetCurrent().Groups[0].ToString();
            toolStripStatusLabel6.Text = SID;

            String DOM = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;

            toolStripStatusLabel8.Text = DOM.ToString();
            
        }

       
        private string RunScript(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            pipeline.Commands.Add("Out-String");
            Collection<PSObject> results = pipeline.Invoke();
            runspace.Close();
            StringBuilder sb = new StringBuilder();
            foreach (PSObject obj in results)
            {
                sb.AppendLine(obj.ToString());
                
            }
            return sb.ToString();


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text = RunScript(textBox3.Text);
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text = RunScript(textBox4.Text);
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text = RunScript(comboBox2.Text);
        }
    }
}
