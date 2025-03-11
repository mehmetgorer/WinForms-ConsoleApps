namespace WinFormsApp.OyunOOP
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
            btnSec = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtOyuncu = new TextBox();
            txtIrk = new TextBox();
            txtBrans = new TextBox();
            txtSilah = new TextBox();
            lblDusmanCani = new Label();
            pictureBox1 = new PictureBox();
            btnSaldir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSec
            // 
            btnSec.Location = new Point(389, 66);
            btnSec.Name = "btnSec";
            btnSec.Size = new Size(144, 61);
            btnSec.TabIndex = 0;
            btnSec.Text = "Seç";
            btnSec.UseVisualStyleBackColor = true;
            btnSec.Click += btnSec_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(100, 45);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 1;
            label1.Text = "Oyuncu İsmi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 75);
            label2.Name = "label2";
            label2.Size = new Size(28, 21);
            label2.TabIndex = 2;
            label2.Text = "Irk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 103);
            label3.Name = "label3";
            label3.Size = new Size(49, 21);
            label3.TabIndex = 3;
            label3.Text = "Brans";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(100, 134);
            label4.Name = "label4";
            label4.Size = new Size(44, 21);
            label4.TabIndex = 4;
            label4.Text = "Silah";
            // 
            // txtOyuncu
            // 
            txtOyuncu.Location = new Point(201, 42);
            txtOyuncu.Name = "txtOyuncu";
            txtOyuncu.Size = new Size(100, 23);
            txtOyuncu.TabIndex = 5;
            // 
            // txtIrk
            // 
            txtIrk.Location = new Point(201, 71);
            txtIrk.Name = "txtIrk";
            txtIrk.Size = new Size(100, 23);
            txtIrk.TabIndex = 6;
            // 
            // txtBrans
            // 
            txtBrans.Location = new Point(201, 104);
            txtBrans.Name = "txtBrans";
            txtBrans.Size = new Size(100, 23);
            txtBrans.TabIndex = 7;
            // 
            // txtSilah
            // 
            txtSilah.Location = new Point(201, 134);
            txtSilah.Name = "txtSilah";
            txtSilah.Size = new Size(100, 23);
            txtSilah.TabIndex = 8;
            // 
            // lblDusmanCani
            // 
            lblDusmanCani.BackColor = Color.FromArgb(192, 0, 0);
            lblDusmanCani.Location = new Point(721, 151);
            lblDusmanCani.Name = "lblDusmanCani";
            lblDusmanCani.Size = new Size(301, 30);
            lblDusmanCani.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lilith;
            pictureBox1.Location = new Point(721, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnSaldir
            // 
            btnSaldir.BackColor = Color.SkyBlue;
            btnSaldir.Location = new Point(388, 202);
            btnSaldir.Name = "btnSaldir";
            btnSaldir.Size = new Size(144, 61);
            btnSaldir.TabIndex = 11;
            btnSaldir.Text = "Saldır";
            btnSaldir.UseVisualStyleBackColor = false;
            btnSaldir.Click += btnSaldir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 490);
            Controls.Add(btnSaldir);
            Controls.Add(pictureBox1);
            Controls.Add(lblDusmanCani);
            Controls.Add(txtSilah);
            Controls.Add(txtBrans);
            Controls.Add(txtIrk);
            Controls.Add(txtOyuncu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSec);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSec;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtOyuncu;
        private TextBox txtIrk;
        private TextBox txtBrans;
        private TextBox txtSilah;
        private Label lblDusmanCani;
        private PictureBox pictureBox1;
        private Button btnSaldir;
    }
}