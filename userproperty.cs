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
    public partial class userproperty : Form
    {
        property pro;
        user use;
        string orderedpath = "orderedproperty.txt";
        string path = "property.txt";
        public userproperty(user u)
        {
            InitializeComponent();
            use = u;
        }

        private void buybutton_Click(object sender, EventArgs e)
        {
            string location = locationtxt.Text;
            string registration = registrationtxt.Text;
            string priceText = pricetxt.Text;
            double price = Convert.ToDouble(priceText);

            if (location != string.Empty && registration != string.Empty && priceText != string.Empty)
            {
                propertycrud.removefrompropertylist(pro);
                propertycrud.storepropertyinfile(path);
                use.addintoorderedpropertylist(pro);
                usercrud.storeorderedpropertyinfile(use, orderedpath);
                MessageBox.Show("Congratulation Yo have purchased this property..");
                dataBind();
                clear();
            }
            else
            {
                MessageBox.Show(" Any field cannot be empty ", "Error Boop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userproperty_Load(object sender, EventArgs e)
        {
            dataBind();
        }

        private void propertyGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            property pro = (property)propertyGV.CurrentRow.DataBoundItem;

            if (propertyGV.Columns["Select"].Index == e.ColumnIndex)
            {
                locationtxt.Text = pro.Locationofproperty;
                registrationtxt.Text = pro.Registration;
                pricetxt.Text = pro.Priceofproperty.ToString();
            }
            this.pro = pro;
        }
        public void clear()
        {
            locationtxt.Text = string.Empty;
            registrationtxt.Text = string.Empty;
            pricetxt.Text = string.Empty;
        }
        private void dataBind()
        {
            propertyGV.DataSource = null;
            propertyGV.DataSource = propertycrud.propertylist;
            propertyGV.Refresh();
        }

        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
