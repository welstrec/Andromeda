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
            this.textoMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListaCorreo
            // 
            this.ListaCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.ListaCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaCorreo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(185)))), ((int)(((byte)(253)))));
            this.ListaCorreo.FormattingEnabled = true;
            this.ListaCorreo.ItemHeight = 18;
            this.ListaCorreo.Location = new System.Drawing.Point(32, 46);
            this.ListaCorreo.Name = "ListaCorreo";
            this.ListaCorreo.Size = new System.Drawing.Size(327, 504);
            this.ListaCorreo.TabIndex = 0;
            // 
            // textoMensaje
            // 
            this.textoMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.textoMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(185)))), ((int)(((byte)(253)))));
            this.textoMensaje.Location = new System.Drawing.Point(390, 19);
            this.textoMensaje.Multiline = true;
            this.textoMensaje.Name = "textoMensaje";
            this.textoMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textoMensaje.Size = new System.Drawing.Size(595, 539);
            this.textoMensaje.TabIndex = 2;
            // 
            // VentanaMensajesCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Andromeda.Properties.Resources.Email;
            this.ClientSize = new System.Drawing.Size(1017, 770);
            this.Controls.Add(this.textoMensaje);
            this.Controls.Add(this.ListaCorreo);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaMensajesCorreo";
            this.Opacity = 0.8D;
            this.Text = "VentanaMensajesCorreo";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaCorreo;
        private System.Windows.Forms.TextBox textoMensaje;
    }
}