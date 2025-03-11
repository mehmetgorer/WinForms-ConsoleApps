namespace WinFormsApp.OyunOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DusmanCani = lblDusmanCani.Width;

        }
        //Instance alma
        Buyucu oyuncu1 = new Buyucu();
        int DusmanCani;

        private void btnSec_Click(object sender, EventArgs e)
        {
            oyuncu1.OyuncuIsmi = txtOyuncu.Text;
            oyuncu1.Brans = txtBrans.Text;
            oyuncu1.Irk = txtIrk.Text;
            oyuncu1.Silah = txtSilah.Text;

        }

        private void btnSaldir_Click(object sender, EventArgs e)
        {
            oyuncu1.Saldir();
            DusmanCani -= oyuncu1.SaldiriGucu;
            lblDusmanCani.Width = DusmanCani;
            MessageBox.Show($"Düþmana {oyuncu1.SaldiriGucu} kadar vurdunuz");
            if (DusmanCani <= 0)
            {
                MessageBox.Show("Düþmaný yendiniz!");
            }

        }
    }
}