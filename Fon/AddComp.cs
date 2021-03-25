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
    public partial class AddComp : Form
    {
        Gropupa DDD = null;
        Component c = null;
        public AddComp(Gropupa g)
        {
            InitializeComponent();
            DDD=g;
        }

        private void OpenFil_Click(object sender, EventArgs e)
        {
            OF.ShowDialog();
        }

        private void OF_FileOk(object sender, CancelEventArgs e)
        {
            Pat.Text = OF.FileName;
        }

        private void OKA_Click(object sender, EventArgs e)
        {
            if (Pat.Text.Length > 0){
                if (Naz.Text.Length > 0)
                {
                    c = new Component(Naz.Text, Pat.Text, SaveOpenXML.SOXML().GetIcon(Pat.Text, true).ToBitmap());
                    DDD.AdddComp(c);
                    DDD.SetSizeMe();
                    this.Close();
                }
                else {
                    char[] N = Pat.Text.ToCharArray();
                    string O="";
                    for(int i = N.Length-1; N[i]!='\\'; O+=N[i], i--);
                    N = O.ToCharArray();
                    for (int i = N.Length - 1; i>=0; Naz.Text += N[i], i--) ;
                }
            }
        }
    }
}
