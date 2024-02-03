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
    public partial class adminuser : Form
    {
        user use;
        string userpath = "sign.txt";
        public adminuser()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string password = passwordtxt.Text;
            string phonenumber = numbertxt.Text;
            if (name != string.Empty && password != string.Empty)
            {
                user p = new user(name, password, "User", phonenumber);
                if (!personcrud.validsignup(p))
                {
                    personcrud.addintosigninlist(p);
                    personcrud.signupfile(userpath);
                    MessageBox.Show("user Added  Successfully");
                    dataBind();
                    clear();
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
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("user Deletd ");
            personcrud.deleteuserfromlist(use);
            personcrud.signupfile(userpath);
            dataBind();
            clear();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            user use = (user)userGV.CurrentRow.DataBoundItem;
            if(userGV.Columns["Select"].Index == e.ColumnIndex)
            {
                nametxt.Text = use.Name;
                passwordtxt.Text = use.Password;
                numbertxt.Text = use.Number;
            }
            this.use = use;
        }
        public void clear()
        {
            nametxt.Text = string.Empty;
            passwordtxt.Text = string.Empty;
            numbertxt.Text = string.Empty;
        }
        private void dataBind()
        {
            userGV.DataSource = null;
            userGV.DataSource = personcrud.signinlist;
            userGV.Refresh();
        }

        private void adminuser_Load(object sender, EventArgs e)
        {
            dataBind();
        }

        private void numbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
