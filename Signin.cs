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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string password = passwordtxt.Text;
            if (name != string.Empty && password != string.Empty)
            {
                person per = new person(name, password);
                person p = personcrud.signIn(per);
                if(p.getrole() == "Admin" )
                {
                    Form moreForm = new adminmenu(p);
                    moreForm.Show();
                }
                else if(p.getrole() == "User")
                {
                    Form moreForm = new usermenu((user)p);
                    moreForm.Show();
                }
                else
                {
                    MessageBox.Show("Not Signed Up..  ");
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

        private void namebutton_Click(object sender, EventArgs e)
        {

        }

        private void Signin_Load(object sender, EventArgs e)
        {
        }
        public void clear()
        {
            nametxt.Text = string.Empty;
            passwordtxt.Text = string.Empty;
        }
    }
}
