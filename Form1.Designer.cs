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
            this.ampmLbl = new System.Windows.Forms.Label();
            this.clockLbl = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHide = new System.Windows.Forms.ToolStripMenuItem();
            this.toolInvalid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolClose = new System.Windows.Forms.ToolStripSeparator();
            this.viewMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolPos = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.fadeInAnim = new System.Windows.Forms.Timer(this.components);
            this.infoDisplay = new System.Windows.Forms.Label();
            this.transparencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ampmLbl
            // 
            this.ampmLbl.BackColor = System.Drawing.Color.Transparent;
            this.ampmLbl.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ampmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.ampmLbl.Location = new System.Drawing.Point(207, 35);
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
            this.clockLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(134)))), ((int)(((byte)(255)))));
            this.clockLbl.Location = new System.Drawing.Point(67, 13);
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
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolShow,
            this.toolHide,
            this.transparencyToolStripMenuItem,
            this.toolInvalid,
            this.toolClose,
            this.viewMailToolStripMenuItem,
            this.toolPos,
            this.closeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(166, 186);
            // 
            // toolShow
            // 
            this.toolShow.Name = "toolShow";
            this.toolShow.Size = new System.Drawing.Size(165, 22);
            this.toolShow.Text = "Show";
            this.toolShow.Click += new System.EventHandler(this.toolShow_Click);
            // 
            // toolHide
            // 
            this.toolHide.Name = "toolHide";
            this.toolHide.Size = new System.Drawing.Size(165, 22);
            this.toolHide.Text = "Hide";
            this.toolHide.Click += new System.EventHandler(this.toolHide_Click);
            // 
            // toolInvalid
            // 
            this.toolInvalid.Name = "toolInvalid";
            this.toolInvalid.Size = new System.Drawing.Size(165, 22);
            this.toolInvalid.Text = "Toggle Moveable";
            this.toolInvalid.Click += new System.EventHandler(this.toolInvalid_Click);
            // 
            // toolClose
            // 
            this.toolClose.Name = "toolClose";
            this.toolClose.Size = new System.Drawing.Size(162, 6);
            // 
            // viewMailToolStripMenuItem
            // 
            this.viewMailToolStripMenuItem.Name = "viewMailToolStripMenuItem";
            this.viewMailToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewMailToolStripMenuItem.Text = "Mail Settings";
            this.viewMailToolStripMenuItem.Click += new System.EventHandler(this.viewMailToolStripMenuItem_Click);
            // 
            // toolPos
            // 
            this.toolPos.Name = "toolPos";
            this.toolPos.Size = new System.Drawing.Size(165, 22);
            this.toolPos.Text = "Save Position";
            this.toolPos.Click += new System.EventHandler(this.toolPos_Click_1);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
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
            // fadeInAnim
            // 
            this.fadeInAnim.Interval = 5;
            this.fadeInAnim.Tick += new System.EventHandler(this.fadeInAnim_Tick);
            // 
            // infoDisplay
            // 
            this.infoDisplay.BackColor = System.Drawing.Color.Transparent;
            this.infoDisplay.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.infoDisplay.ForeColor = System.Drawing.Color.White;
            this.infoDisplay.Location = new System.Drawing.Point(56, 85);
            this.infoDisplay.Name = "infoDisplay";
            this.infoDisplay.Size = new System.Drawing.Size(192, 56);
            this.infoDisplay.TabIndex = 38;
            this.infoDisplay.Text = "Welcome Back!\r\n<Please Wait>";
            this.infoDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transparencyToolStripMenuItem
            // 
            this.transparencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem7,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5});
            this.transparencyToolStripMenuItem.Name = "transparencyToolStripMenuItem";
            this.transparencyToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.transparencyToolStripMenuItem.Text = "Transparency";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "20%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "40%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem4.Text = "60%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem5.Text = "80%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem6.Text = "70%";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem7.Text = "50%";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // MikuDashMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(306, 153);
            this.ControlBox = false;
            this.Controls.Add(this.infoDisplay);
            this.Controls.Add(this.ampmLbl);
            this.Controls.Add(this.clockLbl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Timer fadeInAnim;
        private System.Windows.Forms.Label infoDisplay;
        private System.Windows.Forms.ToolStripMenuItem viewMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transparencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}

