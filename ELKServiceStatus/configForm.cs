using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELKServiceStatus
{
    public partial class configForm : Form
    {
        public configForm()
        {
            InitializeComponent();

            txtES.Text = Properties.Settings.Default.esServiceName;
            txtKB.Text = Properties.Settings.Default.kbServiceName;
            txtFS.Text = Properties.Settings.Default.fsServiceName;
            txtLS.Text = Properties.Settings.Default.lsServiceName;

            txtESLog.Text = Properties.Settings.Default.esLog;
            txtKBLog.Text = Properties.Settings.Default.kbLog;
            txtFSLog.Text = Properties.Settings.Default.fsLog;
            txtLSLog.Text = Properties.Settings.Default.lsLog;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.esServiceName = txtES.Text;
            Properties.Settings.Default.kbServiceName = txtKB.Text;
            Properties.Settings.Default.fsServiceName = txtFS.Text;
            Properties.Settings.Default.lsServiceName = txtLS.Text;

            Properties.Settings.Default.esLog = txtESLog.Text; 
            Properties.Settings.Default.kbLog = txtKBLog.Text; 
            Properties.Settings.Default.fsLog = txtFSLog.Text; 
            Properties.Settings.Default.lsLog = txtLSLog.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
