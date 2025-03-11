namespace WinFormsApp.ConstructorOrnek
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

        private void btnBackGround_Click(object sender, EventArgs e)
        {
            int Red = trcRed.Value;
            int Green = trcGreen.Value;
            int Blue = trcBlue.Value;
            Color.FromArgb(Red, Green, Blue);
            Form2 frm2 = new Form2(Red, Green, Blue);
            frm2.Show();

        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            Form2 frm2 = new Form2(Name);
            frm2.Show();

        }
    }
}