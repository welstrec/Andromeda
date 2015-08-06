using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Andromeda
{
    public partial class VentanaLoginCorreo : Form
    {
        public VentanaLoginCorreo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string correo = textoEmail.Text;
            string contra = ContraseniaTexto.Text;
            if(!(correo.Contains("@gmail.com") || correo.Contains("@hotmail.com") || correo.Contains("@yahoo.com")))
            {
                textoEmail.Text = "";
                ContraseniaTexto.Text = "";
                MessageBox.Show("El email parece ser no correcto.");
            }
            else
            {
                List<string> listaCorreo = new List<string>();

                listaCorreo.Add(correo);
                listaCorreo.Add(contra);
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, listaCorreo);
                }
                Correo c = new Correo();
                c.Visible = true;
                this.Close();
            }

        }

        private void textoEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BotonGmail_Click(object sender, EventArgs e)
        {
            textoEmail.Text = "@gmail.com";
        }

        private void BotonHotmail_Click(object sender, EventArgs e)
        {
            textoEmail.Text = "@hotmail.com";
        }

        private void BotonYahoo_Click(object sender, EventArgs e)
        {
            textoEmail.Text = "@yahoo.com";
        }
    }
}
