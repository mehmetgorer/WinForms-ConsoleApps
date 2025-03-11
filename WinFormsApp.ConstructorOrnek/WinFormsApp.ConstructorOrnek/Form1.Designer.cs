namespace WinFormsApp.ConstructorOrnek
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
            trcRed = new TrackBar();
            trcGreen = new TrackBar();
            trcBlue = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnBackGround = new Button();
            btnName = new Button();
            txtName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trcRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trcGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trcBlue).BeginInit();
            SuspendLayout();
            // 
            // trcRed
            // 
            trcRed.Location = new Point(91, 54);
            trcRed.Maximum = 255;
            trcRed.Name = "trcRed";
            trcRed.Size = new Size(340, 45);
            trcRed.TabIndex = 0;
            // 
            // trcGreen
            // 
            trcGreen.Location = new Point(91, 176);
            trcGreen.Maximum = 255;
            trcGreen.Name = "trcGreen";
            trcGreen.Size = new Size(340, 45);
            trcGreen.TabIndex = 0;
            // 
            // trcBlue
            // 
            trcBlue.Location = new Point(91, 309);
            trcBlue.Maximum = 255;
            trcBlue.Name = "trcBlue";
            trcBlue.Size = new Size(340, 45);
            trcBlue.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(454, 66);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 1;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 188);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 321);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "Blue";
            // 
            // btnBackGround
            // 
            btnBackGround.Location = new Point(278, 379);
            btnBackGround.Name = "btnBackGround";
            btnBackGround.Size = new Size(153, 59);
            btnBackGround.TabIndex = 2;
            btnBackGround.Text = "Form 2'nin arka plan rengini değiştir";
            btnBackGround.UseVisualStyleBackColor = true;
            btnBackGround.Click += btnBackGround_Click;
            // 
            // btnName
            // 
            btnName.Location = new Point(574, 379);
            btnName.Name = "btnName";
            btnName.Size = new Size(138, 50);
            btnName.TabIndex = 3;
            btnName.Text = "İsim ile renk değiştirme";
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += btnName_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(574, 185);
            txtName.Name = "txtName";
            txtName.Size = new Size(129, 23);
            txtName.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(btnName);
            Controls.Add(btnBackGround);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trcBlue);
            Controls.Add(trcGreen);
            Controls.Add(trcRed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trcRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trcGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trcBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trcRed;
        private TrackBar trcGreen;
        private TrackBar trcBlue;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBackGround;
        private Button btnName;
        private TextBox txtName;
    }
}