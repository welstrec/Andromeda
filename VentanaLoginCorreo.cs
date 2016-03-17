using MikuDash;
using System;
using System.Windows.Forms;

namespace Andromeda
{
    public partial class VentanaLoginCorreo : Form
    {

        public MikuDashMain main;
        private int offsetx;
        private int offsety;
        private Boolean flag;
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

        private void button2_Click(object sender, EventArgs e)
        {
            main.showApps();
            Dispose();
        }

        private void mikuBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                this.Left = Cursor.Position.X - offsetx;
                this.Top = Cursor.Position.Y - offsety;
            }
        }

        private void mikuBox_MouseUp(object sender, MouseEventArgs e)
        {

            flag = false;
        }

        private void mikuBox_MouseDown(object sender, MouseEventArgs e)
        {

            offsetx = Cursor.Position.X - this.Location.X;
            offsety = Cursor.Position.Y - this.Location.Y;
            flag = true;

        }

    }
}
