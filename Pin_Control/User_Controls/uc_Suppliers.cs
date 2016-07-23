using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pin_Control.User_Controls
{
    public partial class uc_Suppliers : UserControl
    {
        public uc_Suppliers()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinDBDataSet);

        }

        private void uc_Suppliers_Load(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.pinDBDataSet.Suppliers);
        }
    }
}
