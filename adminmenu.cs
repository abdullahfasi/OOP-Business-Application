using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final.DL;
using final.BL;
namespace final
{
    public partial class adminmenu : Form
    {
        person per;
        public adminmenu(person p)
        {
            InitializeComponent();
            per = p;
        }

        private void propertybutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new adminproperty();
            moreForm.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new adminmaterial();
            moreForm.Show();
        }

        private void userbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new adminuser();
            moreForm.Show();
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new adminpurchasedproperty();
            moreForm.Show();
        }

        private void purchasedmaterialbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new adminpurchasedmaterial();
            moreForm.Show();
        }
    }
}
