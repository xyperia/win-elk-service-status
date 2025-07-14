namespace ELKServiceStatus
{
    partial class ELKServiceMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartES = new System.Windows.Forms.Button();
            this.btnStopES = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.esStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kbStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartKB = new System.Windows.Forms.Button();
            this.btnStopKB = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fsStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartFS = new System.Windows.Forms.Button();
            this.btnStopFS = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartLS = new System.Windows.Forms.Button();
            this.btnStopLS = new System.Windows.Forms.Button();
            this.timerStatus = new System.Windows.Forms.Timer(this.components);
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartES
            // 
            this.btnStartES.Location = new System.Drawing.Point(18, 73);
            this.btnStartES.Name = "btnStartES";
            this.btnStartES.Size = new System.Drawing.Size(92, 45);
            this.btnStartES.TabIndex = 0;
            this.btnStartES.Text = "Start";
            this.btnStartES.UseVisualStyleBackColor = true;
            this.btnStartES.Click += new System.EventHandler(this.btnStartES_Click);
            // 
            // btnStopES
            // 
            this.btnStopES.Location = new System.Drawing.Point(116, 73);
            this.btnStopES.Name = "btnStopES";
            this.btnStopES.Size = new System.Drawing.Size(92, 45);
            this.btnStopES.TabIndex = 2;
            this.btnStopES.Text = "Stop";
            this.btnStopES.UseVisualStyleBackColor = true;
            this.btnStopES.Click += new System.EventHandler(this.btnStopES_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.esStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStartES);
            this.groupBox1.Controls.Add(this.btnStopES);
            this.groupBox1.Location = new System.Drawing.Point(34, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 134);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elasticsearch service";
            // 
            // esStatus
            // 
            this.esStatus.AutoSize = true;
            this.esStatus.Location = new System.Drawing.Point(84, 36);
            this.esStatus.Name = "esStatus";
            this.esStatus.Size = new System.Drawing.Size(35, 20);
            this.esStatus.TabIndex = 4;
            this.esStatus.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kbStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnStartKB);
            this.groupBox2.Controls.Add(this.btnStopKB);
            this.groupBox2.Location = new System.Drawing.Point(271, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kibana service";
            // 
            // kbStatus
            // 
            this.kbStatus.AutoSize = true;
            this.kbStatus.Location = new System.Drawing.Point(84, 36);
            this.kbStatus.Name = "kbStatus";
            this.kbStatus.Size = new System.Drawing.Size(35, 20);
            this.kbStatus.TabIndex = 5;
            this.kbStatus.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status: ";
            // 
            // btnStartKB
            // 
            this.btnStartKB.Location = new System.Drawing.Point(18, 73);
            this.btnStartKB.Name = "btnStartKB";
            this.btnStartKB.Size = new System.Drawing.Size(92, 45);
            this.btnStartKB.TabIndex = 0;
            this.btnStartKB.Text = "Start";
            this.btnStartKB.UseVisualStyleBackColor = true;
            this.btnStartKB.Click += new System.EventHandler(this.btnStartKB_Click);
            // 
            // btnStopKB
            // 
            this.btnStopKB.Location = new System.Drawing.Point(116, 73);
            this.btnStopKB.Name = "btnStopKB";
            this.btnStopKB.Size = new System.Drawing.Size(92, 45);
            this.btnStopKB.TabIndex = 2;
            this.btnStopKB.Text = "Stop";
            this.btnStopKB.UseVisualStyleBackColor = true;
            this.btnStopKB.Click += new System.EventHandler(this.btnStopKB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fsStatus);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnStartFS);
            this.groupBox3.Controls.Add(this.btnStopFS);
            this.groupBox3.Location = new System.Drawing.Point(508, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 134);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fleet Server service";
            // 
            // fsStatus
            // 
            this.fsStatus.AutoSize = true;
            this.fsStatus.Location = new System.Drawing.Point(84, 36);
            this.fsStatus.Name = "fsStatus";
            this.fsStatus.Size = new System.Drawing.Size(35, 20);
            this.fsStatus.TabIndex = 6;
            this.fsStatus.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status: ";
            // 
            // btnStartFS
            // 
            this.btnStartFS.Location = new System.Drawing.Point(18, 73);
            this.btnStartFS.Name = "btnStartFS";
            this.btnStartFS.Size = new System.Drawing.Size(92, 45);
            this.btnStartFS.TabIndex = 0;
            this.btnStartFS.Text = "Start";
            this.btnStartFS.UseVisualStyleBackColor = true;
            this.btnStartFS.Click += new System.EventHandler(this.btnStartFS_Click);
            // 
            // btnStopFS
            // 
            this.btnStopFS.Location = new System.Drawing.Point(116, 73);
            this.btnStopFS.Name = "btnStopFS";
            this.btnStopFS.Size = new System.Drawing.Size(92, 45);
            this.btnStopFS.TabIndex = 2;
            this.btnStopFS.Text = "Stop";
            this.btnStopFS.UseVisualStyleBackColor = true;
            this.btnStopFS.Click += new System.EventHandler(this.btnStopFS_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsStatus);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnStartLS);
            this.groupBox4.Controls.Add(this.btnStopLS);
            this.groupBox4.Location = new System.Drawing.Point(745, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 134);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logstash service";
            // 
            // lsStatus
            // 
            this.lsStatus.AutoSize = true;
            this.lsStatus.Location = new System.Drawing.Point(84, 36);
            this.lsStatus.Name = "lsStatus";
            this.lsStatus.Size = new System.Drawing.Size(35, 20);
            this.lsStatus.TabIndex = 7;
            this.lsStatus.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status: ";
            // 
            // btnStartLS
            // 
            this.btnStartLS.Location = new System.Drawing.Point(18, 73);
            this.btnStartLS.Name = "btnStartLS";
            this.btnStartLS.Size = new System.Drawing.Size(92, 45);
            this.btnStartLS.TabIndex = 0;
            this.btnStartLS.Text = "Start";
            this.btnStartLS.UseVisualStyleBackColor = true;
            this.btnStartLS.Click += new System.EventHandler(this.btnStartLS_Click);
            // 
            // btnStopLS
            // 
            this.btnStopLS.Location = new System.Drawing.Point(116, 73);
            this.btnStopLS.Name = "btnStopLS";
            this.btnStopLS.Size = new System.Drawing.Size(92, 45);
            this.btnStopLS.TabIndex = 2;
            this.btnStopLS.Text = "Stop";
            this.btnStopLS.UseVisualStyleBackColor = true;
            this.btnStopLS.Click += new System.EventHandler(this.btnStopLS_Click);
            // 
            // timerStatus
            // 
            this.timerStatus.Enabled = true;
            this.timerStatus.Interval = 1000;
            this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(830, 197);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(146, 46);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(677, 197);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(146, 46);
            this.btnLog.TabIndex = 8;
            this.btnLog.Text = "Logs";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // ELKServiceMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 276);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ELKServiceMainForm";
            this.Text = "ELK Service Status v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartES;
        private System.Windows.Forms.Button btnStopES;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartKB;
        private System.Windows.Forms.Button btnStopKB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStartFS;
        private System.Windows.Forms.Button btnStopFS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartLS;
        private System.Windows.Forms.Button btnStopLS;
        private System.Windows.Forms.Label esStatus;
        private System.Windows.Forms.Label kbStatus;
        private System.Windows.Forms.Label fsStatus;
        private System.Windows.Forms.Label lsStatus;
        private System.Windows.Forms.Timer timerStatus;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnLog;
    }
}

