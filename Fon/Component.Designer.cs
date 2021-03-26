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
            this.TittleName = new System.Windows.Forms.Label();
            this.Exit_Img = new System.Windows.Forms.PictureBox();
            this.PictureBox_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nane
            // 
            this.TittleName.AutoSize = true;
            this.TittleName.Location = new System.Drawing.Point(1, 83);
            this.TittleName.MaximumSize = new System.Drawing.Size(95, 0);
            this.TittleName.MinimumSize = new System.Drawing.Size(95, 0);
            this.TittleName.Name = "Nane";
            this.TittleName.Size = new System.Drawing.Size(95, 13);
            this.TittleName.TabIndex = 1;
            this.TittleName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TittleName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDoubleClick);
            this.TittleName.MouseEnter += new System.EventHandler(this.Component_MouseHover);
            this.TittleName.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // ExitImg
            // 
            this.Exit_Img.Image = ((System.Drawing.Image)(resources.GetObject("ExitImg.Image")));
            this.Exit_Img.Location = new System.Drawing.Point(80, 0);
            this.Exit_Img.Name = "ExitImg";
            this.Exit_Img.Size = new System.Drawing.Size(20, 20);
            this.Exit_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit_Img.TabIndex = 3;
            this.Exit_Img.TabStop = false;
            this.Exit_Img.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Pica
            // 
            this.PictureBox_1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox_1.Location = new System.Drawing.Point(24, 9);
            this.PictureBox_1.Name = "Pica";
            this.PictureBox_1.Size = new System.Drawing.Size(50, 50);
            this.PictureBox_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_1.TabIndex = 0;
            this.PictureBox_1.TabStop = false;
            this.PictureBox_1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDoubleClick);
            this.PictureBox_1.MouseEnter += new System.EventHandler(this.Component_MouseHover);
            this.PictureBox_1.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Exit_Img);
            this.Controls.Add(this.TittleName);
            this.Controls.Add(this.PictureBox_1);
            this.Name = "Component";
            this.Size = new System.Drawing.Size(100, 100);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseDoubleClick);
            this.MouseEnter += new System.EventHandler(this.Component_MouseHover);
            this.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Exit_Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_1;
        private System.Windows.Forms.PictureBox Exit_Img;
        public System.Windows.Forms.Label TittleName;
    }
}
