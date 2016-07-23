using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaderB;
using Pin_Control.Data_Access;
using System.Collections;

namespace Pin_Control.User_Controls
{
    public partial class uc_Users : UserControl
    {
        private byte fComAdr = 0xff;
        private byte fBaud;
        private bool ComOpen = false;
        private int fOpenComIndex;
        private int frmcomportindex;
        private int fCmdRet = 30;
        private string fInventory_EPC_List;
        bool Check = false;
        bool close = false;
        bool result = false;
        clsLocations clsL = new clsLocations();
        int User_ID = 0;
       
        System.Collections.ArrayList Tags = new System.Collections.ArrayList();
        Hashtable htLocations = new Hashtable();
        frmPinPoint frmPP = null;
        public uc_Users(frmPinPoint frmPP_)
        {
            InitializeComponent();
            frmPP = frmPP_;
        }

        private void FillLocations()
        {
            try
            {
                listAlllocations.Items.Clear();
                DataView objv = clsL.SelectAll();
                if (objv.Count > 0)
                {
                    for (int i = 0; i < objv.Count; i++)
                    {
                        listAlllocations.Items.Add(objv[i].Row["Name"].ToString());
                        htLocations.Add(objv[i].Row["Name"].ToString(), objv[i].Row["ID"].ToString());
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinDBDataSet);

        }

        private void fillgrid()
        {
            try
            {
                if(this.pinDBDataSet.Users.Count > usersDataGridView.Rows.Count)
                this.usersTableAdapter.Fill(this.pinDBDataSet.Users);

                if (result == true)
                {

                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void DockControl()
        {
            this.Dock = DockStyle.Fill;
        }

        private void uc_Users_Load(object sender, EventArgs e)
        {
            DockControl();
            this.usersTableAdapter.Fill(this.pinDBDataSet.Users);
            if(usersDataGridView.Rows.Count > 0)
                User_ID = Convert.ToInt32(usersDataGridView.Rows[0].Cells[0].Value);

            timer1.Start();
            frmPP.uc_R = new uc_RegisterReader(this);
            panel_RFID.Controls.Add(frmPP.uc_R);
            usersDataGridView.Columns[0].Visible = false;
            FillLocations();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fillgrid();

        }

        public string setRFID
        {
            set
            {
                rFIDTextBox.Text = value;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listAlllocations.Items.Count; i++)
            {
                listSelectedlocations.Items.Add(listAlllocations.GetItemText(listAlllocations.Items[i]));
                listAlllocations.Items.Remove(listAlllocations.Items[i]);

            }
        }

        private void btnAddSelected_Click(object sender, EventArgs e)
        {
            listSelectedlocations.Items.Add(listAlllocations.GetItemText(listAlllocations.SelectedItem));
            listAlllocations.Items.Remove(listAlllocations.SelectedItem);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            listAlllocations.Items.Add(listSelectedlocations.GetItemText(listSelectedlocations.SelectedItem));
            listSelectedlocations.Items.Remove(listSelectedlocations.SelectedItem);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listAlllocations.Items.Count; i++)
            {
                listAlllocations.Items.Add(listSelectedlocations.GetItemText(listSelectedlocations.Items[i]));
                listSelectedlocations.Items.Remove(listSelectedlocations.Items[i]);


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsUserLocationAccess clsULA = new clsUserLocationAccess();

            try
            {
                for (int i = 0; i < listSelectedlocations.Items.Count; i++)
                {
                    string Name = listSelectedlocations.Items[i].ToString();
                    int Location_ID = Convert.ToInt32(htLocations[Name]);
                    clsULA.Insert(User_ID, Location_ID);
                }

                MessageBox.Show("Location Access Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void usersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < usersDataGridView.Rows.Count)
            {
                User_ID = Convert.ToInt32(usersDataGridView.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnRemoveAll_Click(sender, e);
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
