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


namespace final
{
    public partial class usermaterialbill : Form
    {
        DataTable data = new DataTable();
        user u;
        public usermaterialbill(user p)
        {
            InitializeComponent();
            u = p;
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Price", typeof(double));
            data.Columns.Add("Qunatity", typeof(int));
            data.Columns.Add("Bill", typeof(double));
        }
       
        private void viewbutton_Click(object sender, EventArgs e)
        {
            foreach (var item in u.getmateriallist())
            {
                string name = item.Materialname;
                double price = item.Materialprice;
                int quantity = item.Materialquantity;
                double bill = price * quantity;
                data.Rows.Add(name, price, quantity, bill);
                
            }
            dataBind();
        }
        private void dataBind()
        {
            billGV.DataSource = null;
            billGV.DataSource = data;
            billGV.Refresh();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
