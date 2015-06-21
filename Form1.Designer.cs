namespace MikuDash
{
    partial class MikuDashMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MikuDashMain));
            this.cpuTempLbl = new System.Windows.Forms.Label();
            this.cpuLbl = new System.Windows.Forms.Label();
            this.vramLbl = new System.Windows.Forms.Label();
            this.gpuLbl = new System.Windows.Forms.Label();
            this.ramLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpuTempLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ampmLbl = new System.Windows.Forms.Label();
            this.clockLbl = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolInvalid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolClose = new System.Windows.Forms.ToolStripSeparator();
            this.toolPos = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.falloutStat = new System.Windows.Forms.PictureBox();
            this.cpuCLK = new System.Windows.Forms.Label();
            this.gpuCLK = new System.Windows.Forms.Label();
            this.fadeInAnim = new System.Windows.Forms.Timer(this.components);
            this.vuVRam = new AGaugeApp.AGauge();
            this.vuGPU = new AGaugeApp.AGauge();
            this.vuCPU = new AGaugeApp.AGauge();
            this.vuRam = new AGaugeApp.AGauge();
            this.vuGPUF = new AGaugeApp.AGauge();
            this.vuCPUF = new AGaugeApp.AGauge();
            this.vuCPUT = new AGaugeApp.AGauge();
            this.vuGPUT = new AGaugeApp.AGauge();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.falloutStat)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuTempLbl
            // 
            this.cpuTempLbl.BackColor = System.Drawing.Color.Black;
            this.cpuTempLbl.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cpuTempLbl.ForeColor = System.Drawing.Color.Red;
            this.cpuTempLbl.Location = new System.Drawing.Point(182, 47);
            this.cpuTempLbl.Name = "cpuTempLbl";
            this.cpuTempLbl.Size = new System.Drawing.Size(25, 12);
            this.cpuTempLbl.TabIndex = 8;
            this.cpuTempLbl.Text = "---";
            this.cpuTempLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuLbl
            // 
            this.cpuLbl.BackColor = System.Drawing.Color.Black;
            this.cpuLbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cpuLbl.ForeColor = System.Drawing.Color.Green;
            this.cpuLbl.Location = new System.Drawing.Point(279, 30);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(22, 12);
            this.cpuLbl.TabIndex = 9;
            this.cpuLbl.Text = "---";
            this.cpuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vramLbl
            // 
            this.vramLbl.BackColor = System.Drawing.Color.Black;
            this.vramLbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.vramLbl.ForeColor = System.Drawing.Color.Green;
            this.vramLbl.Location = new System.Drawing.Point(553, 30);
            this.vramLbl.Name = "vramLbl";
            this.vramLbl.Size = new System.Drawing.Size(22, 12);
            this.vramLbl.TabIndex = 11;
            this.vramLbl.Text = "---";
            this.vramLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuLbl
            // 
            this.gpuLbl.BackColor = System.Drawing.Color.Black;
            this.gpuLbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gpuLbl.ForeColor = System.Drawing.Color.Green;
            this.gpuLbl.Location = new System.Drawing.Point(496, 30);
            this.gpuLbl.Name = "gpuLbl";
            this.gpuLbl.Size = new System.Drawing.Size(22, 12);
            this.gpuLbl.TabIndex = 10;
            this.gpuLbl.Text = "---";
            this.gpuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramLbl
            // 
            this.ramLbl.BackColor = System.Drawing.Color.Black;
            this.ramLbl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ramLbl.ForeColor = System.Drawing.Color.Green;
            this.ramLbl.Location = new System.Drawing.Point(222, 30);
            this.ramLbl.Name = "ramLbl";
            this.ramLbl.Size = new System.Drawing.Size(22, 12);
            this.ramLbl.TabIndex = 12;
            this.ramLbl.Text = "---";
            this.ramLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 10);
            this.label2.TabIndex = 13;
            this.label2.Text = "CPU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(524, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 10);
            this.label3.TabIndex = 14;
            this.label3.Text = "GPU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(221, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 10);
            this.label4.TabIndex = 15;
            this.label4.Text = "RAM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuTempLbl
            // 
            this.gpuTempLbl.BackColor = System.Drawing.Color.Black;
            this.gpuTempLbl.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gpuTempLbl.ForeColor = System.Drawing.Color.Red;
            this.gpuTempLbl.Location = new System.Drawing.Point(590, 47);
            this.gpuTempLbl.Name = "gpuTempLbl";
            this.gpuTempLbl.Size = new System.Drawing.Size(25, 12);
            this.gpuTempLbl.TabIndex = 16;
            this.gpuTempLbl.Text = "---";
            this.gpuTempLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(277, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 10);
            this.label6.TabIndex = 17;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(493, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 10);
            this.label7.TabIndex = 18;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(551, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 10);
            this.label8.TabIndex = 19;
            this.label8.Text = "RAM";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(182, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 11);
            this.label1.TabIndex = 20;
            this.label1.Text = "TEMP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(107, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 10);
            this.label9.TabIndex = 22;
            this.label9.Text = "FAN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(679, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 10);
            this.label10.TabIndex = 23;
            this.label10.Text = "FAN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(157, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 10);
            this.label11.TabIndex = 24;
            this.label11.Text = "oC";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(637, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 10);
            this.label12.TabIndex = 25;
            this.label12.Text = "oC";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(590, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "TEMP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ampmLbl
            // 
            this.ampmLbl.BackColor = System.Drawing.Color.Transparent;
            this.ampmLbl.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ampmLbl.ForeColor = System.Drawing.Color.Red;
            this.ampmLbl.Location = new System.Drawing.Point(425, 32);
            this.ampmLbl.Name = "ampmLbl";
            this.ampmLbl.Size = new System.Drawing.Size(23, 20);
            this.ampmLbl.TabIndex = 28;
            this.ampmLbl.Text = "---";
            this.ampmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ampmLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.ampmLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.ampmLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // clockLbl
            // 
            this.clockLbl.BackColor = System.Drawing.Color.Transparent;
            this.clockLbl.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clockLbl.ForeColor = System.Drawing.Color.Red;
            this.clockLbl.Location = new System.Drawing.Point(347, 21);
            this.clockLbl.Name = "clockLbl";
            this.clockLbl.Size = new System.Drawing.Size(92, 37);
            this.clockLbl.TabIndex = 27;
            this.clockLbl.Text = "--:--";
            this.clockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clockLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.clockLbl.Click += new System.EventHandler(this.clockLbl_Click);
            this.clockLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.clockLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShow,
            this.toolHide,
            this.toolInvalid,
            this.toolClose,
            this.toolPos,
            this.closeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(223, 160);
            // 
            // toolShow
            // 
            this.toolShow.Name = "toolShow";
            this.toolShow.Size = new System.Drawing.Size(222, 30);
            this.toolShow.Text = "Show";
            this.toolShow.Click += new System.EventHandler(this.toolShow_Click);
            // 
            // toolHide
            // 
            this.toolHide.Name = "toolHide";
            this.toolHide.Size = new System.Drawing.Size(222, 30);
            this.toolHide.Text = "Hide";
            this.toolHide.Click += new System.EventHandler(this.toolHide_Click);
            // 
            // toolInvalid
            // 
            this.toolInvalid.Name = "toolInvalid";
            this.toolInvalid.Size = new System.Drawing.Size(222, 30);
            this.toolInvalid.Text = "Toggle Moveable";
            this.toolInvalid.Click += new System.EventHandler(this.toolInvalid_Click);
            // 
            // toolClose
            // 
            this.toolClose.Name = "toolClose";
            this.toolClose.Size = new System.Drawing.Size(219, 6);
            // 
            // toolPos
            // 
            this.toolPos.Name = "toolPos";
            this.toolPos.Size = new System.Drawing.Size(222, 30);
            this.toolPos.Text = "Save Position";
            this.toolPos.Click += new System.EventHandler(this.toolPos_Click_1);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Miku Clock";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // falloutStat
            // 
            this.falloutStat.BackColor = System.Drawing.Color.Transparent;
            this.falloutStat.Image = ((System.Drawing.Image)(resources.GetObject("falloutStat.Image")));
            this.falloutStat.Location = new System.Drawing.Point(376, 71);
            this.falloutStat.Name = "falloutStat";
            this.falloutStat.Size = new System.Drawing.Size(49, 51);
            this.falloutStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.falloutStat.TabIndex = 29;
            this.falloutStat.TabStop = false;
            // 
            // cpuCLK
            // 
            this.cpuCLK.BackColor = System.Drawing.Color.Transparent;
            this.cpuCLK.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cpuCLK.ForeColor = System.Drawing.Color.White;
            this.cpuCLK.Location = new System.Drawing.Point(24, 16);
            this.cpuCLK.Name = "cpuCLK";
            this.cpuCLK.Size = new System.Drawing.Size(54, 32);
            this.cpuCLK.TabIndex = 30;
            this.cpuCLK.Text = "---";
            this.cpuCLK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuCLK
            // 
            this.gpuCLK.BackColor = System.Drawing.Color.Transparent;
            this.gpuCLK.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gpuCLK.ForeColor = System.Drawing.Color.White;
            this.gpuCLK.Location = new System.Drawing.Point(720, 16);
            this.gpuCLK.Name = "gpuCLK";
            this.gpuCLK.Size = new System.Drawing.Size(54, 32);
            this.gpuCLK.TabIndex = 31;
            this.gpuCLK.Text = "---";
            this.gpuCLK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fadeInAnim
            // 
            this.fadeInAnim.Interval = 5;
            this.fadeInAnim.Tick += new System.EventHandler(this.fadeInAnim_Tick);
            // 
            // vuVRam
            // 
            this.vuVRam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuVRam.BackgroundImage")));
            this.vuVRam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuVRam.BaseArcColor = System.Drawing.Color.Gray;
            this.vuVRam.BaseArcRadius = 100;
            this.vuVRam.BaseArcStart = -30;
            this.vuVRam.BaseArcSweep = 250;
            this.vuVRam.BaseArcWidth = 2;
            this.vuVRam.Cap_Idx = ((byte)(1));
            this.vuVRam.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuVRam.CapPosition = new System.Drawing.Point(10, 10);
            this.vuVRam.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuVRam.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuVRam.CapText = "";
            this.vuVRam.Center = new System.Drawing.Point(25, 24);
            this.vuVRam.Location = new System.Drawing.Point(538, 11);
            this.vuVRam.MaxValue = 115F;
            this.vuVRam.MinValue = 0F;
            this.vuVRam.Name = "vuVRam";
            this.vuVRam.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.vuVRam.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuVRam.NeedleRadius = 18;
            this.vuVRam.NeedleType = 1;
            this.vuVRam.NeedleWidth = 4;
            this.vuVRam.Range_Idx = ((byte)(0));
            this.vuVRam.RangeColor = System.Drawing.Color.LightGreen;
            this.vuVRam.RangeEnabled = true;
            this.vuVRam.RangeEndValue = 300F;
            this.vuVRam.RangeInnerRadius = 70;
            this.vuVRam.RangeOuterRadius = 80;
            this.vuVRam.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuVRam.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.vuVRam.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.vuVRam.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.vuVRam.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.vuVRam.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.vuVRam.RangeStartValue = -100F;
            this.vuVRam.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.vuVRam.ScaleLinesInterInnerRadius = 73;
            this.vuVRam.ScaleLinesInterOuterRadius = 80;
            this.vuVRam.ScaleLinesInterWidth = 1;
            this.vuVRam.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuVRam.ScaleLinesMajorInnerRadius = 70;
            this.vuVRam.ScaleLinesMajorOuterRadius = 80;
            this.vuVRam.ScaleLinesMajorStepValue = 50F;
            this.vuVRam.ScaleLinesMajorWidth = 2;
            this.vuVRam.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuVRam.ScaleLinesMinorInnerRadius = 75;
            this.vuVRam.ScaleLinesMinorNumOf = 9;
            this.vuVRam.ScaleLinesMinorOuterRadius = 80;
            this.vuVRam.ScaleLinesMinorWidth = 1;
            this.vuVRam.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuVRam.ScaleNumbersFormat = null;
            this.vuVRam.ScaleNumbersRadius = 95;
            this.vuVRam.ScaleNumbersRotation = 0;
            this.vuVRam.ScaleNumbersStartScaleLine = 0;
            this.vuVRam.ScaleNumbersStepScaleLines = 1;
            this.vuVRam.Size = new System.Drawing.Size(50, 50);
            this.vuVRam.TabIndex = 7;
            this.vuVRam.Text = "aGauge7";
            this.vuVRam.Value = 0F;
            this.vuVRam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuVRam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuVRam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // vuGPU
            // 
            this.vuGPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuGPU.BackgroundImage")));
            this.vuGPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuGPU.BaseArcColor = System.Drawing.Color.Gray;
            this.vuGPU.BaseArcRadius = 100;
            this.vuGPU.BaseArcStart = -30;
            this.vuGPU.BaseArcSweep = 250;
            this.vuGPU.BaseArcWidth = 2;
            this.vuGPU.Cap_Idx = ((byte)(1));
            this.vuGPU.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuGPU.CapPosition = new System.Drawing.Point(10, 10);
            this.vuGPU.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuGPU.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuGPU.CapText = "";
            this.vuGPU.Center = new System.Drawing.Point(25, 24);
            this.vuGPU.Location = new System.Drawing.Point(481, 11);
            this.vuGPU.MaxValue = 115F;
            this.vuGPU.MinValue = 0F;
            this.vuGPU.Name = "vuGPU";
            this.vuGPU.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.vuGPU.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuGPU.NeedleRadius = 18;
            this.vuGPU.NeedleType = 1;
            this.vuGPU.NeedleWidth = 4;
            this.vuGPU.Range_Idx = ((byte)(0));
            this.vuGPU.RangeColor = System.Drawing.Color.LightGreen;
            this.vuGPU.RangeEnabled = true;
            this.vuGPU.RangeEndValue = 300F;
            this.vuGPU.RangeInnerRadius = 70;
            this.vuGPU.RangeOuterRadius = 80;
            this.vuGPU.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuGPU.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.vuGPU.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.vuGPU.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.vuGPU.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.vuGPU.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.vuGPU.RangeStartValue = -100F;
            this.vuGPU.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.vuGPU.ScaleLinesInterInnerRadius = 73;
            this.vuGPU.ScaleLinesInterOuterRadius = 80;
            this.vuGPU.ScaleLinesInterWidth = 1;
            this.vuGPU.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuGPU.ScaleLinesMajorInnerRadius = 70;
            this.vuGPU.ScaleLinesMajorOuterRadius = 80;
            this.vuGPU.ScaleLinesMajorStepValue = 50F;
            this.vuGPU.ScaleLinesMajorWidth = 2;
            this.vuGPU.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuGPU.ScaleLinesMinorInnerRadius = 75;
            this.vuGPU.ScaleLinesMinorNumOf = 9;
            this.vuGPU.ScaleLinesMinorOuterRadius = 80;
            this.vuGPU.ScaleLinesMinorWidth = 1;
            this.vuGPU.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuGPU.ScaleNumbersFormat = null;
            this.vuGPU.ScaleNumbersRadius = 95;
            this.vuGPU.ScaleNumbersRotation = 0;
            this.vuGPU.ScaleNumbersStartScaleLine = 0;
            this.vuGPU.ScaleNumbersStepScaleLines = 1;
            this.vuGPU.Size = new System.Drawing.Size(50, 50);
            this.vuGPU.TabIndex = 6;
            this.vuGPU.Text = "aGauge8";
            this.vuGPU.Value = 0F;
            this.vuGPU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuGPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuGPU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // vuCPU
            // 
            this.vuCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuCPU.BackgroundImage")));
            this.vuCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuCPU.BaseArcColor = System.Drawing.Color.Gray;
            this.vuCPU.BaseArcRadius = 100;
            this.vuCPU.BaseArcStart = -30;
            this.vuCPU.BaseArcSweep = 250;
            this.vuCPU.BaseArcWidth = 2;
            this.vuCPU.Cap_Idx = ((byte)(1));
            this.vuCPU.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuCPU.CapPosition = new System.Drawing.Point(10, 10);
            this.vuCPU.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuCPU.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuCPU.CapText = "";
            this.vuCPU.Center = new System.Drawing.Point(25, 24);
            this.vuCPU.Location = new System.Drawing.Point(265, 11);
            this.vuCPU.MaxValue = 115F;
            this.vuCPU.MinValue = 0F;
            this.vuCPU.Name = "vuCPU";
            this.vuCPU.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.vuCPU.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuCPU.NeedleRadius = 18;
            this.vuCPU.NeedleType = 1;
            this.vuCPU.NeedleWidth = 4;
            this.vuCPU.Range_Idx = ((byte)(0));
            this.vuCPU.RangeColor = System.Drawing.Color.LightGreen;
            this.vuCPU.RangeEnabled = true;
            this.vuCPU.RangeEndValue = 300F;
            this.vuCPU.RangeInnerRadius = 70;
            this.vuCPU.RangeOuterRadius = 80;
            this.vuCPU.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuCPU.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.vuCPU.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.vuCPU.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.vuCPU.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.vuCPU.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.vuCPU.RangeStartValue = -100F;
            this.vuCPU.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.vuCPU.ScaleLinesInterInnerRadius = 73;
            this.vuCPU.ScaleLinesInterOuterRadius = 80;
            this.vuCPU.ScaleLinesInterWidth = 1;
            this.vuCPU.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuCPU.ScaleLinesMajorInnerRadius = 70;
            this.vuCPU.ScaleLinesMajorOuterRadius = 80;
            this.vuCPU.ScaleLinesMajorStepValue = 50F;
            this.vuCPU.ScaleLinesMajorWidth = 2;
            this.vuCPU.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuCPU.ScaleLinesMinorInnerRadius = 75;
            this.vuCPU.ScaleLinesMinorNumOf = 9;
            this.vuCPU.ScaleLinesMinorOuterRadius = 80;
            this.vuCPU.ScaleLinesMinorWidth = 1;
            this.vuCPU.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuCPU.ScaleNumbersFormat = null;
            this.vuCPU.ScaleNumbersRadius = 95;
            this.vuCPU.ScaleNumbersRotation = 0;
            this.vuCPU.ScaleNumbersStartScaleLine = 0;
            this.vuCPU.ScaleNumbersStepScaleLines = 1;
            this.vuCPU.Size = new System.Drawing.Size(50, 50);
            this.vuCPU.TabIndex = 5;
            this.vuCPU.Text = "aGauge6";
            this.vuCPU.Value = 0F;
            this.vuCPU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuCPU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuCPU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // vuRam
            // 
            this.vuRam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuRam.BackgroundImage")));
            this.vuRam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuRam.BaseArcColor = System.Drawing.Color.Gray;
            this.vuRam.BaseArcRadius = 100;
            this.vuRam.BaseArcStart = -30;
            this.vuRam.BaseArcSweep = 250;
            this.vuRam.BaseArcWidth = 2;
            this.vuRam.Cap_Idx = ((byte)(1));
            this.vuRam.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuRam.CapPosition = new System.Drawing.Point(10, 10);
            this.vuRam.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuRam.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuRam.CapText = "";
            this.vuRam.Center = new System.Drawing.Point(25, 24);
            this.vuRam.Location = new System.Drawing.Point(208, 11);
            this.vuRam.MaxValue = 115F;
            this.vuRam.MinValue = 0F;
            this.vuRam.Name = "vuRam";
            this.vuRam.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.vuRam.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuRam.NeedleRadius = 18;
            this.vuRam.NeedleType = 1;
            this.vuRam.NeedleWidth = 4;
            this.vuRam.Range_Idx = ((byte)(0));
            this.vuRam.RangeColor = System.Drawing.Color.LightGreen;
            this.vuRam.RangeEnabled = true;
            this.vuRam.RangeEndValue = 300F;
            this.vuRam.RangeInnerRadius = 70;
            this.vuRam.RangeOuterRadius = 80;
            this.vuRam.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuRam.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.vuRam.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.vuRam.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.vuRam.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.vuRam.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.vuRam.RangeStartValue = -100F;
            this.vuRam.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.vuRam.ScaleLinesInterInnerRadius = 73;
            this.vuRam.ScaleLinesInterOuterRadius = 80;
            this.vuRam.ScaleLinesInterWidth = 1;
            this.vuRam.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuRam.ScaleLinesMajorInnerRadius = 70;
            this.vuRam.ScaleLinesMajorOuterRadius = 80;
            this.vuRam.ScaleLinesMajorStepValue = 50F;
            this.vuRam.ScaleLinesMajorWidth = 2;
            this.vuRam.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuRam.ScaleLinesMinorInnerRadius = 75;
            this.vuRam.ScaleLinesMinorNumOf = 9;
            this.vuRam.ScaleLinesMinorOuterRadius = 80;
            this.vuRam.ScaleLinesMinorWidth = 1;
            this.vuRam.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuRam.ScaleNumbersFormat = null;
            this.vuRam.ScaleNumbersRadius = 95;
            this.vuRam.ScaleNumbersRotation = 0;
            this.vuRam.ScaleNumbersStartScaleLine = 0;
            this.vuRam.ScaleNumbersStepScaleLines = 1;
            this.vuRam.Size = new System.Drawing.Size(50, 50);
            this.vuRam.TabIndex = 4;
            this.vuRam.Text = "aGauge5";
            this.vuRam.Value = 0F;
            this.vuRam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuRam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuRam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // vuGPUF
            // 
            this.vuGPUF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuGPUF.BackgroundImage")));
            this.vuGPUF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuGPUF.BaseArcColor = System.Drawing.Color.Gray;
            this.vuGPUF.BaseArcRadius = 100;
            this.vuGPUF.BaseArcStart = 55;
            this.vuGPUF.BaseArcSweep = 260;
            this.vuGPUF.BaseArcWidth = 2;
            this.vuGPUF.Cap_Idx = ((byte)(1));
            this.vuGPUF.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuGPUF.CapPosition = new System.Drawing.Point(10, 10);
            this.vuGPUF.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuGPUF.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuGPUF.CapText = "";
            this.vuGPUF.Center = new System.Drawing.Point(25, 21);
            this.vuGPUF.Location = new System.Drawing.Point(664, 11);
            this.vuGPUF.MaxValue = 100F;
            this.vuGPUF.MinValue = 0F;
            this.vuGPUF.Name = "vuGPUF";
            this.vuGPUF.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.vuGPUF.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuGPUF.NeedleRadius = 18;
            this.vuGPUF.NeedleType = 1;
            this.vuGPUF.NeedleWidth = 4;
            this.vuGPUF.Range_Idx = ((byte)(0));
            this.vuGPUF.RangeColor = System.Drawing.Color.LightGreen;
            this.vuGPUF.RangeEnabled = true;
            this.vuGPUF.RangeEndValue = 300F;
            this.vuGPUF.RangeInnerRadius = 70;
            this.vuGPUF.RangeOuterRadius = 80;
            this.vuGPUF.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuGPUF.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.vuGPUF.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.vuGPUF.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.vuGPUF.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.vuGPUF.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.vuGPUF.RangeStartValue = -100F;
            this.vuGPUF.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.vuGPUF.ScaleLinesInterInnerRadius = 73;
            this.vuGPUF.ScaleLinesInterOuterRadius = 80;
            this.vuGPUF.ScaleLinesInterWidth = 1;
            this.vuGPUF.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuGPUF.ScaleLinesMajorInnerRadius = 70;
            this.vuGPUF.ScaleLinesMajorOuterRadius = 80;
            this.vuGPUF.ScaleLinesMajorStepValue = 50F;
            this.vuGPUF.ScaleLinesMajorWidth = 2;
            this.vuGPUF.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuGPUF.ScaleLinesMinorInnerRadius = 75;
            this.vuGPUF.ScaleLinesMinorNumOf = 9;
            this.vuGPUF.ScaleLinesMinorOuterRadius = 80;
            this.vuGPUF.ScaleLinesMinorWidth = 1;
            this.vuGPUF.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuGPUF.ScaleNumbersFormat = null;
            this.vuGPUF.ScaleNumbersRadius = 95;
            this.vuGPUF.ScaleNumbersRotation = 0;
            this.vuGPUF.ScaleNumbersStartScaleLine = 0;
            this.vuGPUF.ScaleNumbersStepScaleLines = 1;
            this.vuGPUF.Size = new System.Drawing.Size(40, 43);
            this.vuGPUF.TabIndex = 3;
            this.vuGPUF.Text = "aGauge4";
            this.vuGPUF.Value = 0F;
            this.vuGPUF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuGPUF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuGPUF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // vuCPUF
            // 
            this.vuCPUF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuCPUF.BackgroundImage")));
            this.vuCPUF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuCPUF.BaseArcColor = System.Drawing.Color.Gray;
            this.vuCPUF.BaseArcRadius = 100;
            this.vuCPUF.BaseArcStart = 55;
            this.vuCPUF.BaseArcSweep = 260;
            this.vuCPUF.BaseArcWidth = 2;
            this.vuCPUF.Cap_Idx = ((byte)(1));
            this.vuCPUF.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuCPUF.CapPosition = new System.Drawing.Point(10, 10);
            this.vuCPUF.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuCPUF.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuCPUF.CapText = "";
            this.vuCPUF.Center = new System.Drawing.Point(25, 21);
            this.vuCPUF.Location = new System.Drawing.Point(93, 12);
            this.vuCPUF.MaxValue = 100F;
            this.vuCPUF.MinValue = 0F;
            this.vuCPUF.Name = "vuCPUF";
            this.vuCPUF.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.vuCPUF.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuCPUF.NeedleRadius = 18;
            this.vuCPUF.NeedleType = 1;
            this.vuCPUF.NeedleWidth = 4;
            this.vuCPUF.Range_Idx = ((byte)(0));
            this.vuCPUF.RangeColor = System.Drawing.Color.LightGreen;
            this.vuCPUF.RangeEnabled = true;
            this.vuCPUF.RangeEndValue = 300F;
            this.vuCPUF.RangeInnerRadius = 70;
            this.vuCPUF.RangeOuterRadius = 80;
            this.vuCPUF.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuCPUF.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.vuCPUF.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.vuCPUF.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.vuCPUF.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.vuCPUF.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.vuCPUF.RangeStartValue = -100F;
            this.vuCPUF.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.vuCPUF.ScaleLinesInterInnerRadius = 73;
            this.vuCPUF.ScaleLinesInterOuterRadius = 80;
            this.vuCPUF.ScaleLinesInterWidth = 1;
            this.vuCPUF.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuCPUF.ScaleLinesMajorInnerRadius = 70;
            this.vuCPUF.ScaleLinesMajorOuterRadius = 80;
            this.vuCPUF.ScaleLinesMajorStepValue = 50F;
            this.vuCPUF.ScaleLinesMajorWidth = 2;
            this.vuCPUF.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuCPUF.ScaleLinesMinorInnerRadius = 75;
            this.vuCPUF.ScaleLinesMinorNumOf = 9;
            this.vuCPUF.ScaleLinesMinorOuterRadius = 80;
            this.vuCPUF.ScaleLinesMinorWidth = 1;
            this.vuCPUF.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuCPUF.ScaleNumbersFormat = null;
            this.vuCPUF.ScaleNumbersRadius = 95;
            this.vuCPUF.ScaleNumbersRotation = 0;
            this.vuCPUF.ScaleNumbersStartScaleLine = 0;
            this.vuCPUF.ScaleNumbersStepScaleLines = 1;
            this.vuCPUF.Size = new System.Drawing.Size(40, 43);
            this.vuCPUF.TabIndex = 2;
            this.vuCPUF.Text = "aGauge3";
            this.vuCPUF.Value = 0F;
            this.vuCPUF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuCPUF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuCPUF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // vuCPUT
            // 
            this.vuCPUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuCPUT.BackgroundImage")));
            this.vuCPUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuCPUT.BaseArcColor = System.Drawing.Color.Gray;
            this.vuCPUT.BaseArcRadius = 100;
            this.vuCPUT.BaseArcStart = 57;
            this.vuCPUT.BaseArcSweep = 255;
            this.vuCPUT.BaseArcWidth = 2;
            this.vuCPUT.Cap_Idx = ((byte)(1));
            this.vuCPUT.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuCPUT.CapPosition = new System.Drawing.Point(10, 10);
            this.vuCPUT.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuCPUT.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuCPUT.CapText = "";
            this.vuCPUT.Center = new System.Drawing.Point(29, 24);
            this.vuCPUT.Location = new System.Drawing.Point(136, 13);
            this.vuCPUT.MaxValue = 100F;
            this.vuCPUT.MinValue = 0F;
            this.vuCPUT.Name = "vuCPUT";
            this.vuCPUT.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.vuCPUT.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuCPUT.NeedleRadius = 21;
            this.vuCPUT.NeedleType = 1;
            this.vuCPUT.NeedleWidth = 4;
            this.vuCPUT.Range_Idx = ((byte)(0));
            this.vuCPUT.RangeColor = System.Drawing.Color.LightGreen;
            this.vuCPUT.RangeEnabled = true;
            this.vuCPUT.RangeEndValue = 300F;
            this.vuCPUT.RangeInnerRadius = 70;
            this.vuCPUT.RangeOuterRadius = 80;
            this.vuCPUT.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuCPUT.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.vuCPUT.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.vuCPUT.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.vuCPUT.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.vuCPUT.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.vuCPUT.RangeStartValue = -100F;
            this.vuCPUT.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.vuCPUT.ScaleLinesInterInnerRadius = 73;
            this.vuCPUT.ScaleLinesInterOuterRadius = 80;
            this.vuCPUT.ScaleLinesInterWidth = 1;
            this.vuCPUT.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuCPUT.ScaleLinesMajorInnerRadius = 70;
            this.vuCPUT.ScaleLinesMajorOuterRadius = 80;
            this.vuCPUT.ScaleLinesMajorStepValue = 50F;
            this.vuCPUT.ScaleLinesMajorWidth = 2;
            this.vuCPUT.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuCPUT.ScaleLinesMinorInnerRadius = 75;
            this.vuCPUT.ScaleLinesMinorNumOf = 9;
            this.vuCPUT.ScaleLinesMinorOuterRadius = 80;
            this.vuCPUT.ScaleLinesMinorWidth = 1;
            this.vuCPUT.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuCPUT.ScaleNumbersFormat = null;
            this.vuCPUT.ScaleNumbersRadius = 95;
            this.vuCPUT.ScaleNumbersRotation = 0;
            this.vuCPUT.ScaleNumbersStartScaleLine = 0;
            this.vuCPUT.ScaleNumbersStepScaleLines = 1;
            this.vuCPUT.Size = new System.Drawing.Size(45, 50);
            this.vuCPUT.TabIndex = 1;
            this.vuCPUT.Text = "aGauge2";
            this.vuCPUT.Value = 0F;
            this.vuCPUT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuCPUT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuCPUT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // vuGPUT
            // 
            this.vuGPUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vuGPUT.BackgroundImage")));
            this.vuGPUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vuGPUT.BaseArcColor = System.Drawing.Color.Gray;
            this.vuGPUT.BaseArcRadius = 100;
            this.vuGPUT.BaseArcStart = 57;
            this.vuGPUT.BaseArcSweep = 255;
            this.vuGPUT.BaseArcWidth = 2;
            this.vuGPUT.Cap_Idx = ((byte)(1));
            this.vuGPUT.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.vuGPUT.CapPosition = new System.Drawing.Point(10, 10);
            this.vuGPUT.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.vuGPUT.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.vuGPUT.CapText = "";
            this.vuGPUT.Center = new System.Drawing.Point(29, 24);
            this.vuGPUT.Location = new System.Drawing.Point(616, 13);
            this.vuGPUT.MaxValue = 100F;
            this.vuGPUT.MinValue = 0F;
            this.vuGPUT.Name = "vuGPUT";
            this.vuGPUT.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Green;
            this.vuGPUT.NeedleColor2 = System.Drawing.Color.DimGray;
            this.vuGPUT.NeedleRadius = 21;
            this.vuGPUT.NeedleType = 1;
            this.vuGPUT.NeedleWidth = 4;
            this.vuGPUT.Range_Idx = ((byte)(0));
            this.vuGPUT.RangeColor = System.Drawing.Color.LightGreen;
            this.vuGPUT.RangeEnabled = true;
            this.vuGPUT.RangeEndValue = 300F;
            this.vuGPUT.RangeInnerRadius = 70;
            this.vuGPUT.RangeOuterRadius = 80;
            this.vuGPUT.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.vuGPUT.RangesEnabled = new bool[] {
        true,
        true,
        false,
        false,
        false};
            this.vuGPUT.RangesEndValue = new float[] {
        300F,
        400F,
        0F,
        0F,
        0F};
            this.vuGPUT.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.vuGPUT.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.vuGPUT.RangesStartValue = new float[] {
        -100F,
        300F,
        0F,
        0F,
        0F};
            this.vuGPUT.RangeStartValue = -100F;
            this.vuGPUT.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.vuGPUT.ScaleLinesInterInnerRadius = 73;
            this.vuGPUT.ScaleLinesInterOuterRadius = 80;
            this.vuGPUT.ScaleLinesInterWidth = 1;
            this.vuGPUT.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.vuGPUT.ScaleLinesMajorInnerRadius = 70;
            this.vuGPUT.ScaleLinesMajorOuterRadius = 80;
            this.vuGPUT.ScaleLinesMajorStepValue = 50F;
            this.vuGPUT.ScaleLinesMajorWidth = 2;
            this.vuGPUT.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.vuGPUT.ScaleLinesMinorInnerRadius = 75;
            this.vuGPUT.ScaleLinesMinorNumOf = 9;
            this.vuGPUT.ScaleLinesMinorOuterRadius = 80;
            this.vuGPUT.ScaleLinesMinorWidth = 1;
            this.vuGPUT.ScaleNumbersColor = System.Drawing.Color.Black;
            this.vuGPUT.ScaleNumbersFormat = null;
            this.vuGPUT.ScaleNumbersRadius = 95;
            this.vuGPUT.ScaleNumbersRotation = 0;
            this.vuGPUT.ScaleNumbersStartScaleLine = 0;
            this.vuGPUT.ScaleNumbersStepScaleLines = 1;
            this.vuGPUT.Size = new System.Drawing.Size(45, 50);
            this.vuGPUT.TabIndex = 0;
            this.vuGPUT.Text = "aGauge1";
            this.vuGPUT.Value = 0F;
            this.vuGPUT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.vuGPUT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.vuGPUT.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // MikuDashMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(843, 144);
            this.ControlBox = false;
            this.Controls.Add(this.gpuCLK);
            this.Controls.Add(this.cpuCLK);
            this.Controls.Add(this.ampmLbl);
            this.Controls.Add(this.clockLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.falloutStat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpuTempLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ramLbl);
            this.Controls.Add(this.vramLbl);
            this.Controls.Add(this.gpuLbl);
            this.Controls.Add(this.cpuLbl);
            this.Controls.Add(this.cpuTempLbl);
            this.Controls.Add(this.vuVRam);
            this.Controls.Add(this.vuGPU);
            this.Controls.Add(this.vuCPU);
            this.Controls.Add(this.vuRam);
            this.Controls.Add(this.vuGPUF);
            this.Controls.Add(this.vuCPUF);
            this.Controls.Add(this.vuCPUT);
            this.Controls.Add(this.vuGPUT);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MikuDashMain";
            this.Opacity = 0;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MainDash";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MikuDashMain_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.falloutStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AGaugeApp.AGauge vuGPUT;
        private AGaugeApp.AGauge vuCPUT;
        private AGaugeApp.AGauge vuCPUF;
        private AGaugeApp.AGauge vuGPUF;
        private AGaugeApp.AGauge vuRam;
        private AGaugeApp.AGauge vuCPU;
        private AGaugeApp.AGauge vuVRam;
        private AGaugeApp.AGauge vuGPU;
        private System.Windows.Forms.Label cpuTempLbl;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.Label vramLbl;
        private System.Windows.Forms.Label gpuLbl;
        private System.Windows.Forms.Label ramLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label gpuTempLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ampmLbl;
        private System.Windows.Forms.Label clockLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolShow;
        private System.Windows.Forms.ToolStripMenuItem toolHide;
        private System.Windows.Forms.ToolStripSeparator toolClose;
        private System.Windows.Forms.ToolStripMenuItem toolPos;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toolInvalid;
        private System.Windows.Forms.PictureBox falloutStat;
        private System.Windows.Forms.Label cpuCLK;
        private System.Windows.Forms.Label gpuCLK;
        private System.Windows.Forms.Timer fadeInAnim;
    }
}

