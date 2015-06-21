using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

       

      
    }
}
