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
    public partial class adminpurchasedproperty : Form
    {
        DataTable data = new DataTable();
        public adminpurchasedproperty()
        {
            InitializeComponent();
            data.Columns.Add("Name", typeof(string));
            data.Columns.Add("Number", typeof(string));
            data.Columns.Add("Location", typeof(string));

            data.Columns.Add("Registration", typeof(string));
            data.Columns.Add("Price", typeof(double));
            data.Columns.Add("Bill", typeof(double));
        }

        private void viewbutton_Click(object sender, EventArgs e)
        {
            char ch = (char)216;
            string record;
            string path = "orderedproperty.txt";
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
                        string Location = splittedProperty[2];
                        string registration = splittedProperty[3];
                        double price = double.Parse(splittedProperty[4]);
                        double bill = price ;
                        data.Rows.Add(name, number,Location, registration, price, bill);
                    }


                }
                dataBind();
            }
        }
        private void dataBind()
        {
            propertyGV.DataSource = null;
            propertyGV.DataSource = data;
            propertyGV.Refresh();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
