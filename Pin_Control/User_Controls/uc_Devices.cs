using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pin_Control.Data_Access;

namespace Pin_Control.User_Controls
{
    public partial class uc_Devices : UserControl
    {
        clsLocations clsL = new clsLocations();
        public uc_Devices()
        {
            InitializeComponent();
        }
        private void DockControl()
        {
            this.Dock = DockStyle.Fill;
        }

        private void uc_Devices_Load(object sender, EventArgs e)
        {
            DockControl();
            FillLocations();
            this.devicesTableAdapter.Fill(this.pinDBDataSet.Devices);
           
            timer1.Start();
        }

        private void FillLocations()
        {
            try
            {
               
                DataView objv = clsL.SelectAll();
                if (objv.Count > 0)
                {
                    cbxLocation.DisplayMember = "Name";
                    cbxLocation.ValueMember = "ID";
                    cbxLocation.DataSource = objv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            fillgrid();
        }

        private void devicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.devicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinDBDataSet);

        }

        private void fillgrid()
        {
            try
            {
                if (this.pinDBDataSet.Devices.Count > devicesDataGridView.Rows.Count)
                this.devicesTableAdapter.Fill(this.pinDBDataSet.Devices);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLocation.SelectedIndex > -1)
                location_IDTextBox.Text = cbxLocation.SelectedValue.ToString();
        }

        private void location_IDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (location_IDTextBox.Text != "")
                cbxLocation.SelectedValue = Convert.ToInt32(location_IDTextBox.Text);
        }
    }
}
