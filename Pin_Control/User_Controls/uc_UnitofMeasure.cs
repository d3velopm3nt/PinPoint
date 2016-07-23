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
    public partial class uc_UnitofMeasure : UserControl
    {
        public uc_UnitofMeasure()
        {
            InitializeComponent();
        }

        private void unitOfMeasureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unitOfMeasureBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinDBDataSet);

        }

        private void uc_UnitofMeasure_Load(object sender, EventArgs e)
        {
            this.unitOfMeasureTableAdapter.Fill(this.pinDBDataSet.UnitOfMeasure);
        }
    }
}
