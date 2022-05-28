
namespace ExercisePABD
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prodiTIDataSet = new ExercisePABD.ProdiTIDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new ExercisePABD.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "PhoneMhs", true));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(210, 224);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(262, 15);
            this.textBox6.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Sex", true));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(210, 188);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(262, 15);
            this.textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "AlamatMhs", true));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(210, 149);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(262, 15);
            this.textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NamaMhs", true));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(210, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 15);
            this.textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(210, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 15);
            this.textBox2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(20, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "No. Telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(20, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(20, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Alamat Mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "No. Mahasiswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Data Mahasiswa";
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ExercisePABD.Properties.Resources.previous;
            this.pictureBox1.Location = new System.Drawing.Point(23, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(522, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise PABD";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
    }
}