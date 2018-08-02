using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTesting
{
    class UsePowerShell
    {
      

        public void Start(string scriptfile)
        {
            Process.Start("C:/Windows/System32/WindowsPowerShell/v1.0/powershell.exe", scriptfile);
        }
    }
}
