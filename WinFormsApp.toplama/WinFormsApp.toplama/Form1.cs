namespace WinFormsApp.toplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int s2 = Convert.ToInt32(txtSayi2.Text);
            int toplam = s1 + s2;
            txtSonuc.Text = toplam.ToString();
            Temizle();


        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int s2 = Convert.ToInt32(txtSayi2.Text);
            int cikar = s1 - s2;
            txtSonuc.Text = cikar.ToString();
            Temizle();


        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int s2 = Convert.ToInt32(txtSayi2.Text);
            int carp = s1 * s2;
            txtSonuc.Text = carp.ToString();
            Temizle();

        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToInt32(txtSayi1.Text);
            double s2 = Convert.ToInt32(txtSayi2.Text);
            double bol = s1 / s2;
            txtSonuc.Text = bol.ToString();
            Temizle();


        }

        public void Temizle()
        {
            txtSayi1.Text = string.Empty;
            txtSayi2.Text = string.Empty;
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int kare =s1*s1;
            txtSonuc.Text =kare.ToString();
        }

        private void btnFaktoriyel_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(txtSayi1.Text);
            int faktoriyel = Faktoriyel(s1);
            txtSonuc.Text = faktoriyel.ToString();
        }

        private int Faktoriyel(int n)
        {
            if (n == 0)
                return 1;
            else
                return n*Faktoriyel(n-1);
        }
    }
}