namespace ELKServiceStatus
{
    partial class FormLog
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
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTail = new System.Windows.Forms.Button();
            this.refreshLogTimer = new System.Windows.Forms.Timer(this.components);
            this.spinnerLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerLength)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(148, 36);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(375, 28);
            this.cmbService.TabIndex = 0;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtLog.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtLog.Location = new System.Drawing.Point(29, 92);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1671, 733);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "System.out;";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Service Name :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1469, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 51);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTail
            // 
            this.btnTail.Location = new System.Drawing.Point(1587, 23);
            this.btnTail.Name = "btnTail";
            this.btnTail.Size = new System.Drawing.Size(112, 51);
            this.btnTail.TabIndex = 4;
            this.btnTail.Text = "Tail Log";
            this.btnTail.UseVisualStyleBackColor = true;
            this.btnTail.Click += new System.EventHandler(this.btnTail_Click);
            // 
            // refreshLogTimer
            // 
            this.refreshLogTimer.Interval = 1000;
            this.refreshLogTimer.Tick += new System.EventHandler(this.refreshLogTimer_Tick);
            // 
            // spinnerLength
            // 
            this.spinnerLength.Location = new System.Drawing.Point(1533, 844);
            this.spinnerLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinnerLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerLength.Name = "spinnerLength";
            this.spinnerLength.Size = new System.Drawing.Size(120, 26);
            this.spinnerLength.TabIndex = 6;
            this.spinnerLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinnerLength.ValueChanged += new System.EventHandler(this.spinnerLength_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1427, 846);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Display size :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1659, 844);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "lines";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 888);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinnerLength);
            this.Controls.Add(this.btnTail);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.cmbService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLog";
            this.Text = "Services Log";
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinnerLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTail;
        private System.Windows.Forms.Timer refreshLogTimer;
        private System.Windows.Forms.NumericUpDown spinnerLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}