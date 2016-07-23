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
    public partial class uc_Categories : UserControl
    {
        int ID = 0;
        int Category_ID = 0;
        clsCategoryType clsCT = new clsCategoryType();
        DataView objv_CT = new DataView();
       

        public uc_Categories()
        {
            InitializeComponent();
        }

        private void fillCategoryType()
        {
            try
            {
                listType.Items.Clear();
                objv_CT = clsCT.SelectAll_CategoryID(Category_ID);
                if (objv_CT.Count > 0)
                {
                    for (int i = 0; i < objv_CT.Count; i++)
                    {
                        listType.Items.Add(objv_CT[i].Row["Type"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void uc_Categories_Load(object sender, EventArgs e)
        {
          //  fillgrid();
            this.categoriesTableAdapter.Fill(this.pinDBDataSet.Categories);
            timer1.Start();
        }

        private void categoriesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinDBDataSet);

        }

        private void fillgrid()
        {
            try
            {
                if (this.pinDBDataSet.Location.Count > categoriesDataGridView.Rows.Count)
                this.categoriesTableAdapter.Fill(this.pinDBDataSet.Categories);
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

        private void categoriesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < categoriesDataGridView.Rows.Count)
            {             
                Category_ID = Convert.ToInt32(this.pinDBDataSet.Tables["Categories"].DefaultView[e.RowIndex].Row["ID"]);
                fillCategoryType();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtType.Text == "")
                {
                    throw new Exception("No Type Entered");
                }

                clsCT.Insert(ID, Category_ID, txtType.Text);

                fillCategoryType();
                txtType.Text = "";
                txtType.Focus();


            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void listType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(objv_CT[listType.SelectedIndex].Row["ID"]);
            txtType.Text = objv_CT[listType.SelectedIndex].Row["Type"].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtType.Text = "";
            ID = 0;
            txtType.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsCT.Delete(ID);
            fillCategoryType();
            btnClear_Click(sender, e);
            txtType.Focus();
        }

        private void categoriesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
