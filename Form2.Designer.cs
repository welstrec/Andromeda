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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MikuAnim));
            this.AndromedaBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AndromedaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AndromedaBox
            // 
            this.AndromedaBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AndromedaBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AndromedaBox.Location = new System.Drawing.Point(0, 0);
            this.AndromedaBox.Margin = new System.Windows.Forms.Padding(0);
            this.AndromedaBox.Name = "AndromedaBox";
            this.AndromedaBox.Size = new System.Drawing.Size(1022, 763);
            this.AndromedaBox.TabIndex = 12;
            this.AndromedaBox.TabStop = false;
            this.AndromedaBox.Click += new System.EventHandler(this.AndromedaBox_Click);
            this.AndromedaBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.AndromedaBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.AndromedaBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // MikuAnim
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 516);
            this.Controls.Add(this.AndromedaBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.MouseEnter += new System.EventHandler(this.MikuAnim_MouseEnter);
            this.MouseHover += new System.EventHandler(this.MikuAnim_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.AndromedaBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AndromedaBox;
    }
}