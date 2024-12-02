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
            insert_btn = new Button();
            edit_btn = new Button();
            delete_btn = new Button();
            dataGridView1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // insert_btn
            // 
            insert_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insert_btn.Location = new Point(12, 213);
            insert_btn.Name = "insert_btn";
            insert_btn.Size = new Size(100, 32);
            insert_btn.TabIndex = 7;
            insert_btn.Text = "Insert";
            insert_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            edit_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit_btn.Location = new Point(244, 213);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(100, 32);
            edit_btn.TabIndex = 8;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            delete_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_btn.Location = new Point(489, 213);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(100, 32);
            delete_btn.TabIndex = 9;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 264);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(577, 174);
            dataGridView1.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLight;
            richTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(436, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(153, 175);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "ID Departemen : \nHR : HR\nENG : Engineer\nDEV : developer\nPM : Product M\nFIN : Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 450);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(delete_btn);
            Controls.Add(edit_btn);
            Controls.Add(insert_btn);
            Controls.Add(dep_karyawan_combobox);
            Controls.Add(nama_karyawan_textbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_logo);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button insert_btn;
        private Button edit_btn;
        private Button delete_btn;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
    }
}
