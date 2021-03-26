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
            this.VerticalScroll = new System.Windows.Forms.VScrollBar();
            this.BackGround = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Verta
            // 
            this.VerticalScroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.VerticalScroll.Location = new System.Drawing.Point(230, 0);
            this.VerticalScroll.Name = "Verta";
            this.VerticalScroll.Size = new System.Drawing.Size(20, 400);
            this.VerticalScroll.TabIndex = 0;
            this.VerticalScroll.Visible = false;
            this.VerticalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Verta_Scroll);
            // 
            // Suzanna
            // 
            this.BackGround.AutoSize = true;
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Name = "Suzanna";
            this.BackGround.Size = new System.Drawing.Size(178, 39);
            this.BackGround.TabIndex = 1;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(250, 400);
            this.Controls.Add(this.BackGround);
            this.Controls.Add(this.VerticalScroll);
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
        private System.Windows.Forms.VScrollBar VerticalScroll;
        private System.Windows.Forms.Panel BackGround;
    }
}