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
using System.Collections;


namespace Pin_Control.User_Controls
{
    public partial class uc_Reports : UserControl
    {
        int Asset_ID = 0;
        int Employee_ID = 0;
        string Dt_start = "";
        string Dt_end = "";

        public uc_Reports()
        {
            InitializeComponent();
        }

        private void fillCategories()
        {
            clsCategory clsC = new clsCategory();
            DataView objV = clsC.SelectAll();

            if (objV.Count > 0)
            {
                cbxCategory.DisplayMember = "Category";
                cbxCategory.ValueMember = "ID";
                cbxCategory.DataSource = objV;
                pbCategory.Image = Properties.Resources.GreenCheck;
            }
            else
                pbCategory.Image = Properties.Resources.RedCross;
        }

        private void fillCategoryType(int Category_ID)
        {
            try
            {
                clsCategoryType clsCT = new clsCategoryType();
                DataView objv_CT = clsCT.SelectAll_CategoryID(Category_ID);
                if (objv_CT.Count > 0)
                {
                    cbxType.DisplayMember = "Type";
                    cbxType.ValueMember = "ID";
                    cbxType.DataSource = objv_CT;

                    pbType.Image = Properties.Resources.GreenCheck;
                }
                else
                {
                    pbType.Image = Properties.Resources.RedCross;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillAssets(int Type_ID)
        {
            clsAssetRegister clsAR = new clsAssetRegister();
            DataView objvA = clsAR.SelectAll_CategoryType(Type_ID);
            if (objvA.Count > 0)
            {
                cbxAsset.DisplayMember = "Serial_No";
                cbxAsset.ValueMember = "ID";
                cbxAsset.DataSource = objvA;
                pbAsset.Image = Properties.Resources.GreenCheck;
            }
            else
                pbAsset.Image = Properties.Resources.GreenCheck;

        }

        private void fillEmployeeName()
        {
            clsUsers clsU = new clsUsers();
            DataView objvU = clsU.SelectAll();
            if (objvU.Count > 0)
            {
                cbxEmployee.DisplayMember = "First_Name";
                cbxEmployee.ValueMember = "ID";
                cbxEmployee.DataSource = objvU;

                Employee_ID = Convert.ToInt32(cbxEmployee.ValueMember[0]);
            }
            else
                Employee_ID = 0;
        }

        private void uc_Reports_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            this.asset_RegisterTableAdapter.Fill(this.pinDBDataSet.Asset_Register);
            fillCategories();
            fillEmployeeName();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCategoryType(Convert.ToInt32(cbxCategory.SelectedValue));
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.Items.Count > 0)
                fillAssets(Convert.ToInt32(cbxType.SelectedValue));
            else
                Asset_ID = 0;
        }

        private void chkName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkName.Checked)
            {
                cbxCategory.Enabled = true;
                cbxAsset.Enabled = true;
                cbxType.Enabled = true;
                pbCategory.Visible = true;
                pbType.Visible = true;
                pbAsset.Visible = true;
            }
            else
            {
                cbxCategory.Enabled = false;
                cbxAsset.Enabled = false;
                cbxType.Enabled = false;
                pbCategory.Visible = false;
                pbType.Visible = false;
                pbAsset.Visible = false;
                Asset_ID = 0;
                
            }
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                pbDate.Visible = true;
            }
            else
            {
                pbDate.Visible = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled =false;
                Dt_end = DateTime.Now.ToString();
               
            }
        }

        private void cbxAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            Asset_ID = Convert.ToInt32(cbxAsset.SelectedValue);
        }

        private void cbxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEmployee.SelectedIndex > -1)
            {
                Employee_ID = Convert.ToInt32(cbxEmployee.SelectedValue);
                pbUser.Image = Properties.Resources.GreenCheck;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Dt_start = dateTimePicker1.Value.ToString();
            Dt_end = DateTime.Now.ToString();
            pbDate.Image = Properties.Resources.GreenCheck;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Dt_end = dateTimePicker2.Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e )
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Asset_ID == 0 && chkName.Checked)
                    throw new Exception("No Asset was selected and this filter is included currently. remove filter or select asset serial.");

                if(Employee_ID == 0 && cbxUser.Checked)
                    throw new Exception("No Employee was selected and this filter is included currently. remove filter or select an employee.");

                if(chkDate.Checked && Dt_start == "")
                    throw new Exception("No Start Date was selected and this filter is included currently. remove filter or select asset serial from list");

              

                 DataView objv = new DataView();
                if (rbnTrackEvents.Checked)
                {
                    clsTrackEvents clsTE = new clsTrackEvents();
                   objv = clsTE.Search(Asset_ID, Employee_ID, Dt_start, Dt_end);
                }
                else if (rbnAlerts.Checked)
                {
                    clsAlerts clsA = new clsAlerts();
                    objv = clsA.Search(Asset_ID, Employee_ID, Dt_start, Dt_end);
                }
                else if (rbnUserEvents.Checked)
                {
                    clsUserEvents clsUE = new clsUserEvents();
                    objv = clsUE.Search(Employee_ID, Dt_start, Dt_end);
                }

                

                if (objv.Count > 0)
                {
                    dataGridView2.DataSource = objv;

                    FillDatagridviewColumnsSize();
                    lblResults.Text = objv.Count + " results were found with the current search criteria. Lets hope this is what you were looking for!";
                }
                else
                {
                    dataGridView2.DataSource = null;
                    dataGridView2.Rows.Clear();
                    dataGridView2.Columns.Clear();
                    lblResults.Text = "No Results were found with the current search criteria. Search for something else";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }

        }

        private void FillDatagridviewColumnsSize()
        {
            if(dataGridView2.Rows.Count > 0)
            {
                for(int i = 0 ; i < dataGridView2.Columns.Count ; i++)
                {
                    dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void cbxUser_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbxUser.Checked)
            {

                cbxEmployee.Enabled = true;
                pbUser.Visible = true;
            }
            else
            {
                pbUser.Visible = false;
                cbxEmployee.Enabled = false;
                Employee_ID = 0;
            }
        }

        private void rbnUserEvents_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnUserEvents.Checked)
            {
                chkName.Checked = false;
                
            }
        }

        private void rbnAlerts_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
