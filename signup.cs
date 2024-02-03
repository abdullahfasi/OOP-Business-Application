using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            if(adminradio.Checked)
            {
                Form moreForm = new signupadmin();
                moreForm.Show();
                adminradio.Checked = false;
            }
            else if (userradio.Checked)
            {
                Form moreForm = new signupuser();
                moreForm.Show();
                userradio.Checked = false;
            }
            else
            {
                MessageBox.Show(" Any field cannot be empty ", "Error Boop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
