namespace Andromeda
{
    partial class ActivateAlarm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivateAlarm));
            this.BotonCancelarAlarma = new System.Windows.Forms.PictureBox();
            this.textoRecordatorio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCancelarAlarma)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonCancelarAlarma
            // 
            this.BotonCancelarAlarma.BackgroundImage = global::Andromeda.Properties.Resources.stopImage;
            this.BotonCancelarAlarma.Location = new System.Drawing.Point(94, 192);
            this.BotonCancelarAlarma.Name = "BotonCancelarAlarma";
            this.BotonCancelarAlarma.Size = new System.Drawing.Size(150, 150);
            this.BotonCancelarAlarma.TabIndex = 0;
            this.BotonCancelarAlarma.TabStop = false;
            this.BotonCancelarAlarma.Click += new System.EventHandler(this.BotonCancelarAlarma_Click);
            // 
            // textoRecordatorio
            // 
            this.textoRecordatorio.BackColor = System.Drawing.Color.DimGray;
            this.textoRecordatorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textoRecordatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoRecordatorio.ForeColor = System.Drawing.Color.Red;
            this.textoRecordatorio.Location = new System.Drawing.Point(13, 13);
            this.textoRecordatorio.Multiline = true;
            this.textoRecordatorio.Name = "textoRecordatorio";
            this.textoRecordatorio.ReadOnly = true;
            this.textoRecordatorio.Size = new System.Drawing.Size(326, 150);
            this.textoRecordatorio.TabIndex = 1;
            // 
            // ActivateAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(351, 342);
            this.Controls.Add(this.textoRecordatorio);
            this.Controls.Add(this.BotonCancelarAlarma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivateAlarm";
            this.Text = "ActivateAlarm";
            ((System.ComponentModel.ISupportInitialize)(this.BotonCancelarAlarma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BotonCancelarAlarma;
        private System.Windows.Forms.TextBox textoRecordatorio;
    }
}