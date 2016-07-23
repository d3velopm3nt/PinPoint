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
    public partial class uc_Inventory_Register : UserControl
    {
        clsCategory clsC = new clsCategory();
        clsCategoryType clsCT = new clsCategoryType();
        clsUnitOfMeasure clsUM = new clsUnitOfMeasure();
        int CategoryID = 0;
        int CategoryTypeID = 0;
        frmPinPoint frmPP = null;
        public uc_Inventory_Register()
        {
            InitializeComponent();
        }

        private void FillUnitOfMeasure()
        {
            DataView objv = clsUM.SelectAll();
            if (objv.Count > 0)
            {
                cbxUnitOfMeasure.DisplayMember = "UnitMeasure";
                cbxUnitOfMeasure.ValueMember = "ID";
                cbxUnitOfMeasure.DataSource = objv;
                cbxUnitOfMeasure.Text = "Please Select";
            }
            else
                cbxUnitOfMeasure.Text = "Nothing Found";

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

        private void pb_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            DialogResult dl = openfile.ShowDialog();

            if (dl == DialogResult.OK)
            {
                pb_Image.Image = Image.FromFile(openfile.FileName);
            }
        }

        private void uc_Inventory_Register_Load(object sender, EventArgs e)
        {
            FillCategory();
            FillUnitOfMeasure();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCategory.SelectedIndex > -1)
            FillCategoryType();
        }
    }
}
