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
    public partial class MyTable : Form
    {

        public List thLish = new List();
        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_NOACTIVATE = 0x0010;
        public List<Gropupa> gr = new List<Gropupa>();
        public MyTable(){
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - 230, Screen.PrimaryScreen.WorkingArea.Height - 35);
            widjituet();
            CloseOpne(false);
            SaveOpenXML.SOXML().OpenS(this);
        }
        private void MyTable_Load(object sender, EventArgs e) { widjituet(); }
        private void MyTable_Activated(object sender, EventArgs e) { widjituet(); }
        private void MyTable_LostFocus(object sender, EventArgs e) { widjituet(); }
        void widjituet() { SetWindowPos(Handle, HWND_BOTTOM, Screen.PrimaryScreen.WorkingArea.Width - 230, Screen.PrimaryScreen.WorkingArea.Height - 35, 340, 340, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE); }
        public void CloseOpne(bool B) {
            this.thLish.Visible = B;
            if (B) {
                UpDownBut.Text = "[ Закрыть ]";
            } else {
                UpDownBut.Text = "[ Открыть ]";
            }
        }
        private void MyTable_Deactivate(object Sender, EventArgs ee) { this.Activate(); }
        public void AllShoww() {
            if (gr.Count > 0) {
                foreach (Gropupa b in gr) { b.SetSizeMe(); b.Show(); }
            }
        }

        private void UpDownBut_Click(object sender, MouseEventArgs e)
        {
            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Right) {
                this.menua.Show(this, this.PointToClient(new Point(Cursor.Position.X - 140, Cursor.Position.Y - 50)));
            }
            if (((MouseEventArgs)e).Button == System.Windows.Forms.MouseButtons.Left) {
                this.CloseOpne(!this.thLish.Visible);
            }
        }

        private void создатьГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGrop aa = new AddGrop(this, null);
            aa.Show();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveOpenXML.SOXML().SaveO(this);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
