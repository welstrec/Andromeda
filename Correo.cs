using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Threading;
using System;

namespace Andromeda
{
    public partial class Correo : Form
    {
        private string miCorreo = "editorabeta@yahoo.com";
        private string contra = "secreto.DIOS1.";
        private List<string> correo;
        public Correo()
        {
            InitializeComponent();
            this.Visible = true;
            cargarMiUsuario();
            ImagenCorreo.Width = 64;
            ImagenCorreo.Height = 64;
            this.Width = 64;
            this.Height = 64;
            this.BackColor = Color.Olive;
            this.TransparencyKey = Color.Olive;
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

        private void ImagenCorreo_Click(object sender, System.EventArgs e)
        {
            if (!(miCorreo.Equals("") && contra.Equals("")))
            {
                ThreadPool.QueueUserWorkItem(logearse, 0);
            }
            else
            {

            }
        }
        private void logearse(Object threadContext)
        {
        }
    }
}
