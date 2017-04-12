namespace MikuDash
{
    partial class CalendarFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarFrm));
            this.calendarCtrl = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // calendarCtrl
            // 
            this.calendarCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarCtrl.Location = new System.Drawing.Point(0, 0);
            this.calendarCtrl.Name = "calendarCtrl";
            this.calendarCtrl.ShowToday = false;
            this.calendarCtrl.TabIndex = 0;
            // 
            // CalendarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 237);
            this.Controls.Add(this.calendarCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalendarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarCtrl;
    }
}