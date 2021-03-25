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
    public partial class AddGrop : Form
    {
        MyTable TTTT = null; Gropupa Red;
        public AddGrop(MyTable t, Gropupa G)
        {
            InitializeComponent();
            TTTT = t;
            if (G != null) { 
                Red = G;
                this.Text = "Редактирование группы";
                Naz.Text = G.Zagolovok.Text;
                CvetText.Color = G.Zagolovok.ForeColor;
                CvetBack.Color = G.BackColor;
            }
            ColorBut.BackColor = CvetBack.Color;
            ColorBut2.BackColor = CvetText.Color;
        }

        private void OKA_Click(object sender, EventArgs e)
        {
            ColorBut.BackColor = CvetBack.Color;
            ColorBut2.BackColor = CvetText.Color;
            if (Naz.Text.Length > 0) {
                if (Red != null) {
                    Red.SetAllMe(Naz.Text, CvetBack.Color, CvetText.Color, true);
                    this.Close();
                } else {
                    Gropupa g = new Gropupa(TTTT);
                    g.SetAllMe(Naz.Text, CvetBack.Color, CvetText.Color, true);
                    g.Show();
                    TTTT.gr.Add(g);
                    this.Close();
                }
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (CvetBack.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.TestText.BackColor = this.ColorBut.BackColor = CvetBack.Color;
            }
        }

        private void ColorBut2_Click(object sender, EventArgs e)
        {
            if (CvetText.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.TestText.ForeColor = this.ColorBut2.BackColor = CvetText.Color;
            }
        }
    }
}
