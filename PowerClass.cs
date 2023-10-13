using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
//using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static RedTeamGUI.MainForm1;



namespace RedTeamGUI
{
    public class PowerClass
    {
        public string RunScript(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            pipeline.Commands.Add("Out-String");
            Collection<PSObject> results = pipeline.Invoke();
            //runspace.Close();
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
            processStartInfo.UseShellExecute = false;

            var process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            return output.ToString(); // I am invoked using ProcessStartInfoClass!
        }

        public static PowerShell Create(string pathToScript)
        {
            PowerShell ps = PowerShell.Create();
            ps.AddScript(pathToScript).Invoke();
            return ps;
        }

    }

}
