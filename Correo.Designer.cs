namespace Andromeda
{
    partial class Correo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correo));
            this.ImagenCorreo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCorreo)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenCorreo
            // 
            this.ImagenCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImagenCorreo.Image = ((System.Drawing.Image)(resources.GetObject("ImagenCorreo.Image")));
            this.ImagenCorreo.Location = new System.Drawing.Point(0, 0);
            this.ImagenCorreo.Name = "ImagenCorreo";
            this.ImagenCorreo.Size = new System.Drawing.Size(66, 66);
            this.ImagenCorreo.TabIndex = 0;
            this.ImagenCorreo.TabStop = false;
            // 
            // Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(66, 67);
            this.Controls.Add(this.ImagenCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Correo";
            this.Text = "Correo";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenCorreo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenCorreo;
    }
}