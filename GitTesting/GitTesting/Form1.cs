using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTesting
{
    public partial class PowerShellButtons : Form
    {
        public PowerShellButtons()
        {
            InitializeComponent();
        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void StopServiceButton_Click(object sender, EventArgs e)
        {

        }

        private void StartServiceButton_Click(object sender, EventArgs e)
        {

        }

        private void GetServiceButton_Click(object sender, EventArgs e)
        {
            UsePowerShell getservice = new UsePowerShell();
            getservice.Start("Get-Service"); 
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
    }
}
