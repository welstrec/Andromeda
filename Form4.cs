using System;
using System.Drawing;
using System.Windows.Forms;

namespace MikuDash
{
    public partial class CalendarFrm : Form
    {
        public CalendarFrm()
        {
            InitializeComponent();
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            this.Top = (resolution.Height - this.Height)-40;
            this.Left = (resolution.Width - this.Width);
            calendarCtrl.TodayDate = DateTime.Now;

            calendarCtrl.Width = this.Width;
            calendarCtrl.Height = this.Height;
            calendarCtrl.Top = 0;
            calendarCtrl.Left = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CalendarFrm_Load(object sender, EventArgs e)
        {

        }

       

      
    }
}
