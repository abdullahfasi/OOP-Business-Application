using final.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class userpropertybill : Form
    {
        DataTable data = new DataTable();
        user u;
        public userpropertybill(user p)
        {
            InitializeComponent();
            u = p;
            data.Columns.Add("Location", typeof(string));
            data.Columns.Add("Registration Number", typeof(string));
            data.Columns.Add("Pice", typeof(double));
            data.Columns.Add("Bill", typeof(double));
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            foreach (var item in u.getpropertylist())
            {
                string name = item.Locationofproperty;
                string registration = item.Registration;
                double price = item.Priceofproperty;
                double bill = price ;
                data.Rows.Add(name,registration,price, bill);

            }
            dataBind();
        }
        private void dataBind()
        {
            propertybillGV.DataSource = null;
            propertybillGV.DataSource = data;
            propertybillGV.Refresh();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
