namespace Fon
{
    partial class AddComp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Naz = new System.Windows.Forms.TextBox();
            this.Pat = new System.Windows.Forms.TextBox();
            this.OpenFil = new System.Windows.Forms.Button();
            this.OF = new System.Windows.Forms.OpenFileDialog();
            this.OKA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название :\r\n\r\nПуть :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Naz
            // 
            this.Naz.Location = new System.Drawing.Point(108, 8);
            this.Naz.Name = "Naz";
            this.Naz.Size = new System.Drawing.Size(191, 20);
            this.Naz.TabIndex = 1;
            // 
            // Pat
            // 
            this.Pat.Location = new System.Drawing.Point(108, 40);
            this.Pat.Name = "Pat";
            this.Pat.Size = new System.Drawing.Size(191, 20);
            this.Pat.TabIndex = 2;
            // 
            // OpenFil
            // 
            this.OpenFil.Location = new System.Drawing.Point(305, 8);
            this.OpenFil.Name = "OpenFil";
            this.OpenFil.Size = new System.Drawing.Size(75, 52);
            this.OpenFil.TabIndex = 3;
            this.OpenFil.Text = "Указать путь вручную";
            this.OpenFil.UseVisualStyleBackColor = true;
            this.OpenFil.Click += new System.EventHandler(this.OpenFil_Click);
            // 
            // OF
            // 
            this.OF.FileName = "openFileDialog1";
            this.OF.FileOk += new System.ComponentModel.CancelEventHandler(this.OF_FileOk);
            // 
            // OKA
            // 
            this.OKA.Location = new System.Drawing.Point(305, 63);
            this.OKA.Name = "OKA";
            this.OKA.Size = new System.Drawing.Size(75, 23);
            this.OKA.TabIndex = 4;
            this.OKA.Text = "OK";
            this.OKA.UseVisualStyleBackColor = true;
            this.OKA.Click += new System.EventHandler(this.OKA_Click);
            // 
            // AddComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 96);
            this.Controls.Add(this.OKA);
            this.Controls.Add(this.OpenFil);
            this.Controls.Add(this.Pat);
            this.Controls.Add(this.Naz);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый компонент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Naz;
        private System.Windows.Forms.TextBox Pat;
        private System.Windows.Forms.Button OpenFil;
        private System.Windows.Forms.OpenFileDialog OF;
        private System.Windows.Forms.Button OKA;
    }
}