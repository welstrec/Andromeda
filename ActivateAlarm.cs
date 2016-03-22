using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Andromeda
{
    public partial class ActivateAlarm : Form
    {
        SoundPlayer snd;
        public ActivateAlarm()
        {
            InitializeComponent();
            this.TopMost = true;

            Stream str = Properties.Resources.alarmaSonido;
            snd = new SoundPlayer(str);
            snd.PlayLooping();
        }

        private void BotonCancelarAlarma_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.snd.Stop();
        }
        public void changeTextAlarm(string text)
        {
            
            this.textoRecordatorio.Text = text;
            
        }
    }
}
