namespace MikuDash
{
    partial class DateSound
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateSound));
            this.Year = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.daysP = new System.Windows.Forms.PictureBox();
            this.lfeLbl = new System.Windows.Forms.Label();
            this.chLbl = new System.Windows.Forms.Label();
            this.sprLedImg = new System.Windows.Forms.PictureBox();
            this.listenLedImg = new System.Windows.Forms.PictureBox();
            this.listenerBlinker = new System.Windows.Forms.Timer(this.components);
            this.mailLbl = new System.Windows.Forms.Label();
            this.schLbl = new System.Windows.Forms.Label();
            this.ci = new System.Windows.Forms.PictureBox();
            this.ri = new System.Windows.Forms.PictureBox();
            this.li = new System.Windows.Forms.PictureBox();
            this.sli = new System.Windows.Forms.PictureBox();
            this.sri = new System.Windows.Forms.PictureBox();
            this.rli = new System.Windows.Forms.PictureBox();
            this.rri = new System.Windows.Forms.PictureBox();
            this.swi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.daysP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprLedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listenLedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.li)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swi)).BeginInit();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.Transparent;
            this.Year.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Year.ForeColor = System.Drawing.Color.Lime;
            this.Year.Location = new System.Drawing.Point(47, 216);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(94, 35);
            this.Year.TabIndex = 30;
            this.Year.Text = "----";
            this.Year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Month
            // 
            this.Month.BackColor = System.Drawing.Color.Transparent;
            this.Month.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Month.ForeColor = System.Drawing.Color.Lime;
            this.Month.Location = new System.Drawing.Point(31, 13);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(131, 24);
            this.Month.TabIndex = 29;
            this.Month.Text = "----";
            this.Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysP
            // 
            this.daysP.BackColor = System.Drawing.Color.Transparent;
            this.daysP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.daysP.Image = ((System.Drawing.Image)(resources.GetObject("daysP.Image")));
            this.daysP.Location = new System.Drawing.Point(21, 57);
            this.daysP.Name = "daysP";
            this.daysP.Size = new System.Drawing.Size(148, 145);
            this.daysP.TabIndex = 28;
            this.daysP.TabStop = false;
            this.daysP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.daysP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.daysP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // lfeLbl
            // 
            this.lfeLbl.BackColor = System.Drawing.Color.Transparent;
            this.lfeLbl.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lfeLbl.ForeColor = System.Drawing.Color.Lime;
            this.lfeLbl.Location = new System.Drawing.Point(161, 288);
            this.lfeLbl.Name = "lfeLbl";
            this.lfeLbl.Size = new System.Drawing.Size(10, 26);
            this.lfeLbl.TabIndex = 32;
            this.lfeLbl.Text = "-";
            this.lfeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lfeLbl.Click += new System.EventHandler(this.lfeLbl_Click);
            // 
            // chLbl
            // 
            this.chLbl.BackColor = System.Drawing.Color.Transparent;
            this.chLbl.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chLbl.ForeColor = System.Drawing.Color.Lime;
            this.chLbl.Location = new System.Drawing.Point(162, 254);
            this.chLbl.Name = "chLbl";
            this.chLbl.Size = new System.Drawing.Size(10, 26);
            this.chLbl.TabIndex = 33;
            this.chLbl.Text = "-";
            this.chLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sprLedImg
            // 
            this.sprLedImg.Image = ((System.Drawing.Image)(resources.GetObject("sprLedImg.Image")));
            this.sprLedImg.Location = new System.Drawing.Point(38, 404);
            this.sprLedImg.Name = "sprLedImg";
            this.sprLedImg.Size = new System.Drawing.Size(13, 13);
            this.sprLedImg.TabIndex = 34;
            this.sprLedImg.TabStop = false;
            this.sprLedImg.Visible = false;
            // 
            // listenLedImg
            // 
            this.listenLedImg.Image = ((System.Drawing.Image)(resources.GetObject("listenLedImg.Image")));
            this.listenLedImg.Location = new System.Drawing.Point(69, 404);
            this.listenLedImg.Name = "listenLedImg";
            this.listenLedImg.Size = new System.Drawing.Size(13, 13);
            this.listenLedImg.TabIndex = 35;
            this.listenLedImg.TabStop = false;
            this.listenLedImg.Visible = false;
            // 
            // listenerBlinker
            // 
            this.listenerBlinker.Interval = 500;
            this.listenerBlinker.Tick += new System.EventHandler(this.listenerBlinker_Tick);
            // 
            // mailLbl
            // 
            this.mailLbl.BackColor = System.Drawing.Color.Transparent;
            this.mailLbl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mailLbl.ForeColor = System.Drawing.Color.Lime;
            this.mailLbl.Location = new System.Drawing.Point(16, 339);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(47, 22);
            this.mailLbl.TabIndex = 36;
            this.mailLbl.Text = "---";
            this.mailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schLbl
            // 
            this.schLbl.BackColor = System.Drawing.Color.Transparent;
            this.schLbl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.schLbl.ForeColor = System.Drawing.Color.Lime;
            this.schLbl.Location = new System.Drawing.Point(48, 339);
            this.schLbl.Name = "schLbl";
            this.schLbl.Size = new System.Drawing.Size(47, 22);
            this.schLbl.TabIndex = 37;
            this.schLbl.Text = "---";
            this.schLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ci
            // 
            this.ci.BackColor = System.Drawing.Color.Transparent;
            this.ci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ci.Image = ((System.Drawing.Image)(resources.GetObject("ci.Image")));
            this.ci.Location = new System.Drawing.Point(66, 263);
            this.ci.Name = "ci";
            this.ci.Size = new System.Drawing.Size(28, 15);
            this.ci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ci.TabIndex = 38;
            this.ci.TabStop = false;
            // 
            // ri
            // 
            this.ri.BackColor = System.Drawing.Color.Transparent;
            this.ri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ri.Image = ((System.Drawing.Image)(resources.GetObject("ri.Image")));
            this.ri.Location = new System.Drawing.Point(103, 263);
            this.ri.Name = "ri";
            this.ri.Size = new System.Drawing.Size(28, 15);
            this.ri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ri.TabIndex = 39;
            this.ri.TabStop = false;
            // 
            // li
            // 
            this.li.BackColor = System.Drawing.Color.Transparent;
            this.li.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.li.Image = ((System.Drawing.Image)(resources.GetObject("li.Image")));
            this.li.Location = new System.Drawing.Point(28, 263);
            this.li.Name = "li";
            this.li.Size = new System.Drawing.Size(28, 15);
            this.li.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.li.TabIndex = 40;
            this.li.TabStop = false;
            // 
            // sli
            // 
            this.sli.BackColor = System.Drawing.Color.Transparent;
            this.sli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sli.Image = ((System.Drawing.Image)(resources.GetObject("sli.Image")));
            this.sli.Location = new System.Drawing.Point(20, 284);
            this.sli.Name = "sli";
            this.sli.Size = new System.Drawing.Size(34, 16);
            this.sli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sli.TabIndex = 41;
            this.sli.TabStop = false;
            // 
            // sri
            // 
            this.sri.BackColor = System.Drawing.Color.Transparent;
            this.sri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sri.Image = ((System.Drawing.Image)(resources.GetObject("sri.Image")));
            this.sri.Location = new System.Drawing.Point(106, 284);
            this.sri.Name = "sri";
            this.sri.Size = new System.Drawing.Size(34, 16);
            this.sri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sri.TabIndex = 42;
            this.sri.TabStop = false;
            // 
            // rli
            // 
            this.rli.BackColor = System.Drawing.Color.Transparent;
            this.rli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rli.Image = ((System.Drawing.Image)(resources.GetObject("rli.Image")));
            this.rli.Location = new System.Drawing.Point(35, 304);
            this.rli.Name = "rli";
            this.rli.Size = new System.Drawing.Size(34, 17);
            this.rli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rli.TabIndex = 43;
            this.rli.TabStop = false;
            // 
            // rri
            // 
            this.rri.BackColor = System.Drawing.Color.Transparent;
            this.rri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rri.Image = ((System.Drawing.Image)(resources.GetObject("rri.Image")));
            this.rri.Location = new System.Drawing.Point(90, 304);
            this.rri.Name = "rri";
            this.rri.Size = new System.Drawing.Size(34, 17);
            this.rri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rri.TabIndex = 44;
            this.rri.TabStop = false;
            // 
            // swi
            // 
            this.swi.BackColor = System.Drawing.Color.Transparent;
            this.swi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.swi.Image = ((System.Drawing.Image)(resources.GetObject("swi.Image")));
            this.swi.Location = new System.Drawing.Point(62, 284);
            this.swi.Name = "swi";
            this.swi.Size = new System.Drawing.Size(36, 16);
            this.swi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swi.TabIndex = 45;
            this.swi.TabStop = false;
            // 
            // DateSound
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(205, 465);
            this.Controls.Add(this.swi);
            this.Controls.Add(this.rri);
            this.Controls.Add(this.rli);
            this.Controls.Add(this.sri);
            this.Controls.Add(this.sli);
            this.Controls.Add(this.li);
            this.Controls.Add(this.ri);
            this.Controls.Add(this.ci);
            this.Controls.Add(this.schLbl);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.listenLedImg);
            this.Controls.Add(this.sprLedImg);
            this.Controls.Add(this.chLbl);
            this.Controls.Add(this.lfeLbl);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.daysP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateSound";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "DateAudioDash";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.DateSound_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.daysP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprLedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listenLedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.li)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Year;
        public System.Windows.Forms.Label Month;
        public System.Windows.Forms.PictureBox daysP;
        public System.Windows.Forms.Label lfeLbl;
        public System.Windows.Forms.Label chLbl;
        public System.Windows.Forms.PictureBox sprLedImg;
        public System.Windows.Forms.PictureBox listenLedImg;
        public System.Windows.Forms.Timer listenerBlinker;
        public System.Windows.Forms.Label mailLbl;
        public System.Windows.Forms.Label schLbl;
        public System.Windows.Forms.PictureBox ci;
        public System.Windows.Forms.PictureBox ri;
        public System.Windows.Forms.PictureBox li;
        public System.Windows.Forms.PictureBox sli;
        public System.Windows.Forms.PictureBox sri;
        public System.Windows.Forms.PictureBox rli;
        public System.Windows.Forms.PictureBox rri;
        public System.Windows.Forms.PictureBox swi;
    }
}