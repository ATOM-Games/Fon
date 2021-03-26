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
            this.TittleName = new System.Windows.Forms.TextBox();
            this.Pattion = new System.Windows.Forms.TextBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.OF_dialog = new System.Windows.Forms.OpenFileDialog();
            this.OK_button = new System.Windows.Forms.Button();
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
            this.TittleName.Location = new System.Drawing.Point(108, 8);
            this.TittleName.Name = "Naz";
            this.TittleName.Size = new System.Drawing.Size(191, 20);
            this.TittleName.TabIndex = 1;
            // 
            // Pat
            // 
            this.Pattion.Location = new System.Drawing.Point(108, 40);
            this.Pattion.Name = "Pat";
            this.Pattion.Size = new System.Drawing.Size(191, 20);
            this.Pattion.TabIndex = 2;
            // 
            // OpenFil
            // 
            this.OpenFile.Location = new System.Drawing.Point(305, 8);
            this.OpenFile.Name = "OpenFil";
            this.OpenFile.Size = new System.Drawing.Size(75, 52);
            this.OpenFile.TabIndex = 3;
            this.OpenFile.Text = "Указать путь вручную";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // OF
            // 
            this.OF_dialog.FileName = "openFileDialog1";
            this.OF_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OF_FileOk);
            // 
            // OKA
            // 
            this.OK_button.Location = new System.Drawing.Point(305, 63);
            this.OK_button.Name = "OKA";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_Click);
            // 
            // AddComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 96);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.Pattion);
            this.Controls.Add(this.TittleName);
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
        private System.Windows.Forms.TextBox TittleName;
        private System.Windows.Forms.TextBox Pattion;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog OF_dialog;
        private System.Windows.Forms.Button OK_button;
    }
}