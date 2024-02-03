using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final.BL;
using final.DL;

namespace final
{
    public partial class signupadmin : Form
    {
        public signupadmin()
        {
            InitializeComponent();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string password = passwordtxt.Text;
            string path = "sign.txt";
            if (name != string.Empty && password != string.Empty )
            {
                person p = new person(name, password, "Admin");
                if (!personcrud.validsignup(p))
                {
                    personcrud.addintosigninlist(p);
                    personcrud.signupfile(path);
                    MessageBox.Show("Signed Up Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" User Already Exist ", "Error Boop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(" Any field cannot be empty ", "Error Boop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            clear();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear()
        {
            nametxt.Text = string.Empty;
            passwordtxt.Text = string.Empty;
            
        }

        private void signinpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
