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
            this.vuL = new AGaugeApp.AGauge();
            ((System.ComponentModel.ISupportInitialize)(this.daysP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprLedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listenLedImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.Black;
            this.Year.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Year.ForeColor = System.Drawing.Color.Red;
            this.Year.Location = new System.Drawing.Point(125, 74);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(42, 12);
            this.Year.TabIndex = 30;
            this.Year.Text = "----";
            this.Year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Month
            // 
            this.Month.BackColor = System.Drawing.Color.Black;
            this.Month.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Month.ForeColor = System.Drawing.Color.Red;
            this.Month.Location = new System.Drawing.Point(125, 46);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(42, 12);
            this.Month.TabIndex = 29;
            this.Month.Text = "----";
            this.Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daysP
            // 
            this.daysP.BackColor = System.Drawing.Color.Transparent;
            this.daysP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.daysP.Image = ((System.Drawing.Image)(resources.GetObject("daysP.Image")));
            this.daysP.Location = new System.Drawing.Point(24, 24);
            this.daysP.Name = "daysP";
            this.daysP.Size = new System.Drawing.Size(72, 79);
            this.daysP.TabIndex = 28;
            this.daysP.TabStop = false;
            this.daysP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.daysP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.daysP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // lfeLbl
            // 
            this.lfeLbl.BackColor = System.Drawing.Color.Transparent;
            this.lfeLbl.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lfeLbl.ForeColor = System.Drawing.Color.Red;
            this.lfeLbl.Location = new System.Drawing.Point(87, 149);
            this.lfeLbl.Name = "lfeLbl";
            this.lfeLbl.Size = new System.Drawing.Size(18, 12);
            this.lfeLbl.TabIndex = 32;
            this.lfeLbl.Text = "-";
            this.lfeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lfeLbl.Click += new System.EventHandler(this.lfeLbl_Click);
            // 
            // chLbl
            // 
            this.chLbl.BackColor = System.Drawing.Color.Transparent;
            this.chLbl.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chLbl.ForeColor = System.Drawing.Color.Red;
            this.chLbl.Location = new System.Drawing.Point(87, 126);
            this.chLbl.Name = "chLbl";
            this.chLbl.Size = new System.Drawing.Size(18, 12);
            this.chLbl.TabIndex = 33;
            this.chLbl.Text = "-";
            this.chLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sprLedImg
            // 
            this.sprLedImg.Image = ((System.Drawing.Image)(resources.GetObject("sprLedImg.Image")));
            this.sprLedImg.Location = new System.Drawing.Point(45, 178);
            this.sprLedImg.Name = "sprLedImg";
            this.sprLedImg.Size = new System.Drawing.Size(13, 13);
            this.sprLedImg.TabIndex = 34;
            this.sprLedImg.TabStop = false;
            this.sprLedImg.Visible = false;
            // 
            // listenLedImg
            // 
            this.listenLedImg.Image = ((System.Drawing.Image)(resources.GetObject("listenLedImg.Image")));
            this.listenLedImg.Location = new System.Drawing.Point(76, 178);
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
            this.mailLbl.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mailLbl.ForeColor = System.Drawing.Color.Red;
            this.mailLbl.Location = new System.Drawing.Point(121, 110);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(26, 12);
            this.mailLbl.TabIndex = 36;
            this.mailLbl.Text = "---";
            this.mailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schLbl
            // 
            this.schLbl.BackColor = System.Drawing.Color.Transparent;
            this.schLbl.Font = new System.Drawing.Font("Consolas", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.schLbl.ForeColor = System.Drawing.Color.Red;
            this.schLbl.Location = new System.Drawing.Point(145, 110);
            this.schLbl.Name = "schLbl";
            this.schLbl.Size = new System.Drawing.Size(26, 12);
            this.schLbl.TabIndex = 37;
            this.schLbl.Text = "---";
            this.schLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vuL
            // 
            this.vuL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuL.BackgroundImage")));
            this.vuL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuL.BaseArcColor = System.Drawing.Color.Gray;
            this.vuL.BaseArcRadius = 0;
            this.vuL.BaseArcStart = 220;
            this.vuL.BaseArcSweep = 100;
            this.vuL.BaseArcWidth = 1;
            this.vuL.Cap_Idx = ((byte)(1));
            this.vuL.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuL.CapPosition = new System.Drawing.Point(10, 10);
            this.vuL.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuL.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuL.CapText = "";
            this.vuL.Center = new System.Drawing.Point(28, 43);
            this.vuL.Location = new System.Drawing.Point(21, 111);
            this.vuL.MaxValue = 100F;
            this.vuL.MinValue = 0F;
            this.vuL.Name = "vuL";
            this.vuL.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.vuL.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuL.NeedleRadius = 27;
            this.vuL.NeedleType = 1;
            this.vuL.NeedleWidth = 1;
            this.vuL.Range_Idx = ((byte)(0));
            this.vuL.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vuL.RangeEnabled = false;
            this.vuL.RangeEndValue = 100F;
            this.vuL.RangeInnerRadius = 29;
            this.vuL.RangeOuterRadius = 200;
            this.vuL.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuL.RangesEnabled = new bool[] {
        false,
        true,
        false,
        false,
        false};
            this.vuL.RangesEndValue = new float[] {
        100F,
        400F,
        0F,
        0F,
        0F};
            this.vuL.RangesInnerRadius = new int[] {
        29,
        70,
        70,
        70,
        70};
            this.vuL.RangesOuterRadius = new int[] {
        200,
        80,
        80,
        80,
        80};
            this.vuL.RangesStartValue = new float[] {
        0F,
        300F,
        0F,
        0F,
        0F};
            this.vuL.RangeStartValue = 0F;
            this.vuL.ScaleLinesInterColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vuL.ScaleLinesInterInnerRadius = 0;
            this.vuL.ScaleLinesInterOuterRadius = 0;
            this.vuL.ScaleLinesInterWidth = 1;
            this.vuL.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuL.ScaleLinesMajorInnerRadius = 0;
            this.vuL.ScaleLinesMajorOuterRadius = 0;
            this.vuL.ScaleLinesMajorStepValue = 50F;
            this.vuL.ScaleLinesMajorWidth = 2;
            this.vuL.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuL.ScaleLinesMinorInnerRadius = 0;
            this.vuL.ScaleLinesMinorNumOf = 9;
            this.vuL.ScaleLinesMinorOuterRadius = 0;
            this.vuL.ScaleLinesMinorWidth = 1;
            this.vuL.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuL.ScaleNumbersFormat = null;
            this.vuL.ScaleNumbersRadius = 200;
            this.vuL.ScaleNumbersRotation = 0;
            this.vuL.ScaleNumbersStartScaleLine = 0;
            this.vuL.ScaleNumbersStepScaleLines = 1;
            this.vuL.Size = new System.Drawing.Size(57, 57);
            this.vuL.TabIndex = 15;
            this.vuL.Text = "0";
            this.vuL.Value = 0F;
            this.vuL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // DateSound
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(245, 238);
            this.Controls.Add(this.schLbl);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.listenLedImg);
            this.Controls.Add(this.sprLedImg);
            this.Controls.Add(this.chLbl);
            this.Controls.Add(this.lfeLbl);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.daysP);
            this.Controls.Add(this.vuL);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateSound";
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            this.Text = "DateAudioDash";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.DateSound_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.daysP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprLedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listenLedImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AGaugeApp.AGauge vuL;
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
    }
}