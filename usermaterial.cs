using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using final.DL;
using final.BL;

namespace final
{
    public partial class usermaterial : Form
    {
        user use;
        material mat;
        string materialpath = "material.txt";
        string orderedmaterialpath = "orderedmaterial.txt";
        public usermaterial(user u)
        {
            InitializeComponent();
            use = u;
        }

        private void buybutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string priceText = pricetxt.Text;
            double price = Convert.ToDouble(priceText);
            string quantityText = quantitytxt.Text;
            int quantity = Convert.ToInt32(quantityText);
            material m = new material(name, price, quantity);
            if (name != string.Empty && priceText != string.Empty && quantityText != string.Empty)
            {
                materialclass.changequantity(name,quantity);
                materialclass.storematerialinfile(materialpath);
                use.addintoorderedmateriallist(m);
                usercrud.storeorderedmaterialinfile(use, orderedmaterialpath);
                MessageBox.Show("Congratulation Yo have purchased this Material..");
                dataBind();
                clear();
            }
            else
            {
                MessageBox.Show("Material Already Present..");
            }
        }

        private void usermaterial_Load(object sender, EventArgs e)
        {
            dataBind();   
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void clear()
        {
            nametxt.Text = string.Empty;
            pricetxt.Text = string.Empty;
            quantitytxt.Text = string.Empty;
        }
        private void dataBind()
        {
            materialGV.DataSource = null;
            materialGV.DataSource = materialclass.materiallist;
            materialGV.Refresh();
        }

        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void quantitytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            material mat = (material)materialGV.CurrentRow.DataBoundItem;

            if (materialGV.Columns["Select"].Index == e.ColumnIndex)
            {
                nametxt.Text = mat.Materialname;
                pricetxt.Text = mat.Materialprice.ToString();
                quantitytxt.Text = mat.Materialquantity.ToString();
            }
            this.mat = mat;
        }
    }
}
