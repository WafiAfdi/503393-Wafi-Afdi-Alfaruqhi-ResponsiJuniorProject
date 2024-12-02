namespace Proyek_Responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label_logo = new Label();
            label1 = new Label();
            label2 = new Label();
            nama_karyawan_textbox = new TextBox();
            dep_karyawan_combobox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 86);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label_logo
            // 
            label_logo.AutoSize = true;
            label_logo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_logo.Location = new Point(118, 42);
            label_logo.Name = "label_logo";
            label_logo.Size = new Size(45, 21);
            label_logo.TabIndex = 1;
            label_logo.Text = "Logo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 2;
            label1.Text = "Nama Karyawan : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 3;
            label2.Text = "Dep. Karyawan : ";
            // 
            // nama_karyawan_textbox
            // 
            nama_karyawan_textbox.Location = new Point(153, 128);
            nama_karyawan_textbox.Name = "nama_karyawan_textbox";
            nama_karyawan_textbox.Size = new Size(121, 23);
            nama_karyawan_textbox.TabIndex = 4;
            // 
            // dep_karyawan_combobox
            // 
            dep_karyawan_combobox.FormattingEnabled = true;
            dep_karyawan_combobox.Location = new Point(153, 168);
            dep_karyawan_combobox.Name = "dep_karyawan_combobox";
            dep_karyawan_combobox.Size = new Size(121, 23);
            dep_karyawan_combobox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(dep_karyawan_combobox);
            Controls.Add(nama_karyawan_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_logo);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label_logo;
        private Label label1;
        private Label label2;
        private TextBox nama_karyawan_textbox;
        private ComboBox dep_karyawan_combobox;
    }
}
