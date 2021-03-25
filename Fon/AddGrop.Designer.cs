namespace Fon
{
    partial class AddGrop
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.OKA = new System.Windows.Forms.Button();
            this.Naz = new System.Windows.Forms.TextBox();
            this.ColorBut = new System.Windows.Forms.Button();
            this.CvetBack = new System.Windows.Forms.ColorDialog();
            this.CvetText = new System.Windows.Forms.ColorDialog();
            this.ColorBut2 = new System.Windows.Forms.Button();
            this.TestText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название :\r\n\r\nЦвет :\r\n\r\nЦвет заголовка :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // OKA
            // 
            this.OKA.Location = new System.Drawing.Point(318, 76);
            this.OKA.Name = "OKA";
            this.OKA.Size = new System.Drawing.Size(75, 23);
            this.OKA.TabIndex = 6;
            this.OKA.Text = "OK";
            this.OKA.UseVisualStyleBackColor = true;
            this.OKA.Click += new System.EventHandler(this.OKA_Click);
            // 
            // Naz
            // 
            this.Naz.Location = new System.Drawing.Point(153, 9);
            this.Naz.Name = "Naz";
            this.Naz.Size = new System.Drawing.Size(240, 20);
            this.Naz.TabIndex = 5;
            // 
            // ColorBut
            // 
            this.ColorBut.Location = new System.Drawing.Point(153, 39);
            this.ColorBut.Name = "ColorBut";
            this.ColorBut.Size = new System.Drawing.Size(112, 23);
            this.ColorBut.TabIndex = 7;
            this.ColorBut.UseVisualStyleBackColor = true;
            this.ColorBut.Click += new System.EventHandler(this.Color_Click);
            // 
            // CvetBack
            // 
            this.CvetBack.Color = System.Drawing.Color.White;
            this.CvetBack.FullOpen = true;
            // 
            // CvetText
            // 
            this.CvetText.FullOpen = true;
            // 
            // ColorBut2
            // 
            this.ColorBut2.Location = new System.Drawing.Point(153, 76);
            this.ColorBut2.Name = "ColorBut2";
            this.ColorBut2.Size = new System.Drawing.Size(112, 23);
            this.ColorBut2.TabIndex = 8;
            this.ColorBut2.UseVisualStyleBackColor = true;
            this.ColorBut2.Click += new System.EventHandler(this.ColorBut2_Click);
            // 
            // TestText
            // 
            this.TestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestText.Location = new System.Drawing.Point(271, 39);
            this.TestText.Name = "TestText";
            this.TestText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TestText.Size = new System.Drawing.Size(122, 23);
            this.TestText.TabIndex = 9;
            this.TestText.Text = "A.B.C.";
            this.TestText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddGrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 107);
            this.Controls.Add(this.TestText);
            this.Controls.Add(this.ColorBut2);
            this.Controls.Add(this.ColorBut);
            this.Controls.Add(this.OKA);
            this.Controls.Add(this.Naz);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGrop";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая группа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKA;
        private System.Windows.Forms.TextBox Naz;
        private System.Windows.Forms.Button ColorBut;
        private System.Windows.Forms.ColorDialog CvetBack, CvetText;
        private System.Windows.Forms.Button ColorBut2;
        private System.Windows.Forms.Label TestText;
    }
}