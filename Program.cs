using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using final.BL;
using final.DL;
namespace final
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            if(personcrud.readData("sign.txt") && propertycrud.readdataforproperty("property.txt") && materialclass.readdataformaterial("material.txt"))
            {
                MessageBox.Show("Data Loaded..");
            }
            else
            {
                MessageBox.Show("Data Not Loaded..");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new menuform());
        }
    }
}
