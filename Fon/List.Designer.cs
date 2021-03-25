using System.Collections.Generic;
namespace Fon
{
    partial class List
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
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.Verta = new System.Windows.Forms.VScrollBar();
            this.Suzanna = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Verta
            // 
            this.Verta.Dock = System.Windows.Forms.DockStyle.Right;
            this.Verta.Location = new System.Drawing.Point(230, 0);
            this.Verta.Name = "Verta";
            this.Verta.Size = new System.Drawing.Size(20, 400);
            this.Verta.TabIndex = 0;
            this.Verta.Visible = false;
            this.Verta.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Verta_Scroll);
            // 
            // Suzanna
            // 
            this.Suzanna.AutoSize = true;
            this.Suzanna.Location = new System.Drawing.Point(0, 0);
            this.Suzanna.Name = "Suzanna";
            this.Suzanna.Size = new System.Drawing.Size(178, 39);
            this.Suzanna.TabIndex = 1;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(250, 400);
            this.Controls.Add(this.Suzanna);
            this.Controls.Add(this.Verta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        //public Dictionary<string, ForList> Compot = new Dictionary<string, ForList>();
        public List<ForList> Compot = new List<ForList>();
        #endregion
        private System.Windows.Forms.VScrollBar Verta;
        private System.Windows.Forms.Panel Suzanna;
    }
}