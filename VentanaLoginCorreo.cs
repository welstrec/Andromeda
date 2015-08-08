using MikuDash;
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

        public MikuDashMain main;
        public VentanaLoginCorreo(MikuDashMain md)
        {
            main = md;
            InitializeComponent();
            main.loadMailSettings(mailLists, null, null, null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void textoEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BotonGmail_Click(object sender, EventArgs e)
        {
            textoEmail.Text = "@gmail.com";
            textHost.Text = "imap.gmail.com";
            textPort.Text = "993";
        }

        private void BotonHotmail_Click(object sender, EventArgs e)
        {
            textoEmail.Text = "@hotmail.com";
            textHost.Text = "imap-mail.outlook.com";
            textPort.Text = "993";
        }

        private void BotonYahoo_Click(object sender, EventArgs e)
        {
            textoEmail.Text = "@yahoo.com";
            textHost.Text = "imap.mail.yahoo.com";
            textPort.Text = "993";
        }

        private void VentanaLoginCorreo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mailLists.Items.Add(textHost.Text+";"+textPort.Text+";"+textoEmail.Text+";"+textKey.Text);
            main.saveMailSettings(mailLists);
        }

        private void mailLists_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mailLists.Items.RemoveAt(mailLists.SelectedIndex);
            main.saveMailSettings(mailLists);
        }



    }
}
