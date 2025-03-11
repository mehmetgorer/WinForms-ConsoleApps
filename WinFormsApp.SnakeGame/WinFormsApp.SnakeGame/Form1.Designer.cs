namespace WinFormsApp.SnakeGame
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            lblPuan = new Label();
            lblScore = new Label();
            lblBasla = new Label();
            lblKaybettiniz = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Location = new Point(88, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 600);
            panel1.TabIndex = 0;
            // 
            // lblPuan
            // 
            lblPuan.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblPuan.Location = new Point(768, 49);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(92, 37);
            lblPuan.TabIndex = 1;
            lblPuan.Text = "PUAN";
            lblPuan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.Location = new Point(768, 86);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(92, 42);
            lblScore.TabIndex = 2;
            lblScore.Text = "0";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBasla
            // 
            lblBasla.AutoSize = true;
            lblBasla.BackColor = Color.Firebrick;
            lblBasla.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBasla.Location = new Point(768, 128);
            lblBasla.Name = "lblBasla";
            lblBasla.Size = new Size(105, 33);
            lblBasla.TabIndex = 3;
            lblBasla.Text = "BAŞLA";
            lblBasla.TextAlign = ContentAlignment.MiddleCenter;
            lblBasla.Click += lblBasla_Click;
            // 
            // lblKaybettiniz
            // 
            lblKaybettiniz.AutoSize = true;
            lblKaybettiniz.BackColor = SystemColors.GradientInactiveCaption;
            lblKaybettiniz.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblKaybettiniz.ForeColor = Color.Red;
            lblKaybettiniz.Location = new Point(765, 214);
            lblKaybettiniz.Name = "lblKaybettiniz";
            lblKaybettiniz.Size = new Size(108, 33);
            lblKaybettiniz.TabIndex = 4;
            lblKaybettiniz.Text = "label4";
            lblKaybettiniz.TextAlign = ContentAlignment.MiddleCenter;
            lblKaybettiniz.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1220, 688);
            Controls.Add(lblKaybettiniz);
            Controls.Add(lblBasla);
            Controls.Add(lblScore);
            Controls.Add(lblPuan);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblPuan;
        private Label lblScore;
        private Label lblBasla;
        private Label lblKaybettiniz;
        private System.Windows.Forms.Timer timer1;
    }
}