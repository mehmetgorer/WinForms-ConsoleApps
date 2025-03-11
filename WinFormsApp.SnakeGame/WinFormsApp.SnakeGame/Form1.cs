namespace WinFormsApp.SnakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel parca;
        Panel elma = new Panel();
        List<Panel> yilan = new List<Panel>();

        string yon = "sað";

        private void lblBasla_Click(object sender, EventArgs e)
        {
            lblScore.Text = "0";
            Temizle();

            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(20, 20);
            parca.BackColor = Color.Black;
            yilan.Add(parca);
            panel1.Controls.Add(yilan[0]);

            timer1.Start();
            elmaOlustur();
        }

        void kendineCarpma()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    lblKaybettiniz.Visible = true;
                    lblKaybettiniz.Text = "Kaybettiniz!";
                    timer1.Stop();
                }
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = yilan[0].Location.X;
            int locY = yilan[0].Location.Y;

            elmaYedimmi();
            uzayanKuyruk();
            kendineCarpma();
            puanKontrol();

            if (yon == "sað")
            {
                if (locX < 580)
                    locX += 20;
                else
                    locX = 0;
            }
            if (yon == "sol")
            {
                if (locX > 0)
                    locX -= 20;
                else
                    locX = 580;
            }
            if (yon == "aþaðý")
            {
                if (locY < 580)
                    locY += 20;
                else
                    locY = 0;
            }
            if (yon == "yukarý")
            {
                if (locY > 0)
                    locY -= 20;
                else
                    locY = 580;
            }

            yilan[0].Location = new Point(locX, locY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && yon !="sol")
                yon = "sað";
            if (e.KeyCode == Keys.Left && yon != "sað")
                yon = "sol";
            if (e.KeyCode == Keys.Down && yon != "yukarý")
                yon = "aþaðý";
            if (e.KeyCode == Keys.Up && yon != "aþaðý")
                yon = "yukarý";

        }

        void elmaOlustur()
        {
            Random rnd = new Random();
            int elmaX, elmaY;
            elmaX = rnd.Next(580);
            elmaY = rnd.Next(580);

            elmaX -= elmaX % 20;
            elmaY -= elmaY % 20;

            elma.Size = new Size(20, 20);
            elma.BackColor = Color.Red;
            elma.Location = new Point(elmaX, elmaY);
            panel1.Controls.Add(elma);

        }

        void elmaYedimmi()
        {
            int puan = int.Parse(lblScore.Text);



            if (yilan[0].Location == elma.Location)
            {
                panel1.Controls.Remove(elma);
                puan += 50;
                lblScore.Text = puan.ToString();
                elmaOlustur();
                parcaEkle();
            }

            void parcaEkle()
            {
                Panel eklenenParca = new Panel();
                eklenenParca.Size = new Size(20, 20);
                eklenenParca.BackColor = Color.Black;
                yilan.Add(eklenenParca);
                panel1.Controls.Add(eklenenParca);
            }



        }
        void uzayanKuyruk()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
            {
                yilan[i].Location = yilan[i - 1].Location;
            }
        }

        void Temizle()
        {
            panel1.Controls.Clear();
            yilan.Clear();
            lblKaybettiniz.Visible = false;

        }

        void puanKontrol()
        {
            int puan = int.Parse(lblScore.Text);
            if (puan > 500) 
            {
                lblKaybettiniz.Text = "Kazandýnýz!";
                lblKaybettiniz.Visible = true;
                timer1.Stop();

            }
        }
    }
}