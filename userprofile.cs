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
    public partial class userprofile : Form
    {
        user use;
        string path = "sign.txt";
        public userprofile(user c)
        {
            InitializeComponent();
            use = c;

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string password = passwordtxt.Text;
            string role = roletxt.Text;
            string number = numbertxt.Text;
            if(name != string.Empty && password != string.Empty && role != string.Empty && number != string.Empty)
            {
                user u = new user(name, password, role, number);
                if(!personcrud.validsignup(u))
                {
                    personcrud.updateuser(use, u);
                    personcrud.signupfile(path);
                    MessageBox.Show("Attributes Updated..");
                    dataBind();
                    clear();
                }
                else
                {
                    MessageBox.Show("Material Already Present..");
                }
            }
            else
            {
                MessageBox.Show(" Any field cannot be empty ", "Error Boop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have deleted your account..");
            personcrud.deleteuserfromlist(use);
            personcrud.signupfile(path);
            clear();
            this.Close();
            Form moreForm = new menuform();
            moreForm.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profileGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            user use = (user)profileGV.CurrentRow.DataBoundItem;
            if(profileGV.Columns["Select"].Index == e.ColumnIndex)
            {
                nametxt.Text = use.Name;
                passwordtxt.Text = use.Password;
                roletxt.Text = use.Role;
                numbertxt.Text = use.Number;
            }
            this.use = use;
        }
        public void clear()
        {
            nametxt.Text = string.Empty;
            passwordtxt.Text = string.Empty;
            roletxt.Text = string.Empty;
            numbertxt.Text = string.Empty;
        }
        private void dataBind()
        {
            List<user> users = new List<user>();
            users.Add(use);
            profileGV.DataSource = null;
            profileGV.DataSource = users;
            profileGV.Refresh();
        }

        private void userprofile_Load(object sender, EventArgs e)
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
