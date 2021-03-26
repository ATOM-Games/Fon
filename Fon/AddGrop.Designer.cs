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
            this.OK_button = new System.Windows.Forms.Button();
            this.TittleName = new System.Windows.Forms.TextBox();
            this.Color_button = new System.Windows.Forms.Button();
            this.Color_back = new System.Windows.Forms.ColorDialog();
            this.Color_text = new System.Windows.Forms.ColorDialog();
            this.Color_button_2 = new System.Windows.Forms.Button();
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
            this.OK_button.Location = new System.Drawing.Point(318, 76);
            this.OK_button.Name = "OKA";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 6;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OKA_Click);
            // 
            // Naz
            // 
            this.TittleName.Location = new System.Drawing.Point(153, 9);
            this.TittleName.Name = "Naz";
            this.TittleName.Size = new System.Drawing.Size(240, 20);
            this.TittleName.TabIndex = 5;
            // 
            // ColorBut
            // 
            this.Color_button.Location = new System.Drawing.Point(153, 39);
            this.Color_button.Name = "ColorBut";
            this.Color_button.Size = new System.Drawing.Size(112, 23);
            this.Color_button.TabIndex = 7;
            this.Color_button.UseVisualStyleBackColor = true;
            this.Color_button.Click += new System.EventHandler(this.Color_Click);
            // 
            // CvetBack
            // 
            this.Color_back.Color = System.Drawing.Color.White;
            this.Color_back.FullOpen = true;
            // 
            // CvetText
            // 
            this.Color_text.FullOpen = true;
            // 
            // ColorBut2
            // 
            this.Color_button_2.Location = new System.Drawing.Point(153, 76);
            this.Color_button_2.Name = "ColorBut2";
            this.Color_button_2.Size = new System.Drawing.Size(112, 23);
            this.Color_button_2.TabIndex = 8;
            this.Color_button_2.UseVisualStyleBackColor = true;
            this.Color_button_2.Click += new System.EventHandler(this.ColorBut2_Click);
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
            this.Controls.Add(this.Color_button_2);
            this.Controls.Add(this.Color_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.TittleName);
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
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.TextBox TittleName;
        private System.Windows.Forms.Button Color_button;
        private System.Windows.Forms.ColorDialog Color_back, Color_text;
        private System.Windows.Forms.Button Color_button_2;
        private System.Windows.Forms.Label TestText;
    }
}