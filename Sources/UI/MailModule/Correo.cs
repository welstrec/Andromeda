using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Threading;
using System;
using S22.Imap;
using System.Net.Mail;
using System.Windows.Media;
using System.Windows.Threading;

namespace Andromeda
{
    public partial class Correo : Form
    {
        private string miCorreo = "";
        private string contra = "";
        private List<string> correo;
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        private int cantidad = 0;
        private List<string> listaRecividostemp = new List<string>();
        private List<string> mensajes = new List<string>();

        public Correo()
        {
            InitializeComponent();
            this.Visible = true;
            cargarMiUsuario();
            if(!(miCorreo.Equals("") && contra.Equals("")))
            {
                dispatcherTimer.Tick += new EventHandler(Tick);
                dispatcherTimer.Interval = TimeSpan.FromMilliseconds(15000);
                dispatcherTimer.Start();
            }
            ImagenCorreo.Width = 64;
            ImagenCorreo.Height = 64;
            this.Width = 64;
            this.Height = 64;
            this.BackColor = System.Drawing.Color.Olive;
            this.TransparencyKey = System.Drawing.Color.Olive;
        }
        private void Tick(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(actualizarMensajesSinLeer, 0);
        }
        public void cambiarImagen(int va)
        {
            if(va==0)
            {
                ImagenCorreo.Image = Properties.Resources._base;
            }
            if(va==1)
            {
                ImagenCorreo.Image = Properties.Resources.mail1x64;
            }
            if (va == 2)
            {
                ImagenCorreo.Image = Properties.Resources.mail2x64;
            }
            if (va == 3)
            {
                ImagenCorreo.Image = Properties.Resources.mail3x64;
            }
            if (va > 4 || va==4)
            {
                ImagenCorreo.Image = Properties.Resources.mail4x64;
            }

        }
        public void cargarMiUsuario()
        {
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    correo = (List<string>)bin.Deserialize(stream);
                    miCorreo = correo[0];
                    contra = correo[1];
                }
            }
            catch
            {
                correo = new List<string>();
            }
        }

        private void ImagenCorreo_Click(object sender, EventArgs e)
        {
            /*MediaPlayer reproductorSonido = new MediaPlayer();
            Uri URL = new Uri("Sonido/click.wav", UriKind.RelativeOrAbsolute);
            reproductorSonido.Open(URL);
            reproductorSonido.Play();
            if (!(miCorreo.Equals("") && contra.Equals("")))
            {
                cantidad = 0;
                ThreadPool.QueueUserWorkItem(actualizarMensajesSinLeer, 0);
                VentanaMensajesCorreo vmc = new VentanaMensajesCorreo();
               
                vmc.actualizar(listaRecividostemp,mensajes);
                vmc.Visible = true;
                this.Close();
            }
            else
            {
                VentanaLoginCorreo ttlc = new VentanaLoginCorreo();
                ttlc.Visible = true;
                this.Close();
            }*/
        }
        private void actualizarMensajesSinLeer(Object threadContext)
        {
            try
            {
                if (miCorreo.Contains("@gmail.com"))
                {
                    using (ImapClient Client = new ImapClient("imap.gmail.com", 993, miCorreo, contra, AuthMethod.Login, true))
                    {
                        
                        IEnumerable<uint> uids = Client.Search(SearchCondition.Unseen());
                        IEnumerable<MailMessage> mensajesx = Client.GetMessages(uids);
                        
                        foreach (MailMessage value in mensajesx)
                        {
                            listaRecividostemp.Add(value.Subject);
                            mensajes.Add(value.Body);
                            cantidad++;
                        }
                        Console.WriteLine("1CAN: "+ cantidad);
                        cambiarImagen(cantidad);
                        // cargarDatos(listaRecividostemp, mensajes);
                    }
                }
                else if (miCorreo.Contains("@hotmail.com"))
                {
                    using (ImapClient Client = new ImapClient("imap-mail.outlook.com", 993, miCorreo, contra, AuthMethod.Login, true))
                    {

                        IEnumerable<uint> uids = Client.Search(SearchCondition.Unseen());
                        IEnumerable<MailMessage> mensajesx = Client.GetMessages(uids);
                        foreach (MailMessage value in mensajesx)
                        {
                            listaRecividostemp.Add(value.Subject);
                            mensajes.Add(value.Body);
                            cantidad++;
                        }
                        Console.WriteLine("2CAN: " + cantidad);
                        cambiarImagen(cantidad);
                        //cargarDatos(listaRecividostemp, mensajes);
                    }
                }
                else if (miCorreo.Contains("@yahoo.com"))
                {
                    using (ImapClient Client = new ImapClient("imap.mail.yahoo.com", 993, miCorreo, contra, AuthMethod.Login, true))
                    {

                        IEnumerable<uint> uids = Client.Search(SearchCondition.Unseen());
                        IEnumerable<MailMessage> mensajesx = Client.GetMessages(uids);                        
                        foreach (MailMessage value in mensajesx)
                        {
                            listaRecividostemp.Add(value.Subject);
                            mensajes.Add(value.Body);
                            cantidad++;
                        }
                        Console.WriteLine("3CAN: " + cantidad);
                        cambiarImagen(cantidad);
                        // cargarDatos(listaRecividostemp, mensajes);
                    }
                }
            }
            catch
            {
                File.Delete("data.bin");
                MessageBox.Show("Contraseña o Email incorrecto.");
            }
        }
    }
}
