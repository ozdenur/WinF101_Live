using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO01
{

    public partial class ADO01_Detail : Form
    {
        public string Mode; // bu değişgen public yani başka bir formdan değeri belirlenecek türden
        string constring = @"Data Source=DESKTOP-AD6B5QM\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";


        public ADO01_Detail()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close(); // formu kapatacak

        }
    }
}
