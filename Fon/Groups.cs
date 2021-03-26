using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Fon
{
    public partial class Groups : Form
    {
        public int SZ_X = 2, SZ_Y = 2, ForScr = 0; MyTable Mt = null;
        public ForList For_delete; public bool ThisShow = true;
        bool thisdvig = false;
        public Groups(MyTable t){
            InitializeComponent();
            Mt = t;
            Mt.thLish.AddGroup(this);
        }
        private void Vertical_Scroll(object sender, ScrollEventArgs e)
        {
            foreach (Component comp in this.ComponentsList){
                comp.SetPosme(comp.Location.X, comp.Skr*100-Vertical_scroll.Value+25, comp.Skr);
            }
        }
        public void AddComponent(Component c)
        {
            c.Location = new System.Drawing.Point(0, 0);
            c.Name = "ABC";
            c.Size = new System.Drawing.Size(100, 100);
            c.TabIndex = 10;
            c.SetD(this);
            ComponentsList.Add(c);
            this.Controls.Add(c);
            GC.Collect();
        }
        private void Taskes() {
            int xx = -1, yy = 0; Vertical_scroll.Value = 0;
            foreach (Component comp in this.ComponentsList) {
                if (xx < SZ_X-1) { xx++; } else { xx = 0; yy++; }
                ForScr = yy * 100;
                comp.SetPosme(xx * 100, ForScr+25, yy);
            }
            if (yy < SZ_Y)
            {
                this.Vertical_scroll.Enabled = false;
            }
            else {
                this.Vertical_scroll.Enabled = true;
                this.Vertical_scroll.Maximum = (yy-SZ_Y+1)*100;
            }
        }
        public void SetSizeMe() {
            this.Size = new Size(SZ_X*100+22,SZ_Y*100+65);
            Taskes();
        }
        private void BSL_Click(object sender, EventArgs e) { if(SZ_X>1)SZ_X--;SetSizeMe(); }
        private void BSR_Click(object sender, EventArgs e) { SZ_X++; SetSizeMe(); }
        private void BSU_Click(object sender, EventArgs e) { if (SZ_Y > 1) SZ_Y--; SetSizeMe(); }
        private void BSD_Click(object sender, EventArgs e) { SZ_Y++; SetSizeMe(); }

        public void Remove_component(Component l) {
            this.ComponentsList.Remove(l);
            this.Controls.Remove(l);
            Taskes();
            GC.Collect();
        }

        public void SetAllMe(string Zg, Color Back, Color Txt, bool v) {
            this.TittleName.Text = Zg;
            this.TittleName.ForeColor = Txt;
            this.BackColor = Back;
            this.For_delete.NameBut.Text = Zg;
            this.For_delete.NameBut.BackColor = Back;
            this.For_delete.NameBut.ForeColor = Txt;
            this.SetSizeMe();
            this.For_delete.OpenClose(v);
            this.Visible = v;
        }

        private void Gropupa_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOACTIVATE = 0x0010;
        protected override void WndProc(ref Message m){
            const int WN_NCLBUTTONDOWN = 0x00A4;
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WN_NCLBUTTONDOWN:
                    {
                        Context.Show(MousePosition); return;
                    }
            }
        }

        private void новыйКомпонентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddComp ad = new AddComp(this);
            ad.Show();
        }

        private void новаяТаблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGrop GG = new AddGrop(Mt, null);
            GG.Show();
        }

        private void удалитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Mt.gr.Count > 1)
            {
                Mt.gr.Remove(this);
                this.Close();
            }
            Mt.thLish.Remove(For_delete);
        }
        private void Zagolovok_Click(object sender, EventArgs e)
        {
            if(thisdvig==true) this.Location = new Point((Cursor.Position.X - this.Size.Width / 2), (Cursor.Position.Y-10));
        }
        private void Zagolovok_down(object sender, MouseEventArgs e) { thisdvig = (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left); }
        private void Zagolovok_up(object sender, MouseEventArgs e) { thisdvig = false; }

        private void Zagolovok_Click_1(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Right) {
                this.Context.Show(this, this.PointToClient(Cursor.Position));
            }
        }

        private void редактироватьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGrop GG = new AddGrop(Mt, this);
            GG.Show();
        }
    }
}
