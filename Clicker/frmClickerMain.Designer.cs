
namespace XYZClicker
{
    partial class frmClickerMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClickerMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.numClicks = new System.Windows.Forms.NumericUpDown();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.lblClicks = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 123);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // numClicks
            // 
            this.numClicks.Location = new System.Drawing.Point(82, 12);
            this.numClicks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClicks.Name = "numClicks";
            this.numClicks.Size = new System.Drawing.Size(56, 20);
            this.numClicks.TabIndex = 0;
            this.numClicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(82, 64);
            this.numDelay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(56, 20);
            this.numDelay.TabIndex = 2;
            this.numDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDelay.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblClicks
            // 
            this.lblClicks.AutoSize = true;
            this.lblClicks.Location = new System.Drawing.Point(12, 14);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(64, 13);
            this.lblClicks.TabIndex = 3;
            this.lblClicks.Text = "Click Count:";
            this.lblClicks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(25, 66);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(51, 13);
            this.lblDelay.TabIndex = 4;
            this.lblDelay.Text = "Delay (s):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interval (ms):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(82, 38);
            this.numInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(56, 20);
            this.numInterval.TabIndex = 1;
            this.numInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(12, 123);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(126, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(12, 87);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(126, 33);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Press ESC to cancel";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmClickerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 160);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblClicks);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.numClicks);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmClickerMain";
            this.Text = "XYZ Clicker";
            this.Load += new System.EventHandler(this.frmClickerMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown numClicks;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.Label lblClicks;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblInfo;
    }
}

