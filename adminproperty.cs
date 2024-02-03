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
    public partial class adminproperty : Form
    {
        property pro;
        string propertypath = "property.txt";
        public adminproperty()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             property pro = (property)dataGridView1.CurrentRow.DataBoundItem;

            if (dataGridView1.Columns["Select"].Index == e.ColumnIndex)
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = propertycrud.propertylist;
            dataGridView1.Refresh();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string location = locationtxt.Text;
            string registration = registrationtxt.Text;
            string priceText = pricetxt.Text;
            double price = Convert.ToDouble(priceText);
            property p = new property(location, registration,price);
            if (location != string.Empty && registration != string.Empty && priceText != string.Empty )
            {
                if(!propertycrud.checkproperty(p))
                {
                    propertycrud.addintopropertylist(p);
                    propertycrud.storepropertyinfile(propertypath);
                    MessageBox.Show("Property Added..");
                    dataBind();
                    clear();
                }
                else
                {
                    MessageBox.Show("Property Already Present..");
                }
            }
            else
            {
                MessageBox.Show(" Any field cannot be empty ", "Error Boop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string location = locationtxt.Text;
            string registration = registrationtxt.Text;
            string priceText = pricetxt.Text;
            double price = Convert.ToDouble(priceText);
            
            if (location != string.Empty && registration != string.Empty && priceText != string.Empty)
            {
                property p = new property(location, registration, price);
                if (!propertycrud.checkproperty(p))
                {
                    propertycrud.addupdatedintopropertylist(pro,p);
                    propertycrud.storepropertyinfile(propertypath);
                    MessageBox.Show("Property Updated..");
                    dataBind();
                    clear();
                }
                else
                {
                    MessageBox.Show("Property Already Present..");
                }
            }
            else
            {
                MessageBox.Show(" Any field cannot be empty ", "Error Boop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void adminproperty_Load(object sender, EventArgs e)
        {
            dataBind();

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deletebutton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Property Deleted..");
            propertycrud.removefrompropertylist(pro);
            propertycrud.storepropertyinfile("property.txt");
            dataBind();
            clear();
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
