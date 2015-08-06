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
            this.gpuTempLbl = new System.Windows.Forms.Label();
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
            this.cpuCLK = new System.Windows.Forms.Label();
            this.gpuCLK = new System.Windows.Forms.Label();
            this.fadeInAnim = new System.Windows.Forms.Timer(this.components);
            this.gpuFan = new System.Windows.Forms.Label();
            this.cpuFan = new System.Windows.Forms.Label();
            this.pictureCpuUsage = new System.Windows.Forms.PictureBox();
            this.pictureGpuUsage = new System.Windows.Forms.PictureBox();
            this.pictureGpuRam = new System.Windows.Forms.PictureBox();
            this.pictureCpuRam = new System.Windows.Forms.PictureBox();
            this.infoDisplay = new System.Windows.Forms.Label();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCpuUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGpuUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGpuRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCpuRam)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuTempLbl
            // 
            this.cpuTempLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpuTempLbl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cpuTempLbl.ForeColor = System.Drawing.Color.White;
            this.cpuTempLbl.Location = new System.Drawing.Point(261, 52);
            this.cpuTempLbl.Name = "cpuTempLbl";
            this.cpuTempLbl.Size = new System.Drawing.Size(51, 20);
            this.cpuTempLbl.TabIndex = 8;
            this.cpuTempLbl.Text = "---";
            this.cpuTempLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuLbl
            // 
            this.cpuLbl.BackColor = System.Drawing.Color.Transparent;
            this.cpuLbl.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cpuLbl.ForeColor = System.Drawing.Color.White;
            this.cpuLbl.Location = new System.Drawing.Point(539, 31);
            this.cpuLbl.Name = "cpuLbl";
            this.cpuLbl.Size = new System.Drawing.Size(39, 20);
            this.cpuLbl.TabIndex = 9;
            this.cpuLbl.Text = "---";
            this.cpuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vramLbl
            // 
            this.vramLbl.BackColor = System.Drawing.Color.Transparent;
            this.vramLbl.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.vramLbl.ForeColor = System.Drawing.Color.White;
            this.vramLbl.Location = new System.Drawing.Point(830, 43);
            this.vramLbl.Name = "vramLbl";
            this.vramLbl.Size = new System.Drawing.Size(39, 20);
            this.vramLbl.TabIndex = 11;
            this.vramLbl.Text = "---";
            this.vramLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuLbl
            // 
            this.gpuLbl.BackColor = System.Drawing.Color.Transparent;
            this.gpuLbl.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gpuLbl.ForeColor = System.Drawing.Color.White;
            this.gpuLbl.Location = new System.Drawing.Point(780, 31);
            this.gpuLbl.Name = "gpuLbl";
            this.gpuLbl.Size = new System.Drawing.Size(39, 20);
            this.gpuLbl.TabIndex = 10;
            this.gpuLbl.Text = "---";
            this.gpuLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ramLbl
            // 
            this.ramLbl.BackColor = System.Drawing.Color.Transparent;
            this.ramLbl.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ramLbl.ForeColor = System.Drawing.Color.White;
            this.ramLbl.Location = new System.Drawing.Point(490, 43);
            this.ramLbl.Name = "ramLbl";
            this.ramLbl.Size = new System.Drawing.Size(39, 20);
            this.ramLbl.TabIndex = 12;
            this.ramLbl.Text = "---";
            this.ramLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuTempLbl
            // 
            this.gpuTempLbl.BackColor = System.Drawing.Color.Transparent;
            this.gpuTempLbl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gpuTempLbl.ForeColor = System.Drawing.Color.White;
            this.gpuTempLbl.Location = new System.Drawing.Point(925, 52);
            this.gpuTempLbl.Name = "gpuTempLbl";
            this.gpuTempLbl.Size = new System.Drawing.Size(51, 20);
            this.gpuTempLbl.TabIndex = 16;
            this.gpuTempLbl.Text = "---";
            this.gpuTempLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ampmLbl
            // 
            this.ampmLbl.BackColor = System.Drawing.Color.Transparent;
            this.ampmLbl.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ampmLbl.ForeColor = System.Drawing.Color.Red;
            this.ampmLbl.Location = new System.Drawing.Point(734, 42);
            this.ampmLbl.Name = "ampmLbl";
            this.ampmLbl.Size = new System.Drawing.Size(34, 24);
            this.ampmLbl.TabIndex = 28;
            this.ampmLbl.Text = "--";
            this.ampmLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ampmLbl.Click += new System.EventHandler(this.ampmLbl_Click);
            this.ampmLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.ampmLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.ampmLbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            // 
            // clockLbl
            // 
            this.clockLbl.BackColor = System.Drawing.Color.Transparent;
            this.clockLbl.Font = new System.Drawing.Font("Consolas", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.clockLbl.ForeColor = System.Drawing.Color.Red;
            this.clockLbl.Location = new System.Drawing.Point(594, 20);
            this.clockLbl.Name = "clockLbl";
            this.clockLbl.Size = new System.Drawing.Size(157, 53);
            this.clockLbl.TabIndex = 27;
            this.clockLbl.Text = "--:--";
            this.clockLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clockLbl.Click += new System.EventHandler(this.clockLbl_Click);
            this.clockLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.clockLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
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
            this.notifyIcon.Text = "Andromeda";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cpuCLK
            // 
            this.cpuCLK.BackColor = System.Drawing.Color.Transparent;
            this.cpuCLK.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cpuCLK.ForeColor = System.Drawing.Color.White;
            this.cpuCLK.Location = new System.Drawing.Point(151, 46);
            this.cpuCLK.Name = "cpuCLK";
            this.cpuCLK.Size = new System.Drawing.Size(54, 32);
            this.cpuCLK.TabIndex = 30;
            this.cpuCLK.Text = "----";
            this.cpuCLK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpuCLK
            // 
            this.gpuCLK.BackColor = System.Drawing.Color.Transparent;
            this.gpuCLK.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gpuCLK.ForeColor = System.Drawing.Color.White;
            this.gpuCLK.Location = new System.Drawing.Point(1156, 46);
            this.gpuCLK.Name = "gpuCLK";
            this.gpuCLK.Size = new System.Drawing.Size(54, 32);
            this.gpuCLK.TabIndex = 31;
            this.gpuCLK.Text = "----";
            this.gpuCLK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fadeInAnim
            // 
            this.fadeInAnim.Interval = 5;
            this.fadeInAnim.Tick += new System.EventHandler(this.fadeInAnim_Tick);
            // 
            // gpuFan
            // 
            this.gpuFan.BackColor = System.Drawing.Color.Transparent;
            this.gpuFan.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gpuFan.ForeColor = System.Drawing.Color.White;
            this.gpuFan.Location = new System.Drawing.Point(1028, 52);
            this.gpuFan.Name = "gpuFan";
            this.gpuFan.Size = new System.Drawing.Size(51, 20);
            this.gpuFan.TabIndex = 33;
            this.gpuFan.Text = "----";
            this.gpuFan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuFan
            // 
            this.cpuFan.BackColor = System.Drawing.Color.Transparent;
            this.cpuFan.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cpuFan.ForeColor = System.Drawing.Color.White;
            this.cpuFan.Location = new System.Drawing.Point(364, 52);
            this.cpuFan.Name = "cpuFan";
            this.cpuFan.Size = new System.Drawing.Size(51, 20);
            this.cpuFan.TabIndex = 32;
            this.cpuFan.Text = "----";
            this.cpuFan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureCpuUsage
            // 
            this.pictureCpuUsage.BackColor = System.Drawing.Color.Transparent;
            this.pictureCpuUsage.Image = ((System.Drawing.Image)(resources.GetObject("pictureCpuUsage.Image")));
            this.pictureCpuUsage.Location = new System.Drawing.Point(212, 22);
            this.pictureCpuUsage.Name = "pictureCpuUsage";
            this.pictureCpuUsage.Size = new System.Drawing.Size(376, 13);
            this.pictureCpuUsage.TabIndex = 34;
            this.pictureCpuUsage.TabStop = false;
            // 
            // pictureGpuUsage
            // 
            this.pictureGpuUsage.BackColor = System.Drawing.Color.Transparent;
            this.pictureGpuUsage.Image = ((System.Drawing.Image)(resources.GetObject("pictureGpuUsage.Image")));
            this.pictureGpuUsage.Location = new System.Drawing.Point(771, 22);
            this.pictureGpuUsage.Name = "pictureGpuUsage";
            this.pictureGpuUsage.Size = new System.Drawing.Size(376, 13);
            this.pictureGpuUsage.TabIndex = 35;
            this.pictureGpuUsage.TabStop = false;
            // 
            // pictureGpuRam
            // 
            this.pictureGpuRam.BackColor = System.Drawing.Color.Transparent;
            this.pictureGpuRam.Image = ((System.Drawing.Image)(resources.GetObject("pictureGpuRam.Image")));
            this.pictureGpuRam.Location = new System.Drawing.Point(825, 39);
            this.pictureGpuRam.Name = "pictureGpuRam";
            this.pictureGpuRam.Size = new System.Drawing.Size(327, 10);
            this.pictureGpuRam.TabIndex = 36;
            this.pictureGpuRam.TabStop = false;
            // 
            // pictureCpuRam
            // 
            this.pictureCpuRam.BackColor = System.Drawing.Color.Transparent;
            this.pictureCpuRam.Image = ((System.Drawing.Image)(resources.GetObject("pictureCpuRam.Image")));
            this.pictureCpuRam.Location = new System.Drawing.Point(211, 39);
            this.pictureCpuRam.Name = "pictureCpuRam";
            this.pictureCpuRam.Size = new System.Drawing.Size(327, 10);
            this.pictureCpuRam.TabIndex = 37;
            this.pictureCpuRam.TabStop = false;
            // 
            // infoDisplay
            // 
            this.infoDisplay.BackColor = System.Drawing.Color.Transparent;
            this.infoDisplay.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoDisplay.ForeColor = System.Drawing.Color.Lime;
            this.infoDisplay.Location = new System.Drawing.Point(582, 82);
            this.infoDisplay.Name = "infoDisplay";
            this.infoDisplay.Size = new System.Drawing.Size(192, 56);
            this.infoDisplay.TabIndex = 38;
            this.infoDisplay.Text = "Loading Data";
            this.infoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MikuDashMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1361, 161);
            this.ControlBox = false;
            this.Controls.Add(this.infoDisplay);
            this.Controls.Add(this.pictureCpuRam);
            this.Controls.Add(this.pictureGpuRam);
            this.Controls.Add(this.vramLbl);
            this.Controls.Add(this.pictureGpuUsage);
            this.Controls.Add(this.pictureCpuUsage);
            this.Controls.Add(this.gpuFan);
            this.Controls.Add(this.cpuFan);
            this.Controls.Add(this.gpuCLK);
            this.Controls.Add(this.cpuCLK);
            this.Controls.Add(this.ampmLbl);
            this.Controls.Add(this.clockLbl);
            this.Controls.Add(this.gpuTempLbl);
            this.Controls.Add(this.ramLbl);
            this.Controls.Add(this.gpuLbl);
            this.Controls.Add(this.cpuLbl);
            this.Controls.Add(this.cpuTempLbl);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "MikuDashMain";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MainDash";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.MikuDashMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mikuBox_MouseUp);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCpuUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGpuUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGpuRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCpuRam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cpuTempLbl;
        private System.Windows.Forms.Label cpuLbl;
        private System.Windows.Forms.Label vramLbl;
        private System.Windows.Forms.Label gpuLbl;
        private System.Windows.Forms.Label ramLbl;
        private System.Windows.Forms.Label gpuTempLbl;
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
        private System.Windows.Forms.Label cpuCLK;
        private System.Windows.Forms.Label gpuCLK;
        private System.Windows.Forms.Timer fadeInAnim;
        private System.Windows.Forms.Label gpuFan;
        private System.Windows.Forms.Label cpuFan;
        private System.Windows.Forms.PictureBox pictureCpuUsage;
        private System.Windows.Forms.PictureBox pictureGpuUsage;
        private System.Windows.Forms.PictureBox pictureGpuRam;
        private System.Windows.Forms.PictureBox pictureCpuRam;
        private System.Windows.Forms.Label infoDisplay;
    }
}

