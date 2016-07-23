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
    public partial class uc_Locations : UserControl
    {
        public uc_Locations()
        {
            InitializeComponent();
        }

        private void locationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinDBDataSet);

        }

        private void uc_Locations_Load(object sender, EventArgs e)
        {
            this.locationTableAdapter.Fill(this.pinDBDataSet.Location);
            timer1.Start();
        }

        private void fillgrid()
        {
            try
            {
                if (this.pinDBDataSet.Location.Count > locationDataGridView.Rows.Count)
                this.locationTableAdapter.Fill(this.pinDBDataSet.Location);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void locationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
