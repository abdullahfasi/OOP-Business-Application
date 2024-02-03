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
    public partial class signupuser : Form
    {
        public signupuser()
        {
            InitializeComponent();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string password = passwordtxt.Text;
            string phonenumber = numbertext.Text;
            string path = "sign.txt";
            if (name != string.Empty && password != string.Empty)
            {
                user p = new user(name, password, "User" ,phonenumber);
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

        private void numbertext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void clear()
        {
            nametxt.Text = string.Empty;
            passwordtxt.Text = string.Empty;
            numbertext.Text = string.Empty;
        }
    }
}
