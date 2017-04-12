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
            this.textHost = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mailLists = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textKey = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BotonGmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHotmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonYahoo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoEmail
            // 
            this.textoEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textoEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoEmail.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textoEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textoEmail.Location = new System.Drawing.Point(99, 23);
            this.textoEmail.Name = "textoEmail";
            this.textoEmail.Size = new System.Drawing.Size(306, 19);
            this.textoEmail.TabIndex = 2;
            this.textoEmail.Text = "[Click side icon to complete]";
            this.textoEmail.TextChanged += new System.EventHandler(this.textoEmail_TextChanged);
            // 
            // BotonGmail
            // 
            this.BotonGmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BotonGmail.BackgroundImage = global::Andromeda.Properties.Resources.GMAILICON64;
            this.BotonGmail.Location = new System.Drawing.Point(411, 214);
            this.BotonGmail.Name = "BotonGmail";
            this.BotonGmail.Size = new System.Drawing.Size(64, 64);
            this.BotonGmail.TabIndex = 3;
            this.BotonGmail.TabStop = false;
            this.BotonGmail.Click += new System.EventHandler(this.BotonGmail_Click);
            // 
            // BotonHotmail
            // 
            this.BotonHotmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.BotonHotmail.BackgroundImage = global::Andromeda.Properties.Resources.outlookIcon64;
            this.BotonHotmail.Location = new System.Drawing.Point(411, 138);
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
            this.BotonYahoo.Location = new System.Drawing.Point(412, 59);
            this.BotonYahoo.Name = "BotonYahoo";
            this.BotonYahoo.Size = new System.Drawing.Size(64, 64);
            this.BotonYahoo.TabIndex = 5;
            this.BotonYahoo.TabStop = false;
            this.BotonYahoo.Click += new System.EventHandler(this.BotonYahoo_Click);
            // 
            // textHost
            // 
            this.textHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHost.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textHost.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textHost.Location = new System.Drawing.Point(99, 76);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(306, 19);
            this.textHost.TabIndex = 10;
            this.textHost.Text = "[Click side icon to complete]";
            // 
            // textPort
            // 
            this.textPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPort.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textPort.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textPort.Location = new System.Drawing.Point(99, 102);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(306, 19);
            this.textPort.TabIndex = 11;
            this.textPort.Text = "[Click side icon to complete]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.label3.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Key:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.label4.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(15, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Host:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(25)))), ((int)(((byte)(41)))));
            this.label5.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Port:";
            // 
            // mailLists
            // 
            this.mailLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.mailLists.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mailLists.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(173)))));
            this.mailLists.FormattingEnabled = true;
            this.mailLists.HorizontalScrollbar = true;
            this.mailLists.ItemHeight = 20;
            this.mailLists.Location = new System.Drawing.Point(19, 178);
            this.mailLists.Name = "mailLists";
            this.mailLists.Size = new System.Drawing.Size(386, 100);
            this.mailLists.TabIndex = 15;
            this.mailLists.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mailLists_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(173)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(94)))), ((int)(((byte)(173)))));
            this.button1.Location = new System.Drawing.Point(136, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // textKey
            // 
            this.textKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textKey.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textKey.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textKey.Location = new System.Drawing.Point(100, 49);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(306, 19);
            this.textKey.TabIndex = 17;
            this.textKey.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(413, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // VentanaLoginCorreo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Andromeda.Properties.Resources.fondoEmail;
            this.ClientSize = new System.Drawing.Size(498, 299);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mailLists);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHost);
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
            this.Load += new System.EventHandler(this.VentanaLoginCorreo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.BotonGmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonHotmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonYahoo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoEmail;
        private System.Windows.Forms.PictureBox BotonGmail;
        private System.Windows.Forms.PictureBox BotonHotmail;
        private System.Windows.Forms.PictureBox BotonYahoo;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox mailLists;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox textKey;
        private System.Windows.Forms.Button button2;
    }
}