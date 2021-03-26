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
        Groups LocalGroup = null;
        Component c = null;
        public AddComp(Groups g)
        {
            InitializeComponent();
            LocalGroup=g;
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OF_dialog.ShowDialog();
        }

        private void OF_FileOk(object sender, CancelEventArgs e)
        {
            Pattion.Text = OF_dialog.FileName;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (Pattion.Text.Length > 0){
                if (TittleName.Text.Length > 0)
                {
                    c = new Component(TittleName.Text, Pattion.Text, SaveOpenXML.SOXML().GetIcon(Pattion.Text, true).ToBitmap());
                    LocalGroup.AddComponent(c);
                    LocalGroup.SetSizeMe();
                    this.Close();
                }
                else {
                    char[] N = Pattion.Text.ToCharArray();
                    string O="";
                    for(int i = N.Length-1; N[i]!='\\'; O+=N[i], i--);
                    N = O.ToCharArray();
                    for (int i = N.Length - 1; i>=0; TittleName.Text += N[i], i--) ;
                }
            }
        }
    }
}
