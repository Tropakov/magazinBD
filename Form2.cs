using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinTD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            types Win = new types();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sex Win = new sex();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            seasons Win = new seasons();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clothing Win = new clothing();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cort Win = new cort();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orders Win = new orders();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            workers Win = new workers();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            positions Win = new positions();
            Win.Owner = this;
            this.Hide();
            Win.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
