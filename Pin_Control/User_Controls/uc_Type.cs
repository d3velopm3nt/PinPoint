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
    public partial class uc_Type : UserControl
    {
        public uc_Type()
        {
            InitializeComponent();
        }

      

        private void uc_Type_Load(object sender, EventArgs e)
        {
     
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinDBDataSet);

        }
    }
}
