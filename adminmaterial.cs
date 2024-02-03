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
    public partial class adminmaterial : Form
    {
        material mat;
        string materialpath = "material.txt";
        public adminmaterial()
        {
            InitializeComponent();
        }

        private void materialGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void adminmaterial_Load(object sender, EventArgs e)
        {
            dataBind();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string priceText = pricetxt.Text;
            double price = Convert.ToDouble(priceText);
            string quantityText = quantitytxt.Text;
            int quantity = Convert.ToInt32(quantityText);

            material m = new material(name, price ,quantity);
            if (name != string.Empty && priceText != string.Empty && quantityText != string.Empty)
            {
                if (!materialclass.checkmaterial(m))
                {
                    materialclass.addintomateriallist(m);
                    materialclass.storematerialinfile(materialpath);
                    MessageBox.Show("Material Added..");
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

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string priceText = pricetxt.Text;
            double price = Convert.ToDouble(priceText);
            string quantityText = quantitytxt.Text;
            int quantity = Convert.ToInt32(quantityText);

            if (name != string.Empty && priceText != string.Empty && quantityText != string.Empty)
            {
                material m = new material(name,price,quantity);
                if (!materialclass.checkmaterial(m))
                {
                    materialclass.addupdatedintomateriallist(mat, m);
                    materialclass.storematerialinfile(materialpath);
                    MessageBox.Show("Material Updated..");
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
            MessageBox.Show("Material Deleted..");
            materialclass.removefrommateriallist(mat);
            materialclass.storematerialinfile(materialpath);
            dataBind();
            clear();
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
    }
}
