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
    public partial class Gropupa : Form
    {
        public int SZ_X = 2, SZ_Y = 2, ForScr = 0; MyTable Mt = null;
        public ForList DluaUdalenia; public bool ThisShow = true;
        bool thisdvig = false;
        public Gropupa(MyTable t){
            InitializeComponent();
            Mt = t;
            Mt.thLish.AddStototam(this);
        }
        private void Verta_Scroll(object sender, ScrollEventArgs e)
        {
            foreach (Component ccc in this.Compot){
                ccc.SetPosme(ccc.Location.X, ccc.Skr*100-Verta.Value+25, ccc.Skr);
            }
        }
        public void AdddComp(Component c)
        {
            c.Location = new System.Drawing.Point(0, 0);
            c.Name = "ABC";
            c.Size = new System.Drawing.Size(100, 100);
            c.TabIndex = 10;
            c.SetD(this);
            Compot.Add(c);
            this.Controls.Add(c);
            GC.Collect();
        }
        private void Tuska() {
            int xx = -1, yy = 0; Verta.Value = 0;
            foreach (Component ccc in this.Compot) {
                if (xx < SZ_X-1) { xx++; } else { xx = 0; yy++; }
                ForScr = yy * 100;
                ccc.SetPosme(xx * 100, ForScr+25, yy);
            }
            if (yy < SZ_Y)
            {
                this.Verta.Enabled = false;
            }
            else {
                this.Verta.Enabled = true;
                this.Verta.Maximum = (yy-SZ_Y+1)*100;
            }
        }
        public void SetSizeMe() {
            this.Size = new Size(SZ_X*100+22,SZ_Y*100+65);
            Tuska();
        }
        private void BSL_Click(object sender, EventArgs e) { if(SZ_X>1)SZ_X--;SetSizeMe(); }
        private void BSR_Click(object sender, EventArgs e) { SZ_X++; SetSizeMe(); }
        private void BSU_Click(object sender, EventArgs e) { if (SZ_Y > 1) SZ_Y--; SetSizeMe(); }
        private void BSD_Click(object sender, EventArgs e) { SZ_Y++; SetSizeMe(); }

        public void Remo(Component l) {
            this.Compot.Remove(l);
            this.Controls.Remove(l);
            Tuska();
            GC.Collect();
        }

        public void SetAllMe(string Zg, Color Bac, Color Txt, bool v) {
            this.Zagolovok.Text = Zg;
            this.Zagolovok.ForeColor = Txt;
            this.BackColor = Bac;
            this.DluaUdalenia.NameBut.Text = Zg;
            this.DluaUdalenia.NameBut.BackColor = Bac;
            this.DluaUdalenia.NameBut.ForeColor = Txt;
            this.SetSizeMe();
            this.DluaUdalenia.OpenClose(v);
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
            Mt.thLish.Remove(DluaUdalenia);
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
