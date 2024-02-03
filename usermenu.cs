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
    public partial class usermenu : Form
    {
        user per;
        public usermenu(user u)
        {
            InitializeComponent();
            per = u;
        }

        private void usermenu_Load(object sender, EventArgs e)
        {

        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new userprofile(per);
            moreForm.ShowDialog();
        }

        private void propertybutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new userproperty(per);
            moreForm.Show();
        }

        private void materialbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new usermaterial(per);
            moreForm.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void billbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new usermaterialbill(per);
            moreForm.Show();
        }

        private void propertybillbutton_Click(object sender, EventArgs e)
        {
            Form moreForm = new userpropertybill(per);
            moreForm.Show();
        }
    }
}
