namespace Flappy_Bird_Windows_Forms
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.BoruUst = new System.Windows.Forms.PictureBox();
			this.flappyBird = new System.Windows.Forms.PictureBox();
			this.BoruAlt = new System.Windows.Forms.PictureBox();
			this.Zemin = new System.Windows.Forms.PictureBox();
			this.scoreText = new System.Windows.Forms.Label();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.restartImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.BoruUst)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.restartImage)).BeginInit();
			this.SuspendLayout();
			// 
			// BoruUst
			// 
			this.BoruUst.Image = ((System.Drawing.Image)(resources.GetObject("BoruUst.Image")));
			this.BoruUst.Location = new System.Drawing.Point(521, 0);
			this.BoruUst.Name = "BoruUst";
			this.BoruUst.Size = new System.Drawing.Size(100, 173);
			this.BoruUst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BoruUst.TabIndex = 0;
			this.BoruUst.TabStop = false;
			// 
			// flappyBird
			// 
			this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
			this.flappyBird.Location = new System.Drawing.Point(67, 220);
			this.flappyBird.Name = "flappyBird";
			this.flappyBird.Size = new System.Drawing.Size(80, 62);
			this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.flappyBird.TabIndex = 0;
			this.flappyBird.TabStop = false;
			// 
			// BoruAlt
			// 
			this.BoruAlt.Image = ((System.Drawing.Image)(resources.GetObject("BoruAlt.Image")));
			this.BoruAlt.Location = new System.Drawing.Point(398, 375);
			this.BoruAlt.Name = "BoruAlt";
			this.BoruAlt.Size = new System.Drawing.Size(100, 168);
			this.BoruAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BoruAlt.TabIndex = 0;
			this.BoruAlt.TabStop = false;
			// 
			// Zemin
			// 
			this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
			this.Zemin.Location = new System.Drawing.Point(-3, 539);
			this.Zemin.Name = "Zemin";
			this.Zemin.Size = new System.Drawing.Size(679, 50);
			this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Zemin.TabIndex = 0;
			this.Zemin.TabStop = false;
			// 
			// scoreText
			// 
			this.scoreText.AutoSize = true;
			this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.scoreText.Location = new System.Drawing.Point(-8, 592);
			this.scoreText.Name = "scoreText";
			this.scoreText.Size = new System.Drawing.Size(110, 29);
			this.scoreText.TabIndex = 1;
			this.scoreText.Text = "Score: 0";
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
			// 
			// restartImage
			// 
			this.restartImage.Image = ((System.Drawing.Image)(resources.GetObject("restartImage.Image")));
			this.restartImage.Location = new System.Drawing.Point(-3, 0);
			this.restartImage.Name = "restartImage";
			this.restartImage.Size = new System.Drawing.Size(71, 63);
			this.restartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.restartImage.TabIndex = 2;
			this.restartImage.TabStop = false;
			this.restartImage.Click += new System.EventHandler(this.RestartClickEvent);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cyan;
			this.ClientSize = new System.Drawing.Size(673, 659);
			this.Controls.Add(this.restartImage);
			this.Controls.Add(this.flappyBird);
			this.Controls.Add(this.scoreText);
			this.Controls.Add(this.Zemin);
			this.Controls.Add(this.BoruAlt);
			this.Controls.Add(this.BoruUst);
			this.Name = "Form1";
			this.Text = "Flappy Bird";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameekeyisup);
			((System.ComponentModel.ISupportInitialize)(this.BoruUst)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BoruAlt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.restartImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox BoruUst;
		private System.Windows.Forms.PictureBox flappyBird;
		private System.Windows.Forms.PictureBox BoruAlt;
		private System.Windows.Forms.PictureBox Zemin;
		private System.Windows.Forms.Label scoreText;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.PictureBox restartImage;
	}
}

