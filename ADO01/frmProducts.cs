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
    public partial class frmProducts : Form
    {
        // Global Kısım
        // Aşağıdaki değişgen VT bağlanabilmek için gerekli olan bağlantı cümleciğidir. Şu makinaya..şu database e bağlanmak istiyorum gibi
        string constring = @"Data Source=DESKTOP-AD6B5QM\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        
        string vs_SQLCommand = ""; // SQL komutlarımı içerecek
        string vs_SQLQuery = ""; // Query text i içerecek
        string Mode="";

        public frmProducts()
        {
            InitializeComponent();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {

        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
