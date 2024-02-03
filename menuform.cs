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
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
        }


        private void signinbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new Signin();
            moreForm.Show();
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new signup();
            moreForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close()
;        }
    }
}
