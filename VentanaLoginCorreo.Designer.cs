namespace Andromeda
{
    partial class VentanaLoginCorreo
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
            this.label1 = new System.Windows.Forms.Label();
            this.textoEmail = new System.Windows.Forms.TextBox();
            this.BotonGmail = new System.Windows.Forms.PictureBox();
            this.BotonHotmail = new System.Windows.Forms.PictureBox();
            this.BotonYahoo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContraseniaTexto = new System.Windows.Forms.TextBox();
            this.BotonAgregar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BotonGmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHotmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonYahoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(57, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoEmail
            // 
            this.textoEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoEmail.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textoEmail.Location = new System.Drawing.Point(123, 111);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(335, 13);
            this.textoEmail.TabIndex = 2;
            this.textoEmail.Text = "[Clic en el icono para auto rellenar]";
            this.textoEmail.TextChanged += new System.EventHandler(this.textoEmail_TextChanged);
            // 
            // BotonGmail
            // 
            this.BotonGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BotonGmail.BackgroundImage = global::Andromeda.Properties.Resources.GMAIL_ICON64;
            this.BotonGmail.Location = new System.Drawing.Point(73, 26);
            this.BotonGmail.Name = "BotonGmail";
            this.BotonGmail.Size = new System.Drawing.Size(64, 64);
            this.BotonGmail.TabIndex = 3;
            this.BotonGmail.TabStop = false;
            this.BotonGmail.Click += new System.EventHandler(this.BotonGmail_Click);
            // 
            // BotonHotmail
            // 
            this.BotonHotmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BotonHotmail.BackgroundImage = global::Andromeda.Properties.Resources.outlook_icon64;
            this.BotonHotmail.Location = new System.Drawing.Point(230, 26);
            this.BotonHotmail.Name = "BotonHotmail";
            this.BotonHotmail.Size = new System.Drawing.Size(64, 64);
            this.BotonHotmail.TabIndex = 4;
            this.BotonHotmail.TabStop = false;
            this.BotonHotmail.Click += new System.EventHandler(this.BotonHotmail_Click);
            // 
            // BotonYahoo
            // 
            this.BotonYahoo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BotonYahoo.BackgroundImage = global::Andromeda.Properties.Resources.yahoo64;
            this.BotonYahoo.Location = new System.Drawing.Point(385, 26);
            this.BotonYahoo.Name = "BotonYahoo";
            this.BotonYahoo.Size = new System.Drawing.Size(64, 64);
            this.BotonYahoo.TabIndex = 5;
            this.BotonYahoo.TabStop = false;
            this.BotonYahoo.Click += new System.EventHandler(this.BotonYahoo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(43, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            // 
            // ContraseniaTexto
            // 
            this.ContraseniaTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ContraseniaTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContraseniaTexto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ContraseniaTexto.Location = new System.Drawing.Point(123, 162);
            this.ContraseniaTexto.Name = "ContraseniaTexto";
            this.ContraseniaTexto.PasswordChar = '*';
            this.ContraseniaTexto.Size = new System.Drawing.Size(335, 13);
            this.ContraseniaTexto.TabIndex = 7;
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BotonAgregar.BackgroundImage = global::Andromeda.Properties.Resources.botonAgregar;
            this.BotonAgregar.Location = new System.Drawing.Point(187, 224);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(122, 36);
            this.BotonAgregar.TabIndex = 8;
            this.BotonAgregar.TabStop = false;
            this.BotonAgregar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // VentanaLoginCorreo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Andromeda.Properties.Resources.fondoEmail;
            this.ClientSize = new System.Drawing.Size(498, 298);
            this.ControlBox = false;
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.ContraseniaTexto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BotonYahoo);
            this.Controls.Add(this.BotonHotmail);
            this.Controls.Add(this.BotonGmail);
            this.Controls.Add(this.textoEmail);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaLoginCorreo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaLoginCorreo";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            ((System.ComponentModel.ISupportInitialize)(this.BotonGmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHotmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonYahoo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoEmail;
        private System.Windows.Forms.PictureBox BotonGmail;
        private System.Windows.Forms.PictureBox BotonHotmail;
        private System.Windows.Forms.PictureBox BotonYahoo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContraseniaTexto;
        private System.Windows.Forms.PictureBox BotonAgregar;
    }
}