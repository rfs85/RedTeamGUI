using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedTeamGUI
{
    internal class NetworkClass
    {

        public void Greet()
        {
            
            MessageBox.Show("Hello World!");
        }

        public string GetDomain()
        {
            var domain = Environment.UserDomainName;
            return domain;
        }
        public string GetOSVersion()
        {
            var osversion = Environment.Version;
            return osversion.ToString();
;
        }
        public string GetUser()
        {
            var guser = Environment.UserName;
            return guser;
        }



    }

    
    
}
