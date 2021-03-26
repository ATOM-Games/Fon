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
        MyTable Local_table = null; Groups Red;
        public AddGrop(MyTable t, Groups G)
        {
            InitializeComponent();
            Local_table = t;
            if (G != null) { 
                Red = G;
                this.Text = "Редактирование группы";
                TittleName.Text = G.TittleName.Text;
                Color_text.Color = G.TittleName.ForeColor;
                Color_back.Color = G.BackColor;
            }
            Color_button.BackColor = Color_back.Color;
            Color_button_2.BackColor = Color_text.Color;
        }

        private void OKA_Click(object sender, EventArgs e)
        {
            Color_button.BackColor = Color_back.Color;
            Color_button_2.BackColor = Color_text.Color;
            if (TittleName.Text.Length > 0) {
                if (Red != null) {
                    Red.SetAllMe(TittleName.Text, Color_back.Color, Color_text.Color, true);
                    this.Close();
                } else {
                    Groups g = new Groups(Local_table);
                    g.SetAllMe(TittleName.Text, Color_back.Color, Color_text.Color, true);
                    g.Show();
                    Local_table.gr.Add(g);
                    this.Close();
                }
            }
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if (Color_back.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.TestText.BackColor = this.Color_button.BackColor = Color_back.Color;
            }
        }

        private void ColorBut2_Click(object sender, EventArgs e)
        {
            if (Color_text.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.TestText.ForeColor = this.Color_button_2.BackColor = Color_text.Color;
            }
        }
    }
}
