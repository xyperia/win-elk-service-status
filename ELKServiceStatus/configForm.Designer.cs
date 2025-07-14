namespace ELKServiceStatus
{
    partial class configForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtES = new System.Windows.Forms.TextBox();
            this.txtKB = new System.Windows.Forms.TextBox();
            this.txtFS = new System.Windows.Forms.TextBox();
            this.txtLS = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtESLog = new System.Windows.Forms.TextBox();
            this.txtLSLog = new System.Windows.Forms.TextBox();
            this.txtFSLog = new System.Windows.Forms.TextBox();
            this.txtKBLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Service name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fleet Server service name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Logstash service name";
            // 
            // txtES
            // 
            this.txtES.Location = new System.Drawing.Point(17, 57);
            this.txtES.Name = "txtES";
            this.txtES.Size = new System.Drawing.Size(344, 26);
            this.txtES.TabIndex = 4;
            // 
            // txtKB
            // 
            this.txtKB.Location = new System.Drawing.Point(17, 58);
            this.txtKB.Name = "txtKB";
            this.txtKB.Size = new System.Drawing.Size(344, 26);
            this.txtKB.TabIndex = 5;
            // 
            // txtFS
            // 
            this.txtFS.Location = new System.Drawing.Point(17, 58);
            this.txtFS.Name = "txtFS";
            this.txtFS.Size = new System.Drawing.Size(344, 26);
            this.txtFS.TabIndex = 6;
            // 
            // txtLS
            // 
            this.txtLS.Location = new System.Drawing.Point(17, 54);
            this.txtLS.Name = "txtLS";
            this.txtLS.Size = new System.Drawing.Size(344, 26);
            this.txtLS.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(681, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtESLog);
            this.groupBox1.Controls.Add(this.txtES);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 182);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elasticsearch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Log path";
            // 
            // txtESLog
            // 
            this.txtESLog.Location = new System.Drawing.Point(18, 124);
            this.txtESLog.Name = "txtESLog";
            this.txtESLog.Size = new System.Drawing.Size(343, 26);
            this.txtESLog.TabIndex = 5;
            // 
            // txtLSLog
            // 
            this.txtLSLog.Location = new System.Drawing.Point(18, 124);
            this.txtLSLog.Name = "txtLSLog";
            this.txtLSLog.Size = new System.Drawing.Size(343, 26);
            this.txtLSLog.TabIndex = 10;
            // 
            // txtFSLog
            // 
            this.txtFSLog.Location = new System.Drawing.Point(17, 124);
            this.txtFSLog.Name = "txtFSLog";
            this.txtFSLog.Size = new System.Drawing.Size(344, 26);
            this.txtFSLog.TabIndex = 11;
            // 
            // txtKBLog
            // 
            this.txtKBLog.Location = new System.Drawing.Point(19, 124);
            this.txtKBLog.Name = "txtKBLog";
            this.txtKBLog.Size = new System.Drawing.Size(342, 26);
            this.txtKBLog.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFS);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFSLog);
            this.groupBox2.Location = new System.Drawing.Point(37, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 205);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fleet Server";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Log path";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtKB);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtKBLog);
            this.groupBox3.Location = new System.Drawing.Point(447, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 182);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kibana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Log path";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtLS);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtLSLog);
            this.groupBox4.Location = new System.Drawing.Point(447, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 205);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logstash";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Log path";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(32, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(431, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "https://github.com/xyperia/win-elk-service-status";
            // 
            // configForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 546);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "configForm";
            this.Text = "Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtES;
        private System.Windows.Forms.TextBox txtKB;
        private System.Windows.Forms.TextBox txtFS;
        private System.Windows.Forms.TextBox txtLS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtESLog;
        private System.Windows.Forms.TextBox txtLSLog;
        private System.Windows.Forms.TextBox txtFSLog;
        private System.Windows.Forms.TextBox txtKBLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}