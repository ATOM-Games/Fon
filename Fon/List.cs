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

        public void AddStototam(Gropupa g) {
            this.Verta.Value = 0;
            ForList Nw = new ForList(g);
            this.Compot.Add(Nw);
            this.Suzanna.Controls.Add(Nw);
            Correct();
        }
        public void Remove(ForList t) {
            this.Verta.Value = 0;
            this.Compot.Remove(t);
            this.Suzanna.Controls.Remove(t);
            Correct();
        }
        public void Correct() {
            int y=0;
            foreach (ForList f in this.Compot) {
                f.Location = new System.Drawing.Point(0, 35 * y);
                y++;
            }
            if (35 * this.Compot.Count >= 400) {
                this.Verta.Maximum = (35 * this.Compot.Count - 400);
                this.Verta.Enabled = true;
            } else {
                this.Verta.Enabled = false;
            }
        }
        private void Verta_Scroll(object sender, ScrollEventArgs e)
        {
            foreach (ForList ccc in this.Compot)
            {
                ccc.Location = new Point(0, ccc.Location.X+this.Verta.Value);//  .SetPosme(0,  + this.Verta.Value);
            }
        }
    }
}
