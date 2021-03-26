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
    public partial class Component : UserControl
    {
        public string Path; public int Skr; Groups G=null;
        public Component(string n, string p, Bitmap b) { InitializeComponent(); this.TittleName.Text = n; Path = p; PictureBox_1.Image = b; }
        private void Component_MouseHover(object sender, EventArgs ee) { this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; }
        private void Component_MouseLeave(object sender, EventArgs ee) { this.BorderStyle = System.Windows.Forms.BorderStyle.None; }
        private void Component_MouseDoubleClick(object sender, MouseEventArgs ee) {
            try { System.Diagnostics.Process.Start(Path); }
            catch (Exception Se) { MessageBox.Show("Но с файлом или папкой что-то не так...", "УВЫ!"); }
            GC.Collect();
        }
        public void SetPosme(int x, int y, int ids) { this.Location = new Point(x, y); Skr = ids; }

        private void Kontext_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void Move_window(object sender, MouseEventArgs w) {
            if (this.PointToClient(Cursor.Position).X > this.Location.X && this.PointToClient(Cursor.Position).X < this.Location.X + 100 &&
                this.PointToClient(Cursor.Position).Y > this.Location.Y && this.PointToClient(Cursor.Position).Y < this.Location.Y + 100)
            {
                this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            } else {
                this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        private void Picture_MouseDown(object sender, MouseEventArgs w){
            
        }
        public void SetD(Groups h) { this.G = h; }
        private void Exit_Click(object sender, EventArgs e) { if (G != null) G.Remove_component(this); }
    }
}
