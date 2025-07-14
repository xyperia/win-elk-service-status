using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELKServiceStatus
{
    public partial class FormLog : Form
    {
        private string selectedLogPath = "";
        private Int32 linesMax = Properties.Settings.Default.logMaxLines;
        public FormLog()
        {
            InitializeComponent();
            spinnerLength.Value = linesMax;
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServiceName = cmbService.SelectedItem.ToString();
            selectedLogPath = GetLogPathFromServiceName(selectedServiceName);

            if (!File.Exists(selectedLogPath))
            {
                txtLog.Text = $"Log file not found:\n{selectedLogPath}";
                return;
            }

            RefreshLog();   // Initial load
        }

        private void RefreshLog()
        {
            txtLog.Text = ReadLastLines(selectedLogPath, linesMax);
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private string ReadLastLines(string path, int lineCount)
        {
            try
            {
                var lines = new List<string>();

                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                using (StreamReader reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        lines.Add(reader.ReadLine());
                        if (lines.Count > lineCount)
                            lines.RemoveAt(0); // keep only the last N lines
                    }
                }
                //txtLog.Text = "";
                return string.Join(Environment.NewLine, lines);
            }
            catch (Exception ex)
            {
                return $"Error reading log: {ex.Message}";
            }
        }


        private string GetLogPathFromServiceName(string serviceName)
        {
            if (serviceName == Properties.Settings.Default.esServiceName)
                return Properties.Settings.Default.esLog;

            if (serviceName == Properties.Settings.Default.kbServiceName)
                return Properties.Settings.Default.kbLog;

            if (serviceName == Properties.Settings.Default.fsServiceName)
                return Properties.Settings.Default.fsLog;

            if (serviceName == Properties.Settings.Default.lsServiceName)
                return Properties.Settings.Default.lsLog;

            return string.Empty;
        }


        private void FormLog_Load(object sender, EventArgs e)
        {
            cmbService.Items.Add(Properties.Settings.Default.esServiceName);
            cmbService.Items.Add(Properties.Settings.Default.kbServiceName);
            cmbService.Items.Add(Properties.Settings.Default.fsServiceName);
            cmbService.Items.Add(Properties.Settings.Default.lsServiceName);
            cmbService.SelectedIndex = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshLog();
        }

        private void btnTail_Click(object sender, EventArgs e)
        {
            if (refreshLogTimer.Enabled == false)
            {
                btnTail.Text = "Stop";
                btnRefresh.Enabled = false;
                spinnerLength.Enabled = false;
                refreshLogTimer.Enabled = true;
            }
            else
            {
                btnTail.Text = "Tail Log";
                btnRefresh.Enabled = true;
                spinnerLength.Enabled = true;
                refreshLogTimer.Enabled = false;
            }
        }

        private void refreshLogTimer_Tick(object sender, EventArgs e)
        {
            RefreshLog();
        }

        private void spinnerLength_ValueChanged(object sender, EventArgs e)
        {
            linesMax = Convert.ToInt32(spinnerLength.Value);
            Properties.Settings.Default.logMaxLines = linesMax;
        }
    }
}
