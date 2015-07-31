namespace MikuDash
{
    partial class MikuAnim
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
            this.mikuBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mikuBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mikuBox
            // 
            this.mikuBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mikuBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mikuBox.Location = new System.Drawing.Point(0, 0);
            this.mikuBox.Name = "mikuBox";
            this.mikuBox.Size = new System.Drawing.Size(1022, 763);
            this.mikuBox.TabIndex = 12;
            this.mikuBox.TabStop = false;
            this.mikuBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.mikuBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.mikuBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // MikuAnim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.mikuBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MikuAnim";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AndromedaAnimation";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MikuAnim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mikuBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mikuBox;

    }
}