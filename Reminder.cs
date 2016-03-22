using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Andromeda
{
    public partial class Reminder : Form
    {
        private ArrayList listReminder;
        private ArrayList day;
        private ArrayList remainder;
        public Reminder()
        {
            InitializeComponent();
            inicialitation();
        }
        public void inicialitation()
        {
            this.Icon =Properties.Resources.alarma;
            cargarDatos();
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
            this.labelHora.BackColor = Color.Transparent;
            this.labelMinuto.BackColor = Color.Transparent;
            this.labelSegundo.BackColor = Color.Transparent;
            this.labelPMAM.BackColor = Color.Transparent;
            this.labelRecodatorio.BackColor = Color.Transparent;
            string[] hora = { "1", "2", "3", "4", "5", "6", "7", "8","9","10","11","12"};
            this.comboBoxHora.DataSource=hora;
            string[] min = {"","", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            string[] seg = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            for (int i=0; i<60;i++)
            {
                min.SetValue(""+i,i);
                seg.SetValue(""+i, i);
            }
            this.comboBoxMinuto.DataSource = min;
            this.comboBoxSegundo.DataSource = seg;
            string []horario = {"AM","PM"};
            this.comboBoxAMPM.DataSource = horario;
            Color fondo =fondo = ColorTranslator.FromHtml("#1f3c5a");
            this.AlarmaComentario.BackColor = fondo;
            this.listaAlarma.BackColor = fondo;
            Color fondo2 = ColorTranslator.FromHtml("#274b72");
            this.botonAgregarAlarma.BackColor=fondo2;
            this.botonEliminarAlarma.BackColor = fondo2;
            Timer ThreadCalculateReminder = new Timer();
            ThreadCalculateReminder.Tick += new EventHandler(calculateReminder);
            ThreadCalculateReminder.Interval = 1000;
            ThreadCalculateReminder.Start();
        }
        private void cargarDatos()
        {
            try
            {
                BinaryFormatter serializer = new BinaryFormatter();
                using (var stream = File.OpenRead("Reminder/day.Reminder"))
                {
                    day = (ArrayList)serializer.Deserialize(stream);
                }
                using (var stream = File.OpenRead("Reminder/hour.Reminder"))
                {
                    listReminder = (ArrayList)serializer.Deserialize(stream);
                }
                using (var stream = File.OpenRead("Reminder/remainder.Reminder"))
                {
                    remainder = (ArrayList)serializer.Deserialize(stream);
                }
                this.listaAlarma.DataSource = remainder;
            }
            catch(Exception e)
            {
                day = new ArrayList();
                listReminder = new ArrayList();
                remainder = new ArrayList();
            }

        }
        public void calculateReminder(object sender, EventArgs e)
        {
          
            DateTime dateValue = DateTime.Now;
            string []actual = dateValue.ToString("h:m:s").Split(':');
            string horaC =actual[0]+ "";
            string minC = actual[1] + "";
            string segC = actual[2] + "";
            string Tim = dateValue.ToString("tt", CultureInfo.InvariantCulture);
            string dayC = dateValue.DayOfWeek+"";
            string dateF = dateValue.ToLongDateString();
            for (int i=0; i< day.Count;i++)
            {
                if(day[i].ToString().Contains(dayC))
                {
                    string[] hour = listReminder[i].ToString().Split(';');
                    if ((hour[0].Equals(horaC)) && (hour[1].Equals(minC)) && (hour[2].Equals(segC)) && (hour[3].Equals(Tim)))
                    {
                        ActivateAlarm ac = new ActivateAlarm();
                        ac.changeTextAlarm(remainder[i].ToString());
                        ac.Visible = true;
                    }
                }
                if(dateF.Equals(day[i]))
                {
                    
                    string[] hour = listReminder[i].ToString().Split(';');
                    if ((hour[0].Equals(horaC)) && (hour[1].Equals(minC)) && (hour[2].Equals(segC)) && (hour[3].Equals(Tim)))
                    {
                        ActivateAlarm ac = new ActivateAlarm();
                        ac.changeTextAlarm(remainder[i].ToString());
                        ac.Visible = true;
                    }
                }

            }
        }

        private void botonAgregarAlarma_Click(object sender, EventArgs e)
        {
            if(!AlarmaComentario.Text.Equals(""))
            {
                string tempDay = "";
                if (checkBoxFriday.Visible)
                {
                    if (checkBoxMonday.Checked)
                    {

                        tempDay = tempDay + "Monday";
                    }
                    if (checkBoxTuesday.Checked)
                    {
                        tempDay = tempDay + "Tuesday";
                    }
                    if (checkBoxWednesday.Checked)
                    {
                        tempDay = tempDay + "Wednesday";
                    }
                    if (checkBoxThursday.Checked)
                    {
                        tempDay = tempDay + "Thursday";
                    }
                    if (checkBoxFriday.Checked)
                    {
                        tempDay = tempDay + "Friday";
                    }
                    if (checkBoxSaturday.Checked)
                    {
                        tempDay = tempDay + "Saturday";
                    }
                    if (checkBoxSunday.Checked)
                    {
                        tempDay = tempDay + "Sunday";
                    }
                    tempDay = tempDay + ";";
                }
                else
                {
                    tempDay = Calendario.SelectionStart.ToLongDateString();
                }

                day.Add(tempDay);
                string hora = "";
                hora = hora + comboBoxHora.SelectedItem + ";";
                hora = hora + comboBoxMinuto.SelectedItem + ";";
                hora = hora + comboBoxSegundo.SelectedItem + ";";
                hora = hora + comboBoxAMPM.SelectedItem;
                listReminder.Add(hora);
                saveData();
                AlarmaComentario.Text = "";

                listaAlarma.DataSource = null;
                listaAlarma.Items.Clear();
                listaAlarma.DataSource = remainder;
            }
            else
            {
                MessageBox.Show("Please put a note in the comentary box.");
            }

         
        }
        public void saveData()
        {
            String comentario = AlarmaComentario.Text;
            remainder.Add(comentario);

            if (!Directory.Exists("Reminder"))
            {
                Directory.CreateDirectory("Reminder");
            }
            BinaryFormatter serializer = new BinaryFormatter();
            using (var stream = File.OpenWrite("Reminder/day.Reminder"))
            {
                serializer.Serialize(stream, day);
            }
            using (var stream = File.OpenWrite("Reminder/hour.Reminder"))
            {
                serializer.Serialize(stream, listReminder);
            }
            using (var stream = File.OpenWrite("Reminder/remainder.Reminder"))
            {
                serializer.Serialize(stream, remainder);
            }
        }

        private void botonEliminarAlarma_Click(object sender, EventArgs e)
        {
            int itemEliminar = this.listaAlarma.SelectedIndex;
            day.RemoveAt(itemEliminar);
            listReminder.RemoveAt(itemEliminar);
            remainder.RemoveAt(itemEliminar);
            saveData();
            listaAlarma.DataSource = null;
            listaAlarma.Items.Clear();
            listaAlarma.DataSource = remainder;
        }

        private void listaAlarma_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int itemSelec = this.listaAlarma.SelectedIndex;
                String daysComp = day[itemSelec].ToString();
                if(!daysComp.Contains(";"))
                {
                    checkBoxFriday.Checked = false;
                    checkBoxMonday.Checked = false;
                    checkBoxTuesday.Checked = false;
                    checkBoxWednesday.Checked = false;
                    checkBoxThursday.Checked = false;
                    checkBoxSaturday.Checked = false;
                    checkBoxSunday.Checked = false;
                    labelRecodatorio.Text = daysComp;
                }
                else
                {
                    labelRecodatorio.Text = "";
                    checkBoxFriday.Checked = false;
                    checkBoxMonday.Checked = false;
                    checkBoxTuesday.Checked = false;
                    checkBoxWednesday.Checked = false;
                    checkBoxThursday.Checked = false;
                    checkBoxSaturday.Checked = false;
                    checkBoxSunday.Checked = false;

                    checkBoxFriday.Visible = true;
                    checkBoxMonday.Visible = true;
                    checkBoxTuesday.Visible = true;
                    checkBoxWednesday.Visible = true;
                    checkBoxThursday.Visible = true;
                    checkBoxSaturday.Visible = true;
                    checkBoxSunday.Visible = true;
                    checkBoxActivateAlarm.Checked = false;
                    if(daysComp.Contains("Friday"))
                    {
                        checkBoxFriday.Checked = true;
                    }
                    if (daysComp.Contains("Monday"))
                    {
                        checkBoxMonday.Checked = true;
                    }
                    if (daysComp.Contains("Tuesday"))
                    {
                        checkBoxTuesday.Checked = true;
                    }
                    if (daysComp.Contains("Wednesday"))
                    {
                        checkBoxWednesday.Checked = true;
                    }
                    if (daysComp.Contains("Thursday"))
                    {
                        checkBoxThursday.Checked = true;
                    }
                    if (daysComp.Contains("Saturday"))
                    {
                        checkBoxSaturday.Checked = true;
                    }
                    if (daysComp.Contains("Sunday"))
                    {
                        checkBoxSunday.Checked = true;
                    }
                }
                
                string[] hour = listReminder[itemSelec].ToString().Split(';');
                Console.WriteLine("Hora: " + hour[0]);
                Console.WriteLine("Min: " + hour[1]);
                Console.WriteLine("Sec: " + hour[2]);
                Console.WriteLine("Sec: " + hour[3]);
            }
            catch(Exception xe)
            {

            }

        }

        private void checkBoxActivateAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxActivateAlarm.Checked)
            {
                Calendario.Visible = true;
                checkBoxFriday.Visible = false;
                checkBoxMonday.Visible = false;
                checkBoxTuesday.Visible = false;
                checkBoxWednesday.Visible = false;
                checkBoxThursday.Visible = false;
                checkBoxSaturday.Visible = false;
                checkBoxSunday.Visible = false;
            }
            else
            {
                Calendario.Visible = false;
                checkBoxFriday.Visible = true;
                checkBoxMonday.Visible = true;
                checkBoxTuesday.Visible = true;
                checkBoxWednesday.Visible = true;
                checkBoxThursday.Visible = true;
                checkBoxSaturday.Visible = true;
                checkBoxSunday.Visible = true;
            }
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
