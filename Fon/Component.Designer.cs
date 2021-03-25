using System.Drawing;
namespace Fon
{
    partial class Component
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Component Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Component));
            this.Nane = new System.Windows.Forms.Label();
            this.ExitImg = new System.Windows.Forms.PictureBox();
            this.Pica = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pica)).BeginInit();
            this.SuspendLayout();
            // 
            // Nane
            // 
            this.Nane.AutoSize = true;
            this.Nane.Location = new System.Drawing.Point(1, 83);
            this.Nane.MaximumSize = new System.Drawing.Size(95, 0);
            this.Nane.MinimumSize = new System.Drawing.Size(95, 0);
            this.Nane.Name = "Nane";
            this.Nane.Size = new System.Drawing.Size(95, 13);
            this.Nane.TabIndex = 1;
            this.Nane.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nane.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDoubleClick);
            this.Nane.MouseEnter += new System.EventHandler(this.Component_MouseHover);
            this.Nane.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // ExitImg
            // 
            this.ExitImg.Image = ((System.Drawing.Image)(resources.GetObject("ExitImg.Image")));
            this.ExitImg.Location = new System.Drawing.Point(80, 0);
            this.ExitImg.Name = "ExitImg";
            this.ExitImg.Size = new System.Drawing.Size(20, 20);
            this.ExitImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitImg.TabIndex = 3;
            this.ExitImg.TabStop = false;
            this.ExitImg.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Pica
            // 
            this.Pica.BackColor = System.Drawing.Color.Transparent;
            this.Pica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pica.Location = new System.Drawing.Point(24, 9);
            this.Pica.Name = "Pica";
            this.Pica.Size = new System.Drawing.Size(50, 50);
            this.Pica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pica.TabIndex = 0;
            this.Pica.TabStop = false;
            this.Pica.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDoubleClick);
            this.Pica.MouseEnter += new System.EventHandler(this.Component_MouseHover);
            this.Pica.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ExitImg);
            this.Controls.Add(this.Nane);
            this.Controls.Add(this.Pica);
            this.Name = "Component";
            this.Size = new System.Drawing.Size(100, 100);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDoubleClick);
            this.MouseEnter += new System.EventHandler(this.Component_MouseHover);
            this.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ExitImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pica;
        private System.Windows.Forms.PictureBox ExitImg;
        public System.Windows.Forms.Label Nane;
    }
}
