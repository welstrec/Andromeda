namespace Andromeda
{
    partial class MonitorInstance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorInstance));
            this.monNameDsp = new System.Windows.Forms.Label();
            this.clkDsp = new System.Windows.Forms.Label();
            this.tempDsp = new System.Windows.Forms.Label();
            this.ldDsp = new System.Windows.Forms.Label();
            this.ramDsp = new System.Windows.Forms.Label();
            this.ldGau = new System.Windows.Forms.PictureBox();
            this.ramGau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ldGau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramGau)).BeginInit();
            this.SuspendLayout();
            // 
            // monNameDsp
            // 
            this.monNameDsp.BackColor = System.Drawing.Color.Transparent;
            this.monNameDsp.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.monNameDsp.Location = new System.Drawing.Point(26, 8);
            this.monNameDsp.Name = "monNameDsp";
            this.monNameDsp.Size = new System.Drawing.Size(54, 23);
            this.monNameDsp.TabIndex = 0;
            this.monNameDsp.Text = "CPU";
            this.monNameDsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clkDsp
            // 
            this.clkDsp.AutoSize = true;
            this.clkDsp.BackColor = System.Drawing.Color.Transparent;
            this.clkDsp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clkDsp.ForeColor = System.Drawing.Color.White;
            this.clkDsp.Location = new System.Drawing.Point(50, 36);
            this.clkDsp.Name = "clkDsp";
            this.clkDsp.Size = new System.Drawing.Size(35, 14);
            this.clkDsp.TabIndex = 1;
            this.clkDsp.Text = "0000";
            this.clkDsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempDsp
            // 
            this.tempDsp.AutoSize = true;
            this.tempDsp.BackColor = System.Drawing.Color.Transparent;
            this.tempDsp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tempDsp.ForeColor = System.Drawing.Color.White;
            this.tempDsp.Location = new System.Drawing.Point(123, 36);
            this.tempDsp.Name = "tempDsp";
            this.tempDsp.Size = new System.Drawing.Size(28, 14);
            this.tempDsp.TabIndex = 2;
            this.tempDsp.Text = "000";
            this.tempDsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tempDsp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tempDsp_MouseDown);
            this.tempDsp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tempDsp_MouseMove);
            this.tempDsp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tempDsp_MouseUp);
            // 
            // ldDsp
            // 
            this.ldDsp.AutoSize = true;
            this.ldDsp.BackColor = System.Drawing.Color.Transparent;
            this.ldDsp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ldDsp.ForeColor = System.Drawing.Color.White;
            this.ldDsp.Location = new System.Drawing.Point(444, 6);
            this.ldDsp.Name = "ldDsp";
            this.ldDsp.Size = new System.Drawing.Size(28, 14);
            this.ldDsp.TabIndex = 3;
            this.ldDsp.Text = "100";
            this.ldDsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramDsp
            // 
            this.ramDsp.AutoSize = true;
            this.ramDsp.BackColor = System.Drawing.Color.Transparent;
            this.ramDsp.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ramDsp.ForeColor = System.Drawing.Color.White;
            this.ramDsp.Location = new System.Drawing.Point(439, 21);
            this.ramDsp.Name = "ramDsp";
            this.ramDsp.Size = new System.Drawing.Size(20, 12);
            this.ramDsp.TabIndex = 4;
            this.ramDsp.Text = "100";
            this.ramDsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ldGau
            // 
            this.ldGau.BackColor = System.Drawing.Color.Transparent;
            this.ldGau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ldGau.BackgroundImage")));
            this.ldGau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ldGau.Location = new System.Drawing.Point(123, 8);
            this.ldGau.Name = "ldGau";
            this.ldGau.Size = new System.Drawing.Size(349, 10);
            this.ldGau.TabIndex = 5;
            this.ldGau.TabStop = false;
            // 
            // ramGau
            // 
            this.ramGau.BackColor = System.Drawing.Color.Transparent;
            this.ramGau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ramGau.BackgroundImage")));
            this.ramGau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ramGau.Location = new System.Drawing.Point(118, 22);
            this.ramGau.Name = "ramGau";
            this.ramGau.Size = new System.Drawing.Size(341, 10);
            this.ramGau.TabIndex = 6;
            this.ramGau.TabStop = false;
            // 
            // MonitorInstance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(492, 64);
            this.Controls.Add(this.ramDsp);
            this.Controls.Add(this.ldDsp);
            this.Controls.Add(this.tempDsp);
            this.Controls.Add(this.clkDsp);
            this.Controls.Add(this.monNameDsp);
            this.Controls.Add(this.ramGau);
            this.Controls.Add(this.ldGau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitorInstance";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MonitorInstance";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.VisibleChanged += new System.EventHandler(this.MonitorInstance_VisibleChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tempDsp_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tempDsp_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tempDsp_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ldGau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramGau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monNameDsp;
        private System.Windows.Forms.Label clkDsp;
        private System.Windows.Forms.Label tempDsp;
        private System.Windows.Forms.Label ldDsp;
        private System.Windows.Forms.Label ramDsp;
        private System.Windows.Forms.PictureBox ldGau;
        private System.Windows.Forms.PictureBox ramGau;
    }
}