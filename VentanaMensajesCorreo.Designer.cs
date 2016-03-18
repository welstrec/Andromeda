namespace Andromeda
{
    partial class VentanaMensajesCorreo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaCorreo = new System.Windows.Forms.ListBox();
            this.msgViewer = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ListaCorreo
            // 
            this.ListaCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.ListaCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaCorreo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListaCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(185)))), ((int)(((byte)(253)))));
            this.ListaCorreo.FormattingEnabled = true;
            this.ListaCorreo.ItemHeight = 14;
            this.ListaCorreo.Location = new System.Drawing.Point(34, 56);
            this.ListaCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListaCorreo.Name = "ListaCorreo";
            this.ListaCorreo.Size = new System.Drawing.Size(322, 504);
            this.ListaCorreo.TabIndex = 0;
            this.ListaCorreo.DoubleClick += new System.EventHandler(this.ListaCorreo_DoubleClick);
            // 
            // msgViewer
            // 
            this.msgViewer.AllowWebBrowserDrop = false;
            this.msgViewer.IsWebBrowserContextMenuEnabled = false;
            this.msgViewer.Location = new System.Drawing.Point(398, 25);
            this.msgViewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.msgViewer.Name = "msgViewer";
            this.msgViewer.Size = new System.Drawing.Size(582, 524);
            this.msgViewer.TabIndex = 1;
            // 
            // VentanaMensajesCorreo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            
            this.ClientSize = new System.Drawing.Size(1009, 772);
            this.Controls.Add(this.msgViewer);
            this.Controls.Add(this.ListaCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentanaMensajesCorreo";
            this.Opacity = 0.8D;
            this.Text = "VentanaMensajesCorreo";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.VentanaMensajesCorreo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VentanaMensajesCorreo_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VentanaMensajesCorreo_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VentanaMensajesCorreo_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListaCorreo;
        private System.Windows.Forms.WebBrowser msgViewer;
    }
}