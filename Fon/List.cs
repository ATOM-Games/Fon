using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fon
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width-250, Screen.PrimaryScreen.WorkingArea.Height-450);
        }

        public void AddGroup(Groups g) {
            this.VerticalScroll.Value = 0;
            ForList for_local = new ForList(g);
            this.Compot.Add(for_local);
            this.BackGround.Controls.Add(for_local);
            Correct();
        }
        public void Remove(ForList t) {
            this.VerticalScroll.Value = 0;
            this.Compot.Remove(t);
            this.BackGround.Controls.Remove(t);
            Correct();
        }
        public void Correct() {
            int y=0;
            foreach (ForList f in this.Compot) {
                f.Location = new System.Drawing.Point(0, 35 * y);
                y++;
            }
            if (35 * this.Compot.Count >= 400) {
                this.VerticalScroll.Maximum = (35 * this.Compot.Count - 400);
                this.VerticalScroll.Enabled = true;
            } else {
                this.VerticalScroll.Enabled = false;
            }
        }
        private void Verta_Scroll(object sender, ScrollEventArgs e)
        {
            foreach (ForList for_local in this.Compot)
            {
                for_local.Location = new Point(0, for_local.Location.X+this.VerticalScroll.Value);//  .SetPosme(0,  + this.Verta.Value);
            }
        }
    }
}
