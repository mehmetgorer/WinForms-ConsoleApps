namespace WinFormsApp.toplama
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
            label1 = new Label();
            label2 = new Label();
            btnTopla = new Button();
            txtSonuc = new TextBox();
            txtSayi1 = new TextBox();
            txtSayi2 = new TextBox();
            btnCikar = new Button();
            btnCarp = new Button();
            btnBol = new Button();
            label3 = new Label();
            btnFaktoriyel = new Button();
            btnKare = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 71);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "1.sayı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 123);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "2. sayı";
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(350, 159);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(75, 23);
            btnTopla.TabIndex = 2;
            btnTopla.Text = "topla";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // txtSonuc
            // 
            txtSonuc.Location = new Point(340, 279);
            txtSonuc.Name = "txtSonuc";
            txtSonuc.Size = new Size(100, 23);
            txtSonuc.TabIndex = 3;
            // 
            // txtSayi1
            // 
            txtSayi1.Location = new Point(340, 73);
            txtSayi1.Name = "txtSayi1";
            txtSayi1.Size = new Size(100, 23);
            txtSayi1.TabIndex = 4;
            // 
            // txtSayi2
            // 
            txtSayi2.Location = new Point(340, 115);
            txtSayi2.Name = "txtSayi2";
            txtSayi2.Size = new Size(100, 23);
            txtSayi2.TabIndex = 4;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(465, 159);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(75, 23);
            btnCikar.TabIndex = 2;
            btnCikar.Text = "çıkar";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnCarp
            // 
            btnCarp.Location = new Point(574, 159);
            btnCarp.Name = "btnCarp";
            btnCarp.Size = new Size(75, 23);
            btnCarp.TabIndex = 2;
            btnCarp.Text = "çarp";
            btnCarp.UseVisualStyleBackColor = true;
            btnCarp.Click += btnCarp_Click;
            // 
            // btnBol
            // 
            btnBol.Location = new Point(674, 159);
            btnBol.Name = "btnBol";
            btnBol.Size = new Size(75, 23);
            btnBol.TabIndex = 2;
            btnBol.Text = "böl";
            btnBol.UseVisualStyleBackColor = true;
            btnBol.Click += btnBol_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 287);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Sonuç";
            // 
            // btnFaktoriyel
            // 
            btnFaktoriyel.Location = new Point(480, 73);
            btnFaktoriyel.Name = "btnFaktoriyel";
            btnFaktoriyel.Size = new Size(75, 38);
            btnFaktoriyel.TabIndex = 6;
            btnFaktoriyel.Text = "faktöriyel al";
            btnFaktoriyel.UseVisualStyleBackColor = true;
            btnFaktoriyel.Click += btnFaktoriyel_Click;
            // 
            // btnKare
            // 
            btnKare.Location = new Point(591, 72);
            btnKare.Name = "btnKare";
            btnKare.Size = new Size(75, 39);
            btnKare.TabIndex = 7;
            btnKare.Text = "karesini al";
            btnKare.UseVisualStyleBackColor = true;
            btnKare.Click += btnKare_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKare);
            Controls.Add(btnFaktoriyel);
            Controls.Add(label3);
            Controls.Add(txtSayi2);
            Controls.Add(txtSayi1);
            Controls.Add(txtSonuc);
            Controls.Add(btnBol);
            Controls.Add(btnCarp);
            Controls.Add(btnCikar);
            Controls.Add(btnTopla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnTopla;
        private TextBox txtSonuc;
        private TextBox txtSayi1;
        private TextBox txtSayi2;
        private Button btnCikar;
        private Button btnCarp;
        private Button btnBol;
        private Label label3;
        private Button btnFaktoriyel;
        private Button btnKare;
    }
}