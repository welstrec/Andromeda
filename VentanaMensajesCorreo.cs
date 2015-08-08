using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Andromeda
{
    public partial class VentanaMensajesCorreo : Form
    {
        private int offsetx;
        private int offsety;
        private Boolean flag;
        private MailModule mm;
        private Thread mailThr;
        public VentanaMensajesCorreo(String imapHost, int imapPort, String correo, String pwd)
        {
            //this.mm = new MailModule(null, imapHost, imapPort, correo, pwd);
            //mm.vmc = this;
            InitializeComponent();
            
            actualizar();
        }

        private void actualizar()
        {
            
            mailThr = new Thread(new ThreadStart(mm.getMessages));
            mailThr.Start();
                        
            
            
        }

        public event EventHandler LoadedMessages;

        public void OnLoadedMessages()
        {
            ListaCorreo.DataSource = mm.listaRecividostemp;
        }
        private void VentanaMensajesCorreo_Load(object sender, EventArgs e)
        {

        }

        private void VentanaMensajesCorreo_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.Left = Cursor.Position.X - offsetx;
                this.Top = Cursor.Position.Y - offsety;
            }
        }

        private void VentanaMensajesCorreo_MouseDown(object sender, MouseEventArgs e)
        {
            offsetx = Cursor.Position.X - this.Location.X;
            offsety = Cursor.Position.Y - this.Location.Y;
            flag = true;
        }

        private void VentanaMensajesCorreo_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void ListaCorreo_DoubleClick(object sender, EventArgs e)
        {
            //Console.WriteLine(" - " + mm.mensajes[ListaCorreo.SelectedIndex] + " - " + ListaCorreo.SelectedIndex);
            msgViewer.DocumentText = mm.getMessageBody(mm.mensajes[ListaCorreo.SelectedIndex]);
        }
    }
}
