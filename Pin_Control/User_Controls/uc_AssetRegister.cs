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
    public partial class uc_AssetRegister : UserControl
    {
        clsCategory clsC = new clsCategory();
        clsCategoryType clsCT = new clsCategoryType();
       
        frmPinPoint frmPP = null;
        int CategoryID = 0;
        int CategoryTypeID = 0;
        public uc_AssetRegister(frmPinPoint frmPP_)
        {
            frmPP = frmPP_;
            InitializeComponent();
        }

        private void DockControl()
        {
            this.Dock = DockStyle.Fill;
        }

        private void FillCategory()
        {
            try
            {
                cbxCategory.Items.Clear();
                
                DataView objv = clsC.SelectAll();
                if (objv.Count > 0)
                {
                    cbxCategory.DisplayMember = "Category";
                    cbxCategory.ValueMember = "ID";
                    cbxCategory.DataSource = objv;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillCategoryType()
        {
            try
            {
                cbxType.DataSource = null;
                cbxType.Items.Clear();
                DataView objv = clsCT.SelectAll_CategoryID(CategoryID);
                if (objv.Count > 0)
                {

                    cbxType.DisplayMember = "Type";
                    cbxType.ValueMember = "ID";
                    cbxType.DataSource = objv;
                }
                else
                {
                    cbxType.Items.Add("No Category Type Found");
                    cbxType.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_AssetRegister_Load(object sender, EventArgs e)
        {
            DockControl();
            FillCategory();
            fillgrid();
           frmPP.uc_R = new uc_RegisterReader(this);
           tcAssetRegister.TabPages[0].Controls.Add(frmPP.uc_R);
        }

        public string setRFID
        {
            set
            {
                txtRFID.Text = value;
                tcAssetRegister.SelectedIndex = 1;
                
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxCategory.SelectedIndex > -1)
            {
                CategoryID = Convert.ToInt32(cbxCategory.SelectedValue);
                FillCategoryType();
                pbCategory.Image = Properties.Resources.GreenCheck;
            }
            else
                pbCategory.Image = Properties.Resources.RedCross;
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedIndex > -1 && cbxType.Items[0] != "No Category Type Found")
            {
                CategoryTypeID = Convert.ToInt32(cbxType.SelectedValue);

                pbType.Image = Properties.Resources.GreenCheck;
            }
            else
                pbType.Image = Properties.Resources.RedCross;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                clsAssetRegister clsA = new clsAssetRegister();

                if (txtSerial.Text == "")
                    throw new Exception("Please enter serial number");

                if (txtRFID.Text == "")
                    throw new Exception("No RFID scanned, please scan a RFID tag");

                if (CategoryID == 0)
                    throw new Exception("No Category was selected");

                if (CategoryTypeID == 0)
                    throw new Exception("No type was selected from category. This is a required field");

                clsA.Insert(txtSerial.Text, txtRFID.Text, txtDescription.Text,CategoryTypeID);

                txtMessage.Text = "New asset successfully saved to register";

                Clear();

                fillgrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillgrid()
        {
            try
            {
                this.asset_RegisterTableAdapter.Fill(this.pinDBDataSet.Asset_Register);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            if (txtSerial.Text.Length > 1)
            {
                if (pbSerial.Image != Properties.Resources.GreenCheck)
                    pbSerial.Image = Properties.Resources.GreenCheck;
            }
            else
                pbSerial.Image = Properties.Resources.RedCross;
        }

        private void txtRFID_TextChanged(object sender, EventArgs e)
        {
            if (txtRFID.Text.Length > 12)
                pbRFID.Image = Properties.Resources.GreenCheck;
            else
                pbRFID.Image = Properties.Resources.RedCross;
        }

        private void Clear()
        {
            txtSerial.Text = "";
            txtRFID.Text = "";
            CategoryID = 0;
            CategoryTypeID = 0;
            cbxCategory.SelectedIndex = 0;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
