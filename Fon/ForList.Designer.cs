namespace Fon
{
    partial class ForList
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
            this.NameBut = new System.Windows.Forms.Button();
            this.VizBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBut
            // 
            this.NameBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBut.Location = new System.Drawing.Point(1, 1);
            this.NameBut.Name = "NameBut";
            this.NameBut.Size = new System.Drawing.Size(190, 36);
            this.NameBut.TabIndex = 0;
            this.NameBut.Text = "Name";
            this.NameBut.UseVisualStyleBackColor = true;
            this.NameBut.Click += new System.EventHandler(this.NameBut_Click);
            this.NameBut.MouseEnter += new System.EventHandler(this.Naved);
            this.NameBut.MouseLeave += new System.EventHandler(this.Otved);
            // 
            // VizBut
            // 
            this.VizBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VizBut.Location = new System.Drawing.Point(191, 1);
            this.VizBut.Name = "VizBut";
            this.VizBut.Size = new System.Drawing.Size(36, 36);
            this.VizBut.TabIndex = 1;
            this.VizBut.Text = "○●";
            this.VizBut.UseVisualStyleBackColor = true;
            this.VizBut.Click += new System.EventHandler(this.VizBut_Click);
            this.VizBut.MouseEnter += new System.EventHandler(this.Naved);
            this.VizBut.MouseLeave += new System.EventHandler(this.Otved);
            // 
            // ForList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.VizBut);
            this.Controls.Add(this.NameBut);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ForList";
            this.Size = new System.Drawing.Size(228, 38);
            this.MouseEnter += new System.EventHandler(this.Naved);
            this.MouseLeave += new System.EventHandler(this.Otved);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button NameBut;
        public System.Windows.Forms.Button VizBut;

    }
}
