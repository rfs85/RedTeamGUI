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
using System.DirectoryServices.ActiveDirectory;
using RedTeamGUI;
using System.Management;

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
            NetworkClass guset = new NetworkClass(); ;
            toolStripStatusLabel4.Text = guset.ToString();
            //SID
            String SID = System.Security.Principal.WindowsIdentity.GetCurrent().Groups[0].ToString();
            toolStripStatusLabel6.Text = SID;


            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                Console.WriteLine("Username : {0}", envVar["Name"]);
            }






            var version = Environment.Version;
            toolStripStatusLabel10.Text = version.ToString();

            string title = @"
                            UNINSTALLING VALORANT
                            ▇▇▇▇▇▇▇▇▇▇▇▇▇▇▢
　　                            ╭━╮╭━╮╭╮　╱ 　　
　　                            ╰━┫╰━┫╰╯╱╭╮ 　　
　　                            ╰━╯╰━╯　╱　╰╯ 　　　　　
　　　                                 COMPLETE
                            ";

            textBox5.Text = title;

            NetworkClass netclass = new NetworkClass();
            toolStripStatusLabel8.Text = netclass.GetDomain();




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
        public string ExecuteScript(string pathToScript)
        {
            var scriptArguments = "-ExecutionPolicy Bypass -File \"" + pathToScript + "\"";
            var processStartInfo = new ProcessStartInfo("powershell.exe", scriptArguments);
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;

            var process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            return output; // I am invoked using ProcessStartInfoClass!
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

        private void binariesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binaries binaries = new Binaries();
            binaries.ShowDialog();
        }

        private void powershellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PSModules psmodules = new PSModules();
            psmodules.ShowDialog();

        }

        private void dumpCreds_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox5.Text = ExecuteScript(comboBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
   
        }
    }
}
