using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class adminpurchasedmaterial : Form
    {

        DataTable data = new DataTable();
        public adminpurchasedmaterial()
        {
            InitializeComponent();
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Number", typeof(string));
            data.Columns.Add("Product", typeof(string));

            data.Columns.Add("Price", typeof(double));
            data.Columns.Add("Qunatity", typeof(int));
            data.Columns.Add("Bill", typeof(double));
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            char ch = (char)216;
            string record;
            string path = "orderedmaterial.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] splittedProperty = record.Split(ch);
                    if (splittedProperty.Length >= 5)
                    {
                        string name = splittedProperty[0];
                        string number = splittedProperty[1];
                        string product = splittedProperty[2];
                        double price = double.Parse(splittedProperty[3]);
                        int qunatity = int.Parse(splittedProperty[4]);
                        double bill = price * qunatity;
                        data.Rows.Add(name, number, product, price, qunatity, bill);
                    }


                }
                dataBind();
            }
          
        }
        private void dataBind()
        {
            materialGV.DataSource = null;
            materialGV.DataSource = data;
            materialGV.Refresh();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminpurchasedmaterial_Load(object sender, EventArgs e)
        {

        }
    }
}
