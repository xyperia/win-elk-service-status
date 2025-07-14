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
    public partial class ELKServiceMainForm : Form
    {
        ServiceController es, kb, fs, ls;

        public ELKServiceMainForm()
        {
            InitializeComponent();
            refreshFormValue();
        }

        public void refreshFormValue()
        {
            es = new ServiceController(Properties.Settings.Default.esServiceName);
            kb = new ServiceController(Properties.Settings.Default.kbServiceName);
            fs = new ServiceController(Properties.Settings.Default.fsServiceName);
            ls = new ServiceController(Properties.Settings.Default.lsServiceName);

            try
            {
                esStatus.Text = es.Status.ToString();
                kbStatus.Text = kb.Status.ToString();
                fsStatus.Text = fs.Status.ToString();
                lsStatus.Text = ls.Status.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping service: " + ex.Message);
            }
            
        }

        private void btnStartES_Click(object sender, EventArgs e)
        {
            try
            {
                if (es.Status == ServiceControllerStatus.Stopped)
                {
                    es.Start();
                    es.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting service: " + ex.Message);
            }
        }

        private void btnStopES_Click(object sender, EventArgs e)
        {
            try
            {
                if (es.Status == ServiceControllerStatus.Running)
                {
                    es.Stop();
                    es.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping service: " + ex.Message);
            }
        }

        private void timerStatus_Tick(object sender, EventArgs e)
        {
            try
            {
                // Elasticsearch Control
                esStatus.Text = es.Status.ToString();
                if(esStatus.Text.Equals("Running"))
                {
                    esStatus.ForeColor = Color.Green;
                } else
                {
                    esStatus.ForeColor = Color.Red;
                }

                // Kibana Control
                kbStatus.Text = kb.Status.ToString();
                if (kbStatus.Text.Equals("Running"))
                {
                    kbStatus.ForeColor = Color.Green;
                }
                else
                {
                    kbStatus.ForeColor = Color.Red;
                }

                // Fleet Server Control
                fsStatus.Text = fs.Status.ToString();
                if (fsStatus.Text.Equals("Running"))
                {
                    fsStatus.ForeColor = Color.Green;
                }
                else
                {
                    fsStatus.ForeColor = Color.Red;
                }

                // Logstash Control
                lsStatus.Text = ls.Status.ToString();
                if (lsStatus.Text.Equals("Running"))
                {
                    lsStatus.ForeColor = Color.Green;
                }
                else
                {
                    lsStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lsStatus.Text = "Error - " + ex.Message;
            }
        }

        private void btnStartKB_Click(object sender, EventArgs e)
        {
            try
            {
                if (kb.Status == ServiceControllerStatus.Stopped)
                {
                    kb.Start();
                    kb.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting service: " + ex.Message);
            }
        }

        private void btnStopKB_Click(object sender, EventArgs e)
        {
            try
            {
                if (kb.Status == ServiceControllerStatus.Running)
                {
                    kb.Stop();
                    kb.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping service: " + ex.Message);
            }
        }

        private void btnStartFS_Click(object sender, EventArgs e)
        {
            try
            {
                if (fs.Status == ServiceControllerStatus.Stopped)
                {
                    fs.Start();
                    fs.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting service: " + ex.Message);
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            configForm configForm = new configForm();
            if (configForm.ShowDialog() == DialogResult.OK)
            {
                //string result = configForm.SelectedValue; // Access the public property
                refreshFormValue();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FormLog formLog = new FormLog();
            formLog.ShowDialog();
        }

        private void btnStopFS_Click(object sender, EventArgs e)
        {
            try
            {
                if (fs.Status == ServiceControllerStatus.Running)
                {
                    fs.Stop();
                    fs.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping service: " + ex.Message);
            }
        }

        private void btnStartLS_Click(object sender, EventArgs e)
        {
            try
            {
                if (ls.Status == ServiceControllerStatus.Stopped)
                {
                    ls.Start();
                    ls.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting service: " + ex.Message);
            }
        }

        private void btnStopLS_Click(object sender, EventArgs e)
        {
            try
            {
                if (ls.Status == ServiceControllerStatus.Running)
                {
                    ls.Stop();
                    ls.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping service: " + ex.Message);
            }
        }
    }
}
