namespace Andromeda
{
    partial class CoolingMonitorInstance
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
            this.monitorOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hidPerm = new System.Windows.Forms.ToolStripMenuItem();
            this.hidFull = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // monitorOptions
            // 
            this.monitorOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.monitorOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hidPerm,
            this.hidFull});
            this.monitorOptions.Name = "monitorOptions";
            this.monitorOptions.Size = new System.Drawing.Size(250, 97);
            // 
            // hidPerm
            // 
            this.hidPerm.CheckOnClick = true;
            this.hidPerm.Name = "hidPerm";
            this.hidPerm.Size = new System.Drawing.Size(249, 30);
            this.hidPerm.Text = "Hide Permanently";
            // 
            // hidFull
            // 
            this.hidFull.CheckOnClick = true;
            this.hidFull.Name = "hidFull";
            this.hidFull.Size = new System.Drawing.Size(249, 30);
            this.hidFull.Text = "Hide on Full Screen";
            // 
            // CoolingMonitorInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "CoolingMonitorInstance";
            this.Text = "CoolingMonitor";
            this.monitorOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip monitorOptions;
        private System.Windows.Forms.ToolStripMenuItem hidPerm;
        private System.Windows.Forms.ToolStripMenuItem hidFull;
    }
}