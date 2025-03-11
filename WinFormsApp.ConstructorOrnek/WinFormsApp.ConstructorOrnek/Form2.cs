using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.ConstructorOrnek
{
    public partial class Form2 : Form
    {
        public Form2(int red, int green, int blue)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        public Form2(string Name)
        {
            InitializeComponent();
            this.BackColor =Color.FromName(Name);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
