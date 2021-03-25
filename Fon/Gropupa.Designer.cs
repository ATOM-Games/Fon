using System.Collections.Generic;
using System.Drawing;
namespace Fon
{
    partial class Gropupa
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
            this.Verta = new System.Windows.Forms.VScrollBar();
            this.Pana = new System.Windows.Forms.Panel();
            this.BSD = new System.Windows.Forms.Button();
            this.BSU = new System.Windows.Forms.Button();
            this.BSR = new System.Windows.Forms.Button();
            this.BSL = new System.Windows.Forms.Button();
            this.Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.новыйКомпонентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяТаблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Zagolovok = new System.Windows.Forms.Label();
            this.Pana.SuspendLayout();
            this.Context.SuspendLayout();
            this.SuspendLayout();
            // 
            // Verta
            // 
            this.Verta.Dock = System.Windows.Forms.DockStyle.Right;
            this.Verta.Location = new System.Drawing.Point(269, 0);
            this.Verta.Name = "Verta";
            this.Verta.Size = new System.Drawing.Size(15, 261);
            this.Verta.TabIndex = 100;
            this.Verta.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Verta_Scroll);
            // 
            // Pana
            // 
            this.Pana.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pana.Controls.Add(this.BSD);
            this.Pana.Controls.Add(this.BSU);
            this.Pana.Controls.Add(this.BSR);
            this.Pana.Controls.Add(this.BSL);
            this.Pana.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pana.Location = new System.Drawing.Point(0, 236);
            this.Pana.Name = "Pana";
            this.Pana.Size = new System.Drawing.Size(269, 25);
            this.Pana.TabIndex = 100;
            // 
            // BSD
            // 
            this.BSD.Location = new System.Drawing.Point(75, 0);
            this.BSD.Name = "BSD";
            this.BSD.Size = new System.Drawing.Size(25, 25);
            this.BSD.TabIndex = 3;
            this.BSD.Text = "↓";
            this.BSD.UseVisualStyleBackColor = true;
            this.BSD.Click += new System.EventHandler(this.BSD_Click);
            // 
            // BSU
            // 
            this.BSU.Location = new System.Drawing.Point(50, 0);
            this.BSU.Name = "BSU";
            this.BSU.Size = new System.Drawing.Size(25, 25);
            this.BSU.TabIndex = 2;
            this.BSU.Text = "↑";
            this.BSU.UseVisualStyleBackColor = true;
            this.BSU.Click += new System.EventHandler(this.BSU_Click);
            // 
            // BSR
            // 
            this.BSR.Location = new System.Drawing.Point(25, 0);
            this.BSR.Name = "BSR";
            this.BSR.Size = new System.Drawing.Size(25, 25);
            this.BSR.TabIndex = 1;
            this.BSR.Text = "→";
            this.BSR.UseVisualStyleBackColor = true;
            this.BSR.Click += new System.EventHandler(this.BSR_Click);
            // 
            // BSL
            // 
            this.BSL.Location = new System.Drawing.Point(0, 0);
            this.BSL.Name = "BSL";
            this.BSL.Size = new System.Drawing.Size(25, 25);
            this.BSL.TabIndex = 0;
            this.BSL.Text = "←";
            this.BSL.UseVisualStyleBackColor = true;
            this.BSL.Click += new System.EventHandler(this.BSL_Click);
            // 
            // Context
            // 
            this.Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйКомпонентToolStripMenuItem,
            this.новаяТаблицаToolStripMenuItem,
            this.редактироватьТаблицуToolStripMenuItem,
            this.удалитьТаблицуToolStripMenuItem});
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(203, 114);
            // 
            // новыйКомпонентToolStripMenuItem
            // 
            this.новыйКомпонентToolStripMenuItem.Name = "новыйКомпонентToolStripMenuItem";
            this.новыйКомпонентToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.новыйКомпонентToolStripMenuItem.Text = "Новый компонент";
            this.новыйКомпонентToolStripMenuItem.Click += new System.EventHandler(this.новыйКомпонентToolStripMenuItem_Click);
            // 
            // новаяТаблицаToolStripMenuItem
            // 
            this.новаяТаблицаToolStripMenuItem.Name = "новаяТаблицаToolStripMenuItem";
            this.новаяТаблицаToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.новаяТаблицаToolStripMenuItem.Text = "Новая таблица";
            this.новаяТаблицаToolStripMenuItem.Click += new System.EventHandler(this.новаяТаблицаToolStripMenuItem_Click);
            // 
            // удалитьТаблицуToolStripMenuItem
            // 
            this.удалитьТаблицуToolStripMenuItem.Name = "удалитьТаблицуToolStripMenuItem";
            this.удалитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.удалитьТаблицуToolStripMenuItem.Text = "Удалить таблицу";
            this.удалитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.удалитьТаблицуToolStripMenuItem_Click);
            // 
            // редактироватьТаблицуToolStripMenuItem
            // 
            this.редактироватьТаблицуToolStripMenuItem.Name = "редактироватьТаблицуToolStripMenuItem";
            this.редактироватьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.редактироватьТаблицуToolStripMenuItem.Text = "Редактировать таблицу";
            this.редактироватьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьТаблицуToolStripMenuItem_Click);
            // 
            // Zagolovok
            // 
            this.Zagolovok.AutoEllipsis = true;
            this.Zagolovok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Zagolovok.Dock = System.Windows.Forms.DockStyle.Top;
            this.Zagolovok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zagolovok.Location = new System.Drawing.Point(0, 0);
            this.Zagolovok.Name = "Zagolovok";
            this.Zagolovok.Size = new System.Drawing.Size(269, 25);
            this.Zagolovok.TabIndex = 101;
            this.Zagolovok.Text = "A.B.C.";
            this.Zagolovok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Zagolovok.Click += new System.EventHandler(this.Zagolovok_Click_1);
            this.Zagolovok.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Zagolovok_down);
            this.Zagolovok.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Zagolovok_Click);
            this.Zagolovok.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Zagolovok_up);
            // 
            // Gropupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.Zagolovok);
            this.Controls.Add(this.Pana);
            this.Controls.Add(this.Verta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gropupa";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gropupa";
            this.Load += new System.EventHandler(this.Gropupa_Load);
            this.Pana.ResumeLayout(false);
            this.Context.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public List<Component> Compot = new List<Component>();
        private System.Windows.Forms.VScrollBar Verta;
        private System.Windows.Forms.Panel Pana;
        private System.Windows.Forms.Button BSD;
        private System.Windows.Forms.Button BSU;
        private System.Windows.Forms.Button BSR;
        private System.Windows.Forms.Button BSL;
        private System.Windows.Forms.ToolStripMenuItem новыйКомпонентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяТаблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТаблицуToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip Context;
        public System.Windows.Forms.Label Zagolovok;
        
    }
}