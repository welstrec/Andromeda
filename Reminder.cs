using System;
using System.Drawing;
using System.Windows.Forms;

namespace Andromeda
{
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
            inicialitation();
        }
        public void inicialitation()
        {
            this.Icon = Andromeda.Properties.Resources.alarma;
            this.Opacity = 0.95;
            this.CenterToScreen();
            this.checkBoxMonday.BackColor = Color.Transparent;
            this.checkBoxTuesday.BackColor = Color.Transparent;
            this.checkBoxWednesday.BackColor = Color.Transparent;
            this.checkBoxThursday.BackColor = Color.Transparent;
            this.checkBoxFriday.BackColor = Color.Transparent;
            this.checkBoxSaturday.BackColor = Color.Transparent;
            this.checkBoxSunday.BackColor = Color.Transparent;
            this.checkBoxActivateAlarm.BackColor = Color.Transparent;
            string[] hora = { "1", "2", "3", "4", "5", "6", "7", "8","9","10","11","12"};
            this.comboBoxHora.DataSource=hora;
            string[] min = {"","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            for(int i=0; i<60;i++)
            {
                min.SetValue(i+"",i);
            }
            this.comboBoxMinuto.DataSource = min;
            this.comboBoxSegundo.DataSource = min;
            string []horario = {"AM","PM"};
            this.comboBoxAMPM.DataSource = horario;
            Color fondo =fondo = ColorTranslator.FromHtml("#1f3c5a");
            this.AlarmaComentario.BackColor = fondo;
            this.listaAlarma.BackColor = fondo;
            Color fondo2 = ColorTranslator.FromHtml("#274b72");
            this.botonAgregarAlarma.BackColor=fondo2;
            this.botonEliminarAlarma.BackColor = fondo2;
        }
    }
}
