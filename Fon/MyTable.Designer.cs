using System.Collections.Generic;
namespace Fon
{
    partial class MyTable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTable));
            this.UpDownBut = new System.Windows.Forms.Button();
            this.menua = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menua.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpDownBut
            // 
            this.UpDownBut.Location = new System.Drawing.Point(0, 0);
            this.UpDownBut.Name = "UpDownBut";
            this.UpDownBut.Size = new System.Drawing.Size(230, 35);
            this.UpDownBut.TabIndex = 0;
            this.UpDownBut.Text = "Open";
            this.UpDownBut.UseVisualStyleBackColor = true;
            this.UpDownBut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpDownBut_Click);
            // 
            // menua
            // 
            this.menua.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьГруппуToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menua.Name = "menua";
            this.menua.Size = new System.Drawing.Size(159, 92);
            // 
            // создатьГруппуToolStripMenuItem
            // 
            this.создатьГруппуToolStripMenuItem.Name = "создатьГруппуToolStripMenuItem";
            this.создатьГруппуToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.создатьГруппуToolStripMenuItem.Text = "Создать группу";
            this.создатьГруппуToolStripMenuItem.Click += new System.EventHandler(this.создатьГруппуToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 35);
            this.Controls.Add(this.UpDownBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyTable";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MyTable";
            this.Activated += new System.EventHandler(this.MyTable_Activated);
            this.Load += new System.EventHandler(this.MyTable_Load);
            this.LostFocus += new System.EventHandler(this.MyTable_LostFocus);
            this.menua.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        public List<System.Windows.Forms.Button> ListButGrop = new List<System.Windows.Forms.Button>();
        public List<System.Windows.Forms.Button> ListButComp = new List<System.Windows.Forms.Button>();
        private System.Windows.Forms.Button UpDownBut;
        private System.Windows.Forms.ContextMenuStrip menua;
        private System.Windows.Forms.ToolStripMenuItem создатьГруппуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;

    }
}