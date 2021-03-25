using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fon
{
    public partial class ForList : UserControl
    {
        public Gropupa thisGroup;
        public ForList(Gropupa t) {
            InitializeComponent();
            t.DluaUdalenia = this;
            this.SetMe(t);
            //OpenClose(t.Visible);
        }
        public void SetMe(Gropupa t) {
            this.thisGroup = t;
            this.NameBut.Text = this.thisGroup.Zagolovok.Text;
            this.NameBut.ForeColor = this.thisGroup.Zagolovok.ForeColor;
            this.NameBut.BackColor = this.thisGroup.BackColor;
            this.OpenClose(t.ThisShow);
        }
        public void OpenClose(bool OC) {
            this.thisGroup.Visible = OC;
            this.VizBut.Text = (OC) ? "●" : "○";
        }
        private void Naved(object sender, EventArgs A) {
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
        }
        private void Otved(object sender, EventArgs A) {
            this.BackColor = System.Drawing.SystemColors.Menu;
        }
        private void VizBut_Click(object sender, EventArgs e) { this.OpenClose(!this.thisGroup.Visible); }

        private void NameBut_Click(object sender, EventArgs e) {
            if (this.thisGroup.Visible) {
                this.thisGroup.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2 - this.thisGroup.Size.Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2 - this.thisGroup.Size.Height / 2));
                this.thisGroup.Activate();
            }
        }
    }
}
