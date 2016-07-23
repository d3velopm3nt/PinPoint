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
using Pin_Control.Business_Logic;
using System.Threading;
using System.IO;
using System.Collections;

namespace Pin_Control.User_Controls
{
    public partial class uc_DeviceManager : UserControl
    {
        public delegate void displayMessageDlgt(string msg);
        frmPinPoint frmPP;
        clsDevices clsD = new clsDevices();
        clsRFID_Reader clsRFID;
        DataView objv = new DataView();
        int RowIndex = 0;
        Hashtable connectedDevices = new Hashtable(); 
        Thread[] InventoryT = new Thread[10];
        public uc_DeviceManager(frmPinPoint frmPP_)
        {
            frmPP = frmPP_;
            InitializeComponent();
            
        }
        private void DockControl()
        {
            this.Dock = DockStyle.Fill;
        }
 
        private void ZoomToImage()
        {

            DataGridViewImageColumn Col_Image = (DataGridViewImageColumn)dgv_Devices.Columns[0];

            Col_Image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Col_Image.Description = "Zoomed";
            
        }

        private void FillDeviceList()
        {
            DataGridViewRow row = null;
            objv = clsD.SelectAllWithLocation();
            RowIndex = 0;
            if (objv.Count > 0)
            {
                for (int i = 0; i < objv.Count; i++)
                {
                    if (objv[i].Row["Port"] != DBNull.Value)
                    {
                        if (dgv_Devices.Rows.Count > 0)
                        {
                          row  = dgv_Devices.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[3].Value.ToString().Equals(objv[i].Row["Port"].ToString())).FirstOrDefault();
                        }
                            if (!dgv_Devices.Rows.Contains(row) || dgv_Devices.Rows.Count == 0)
                            {
                                if (ConnectDevice(Convert.ToInt32(objv[i].Row["Port"])) == true)
                                {
                                    clsD.UpdateDeviceStatus_ByID(Convert.ToInt32(objv[i].Row["ID"]), "Connected");
                                    dgv_Devices.Rows.Add(Properties.Resources.Dark_Green, objv[i].Row["Device"].ToString(), objv[i].Row["IP_Address"].ToString(), objv[i].Row["Port"].ToString(), objv[i].Row["Name"].ToString(), DateTime.Now, "No Read Yet", 0, "Connected");
                                    lblNotifications.Text = "Reader " + objv[i].Row["Device"].ToString() + " connected successfully";

                                }
                                else
                                {
                                    clsD.UpdateDeviceStatus_ByID(Convert.ToInt32(objv[i].Row["ID"]), "Disconnected");
                                    dgv_Devices.Rows.Add(Properties.Resources.Red_Ball, objv[i].Row["Device"].ToString(), objv[i].Row["IP_Address"].ToString(), objv[i].Row["Port"].ToString(), objv[i].Row["Name"].ToString(), DateTime.Now, "No Read Yet", 0, "Disconnected");
                                    lblNotifications.Text = "Reader " + objv[i].Row["Device"].ToString() + " unable to connect, check network connectivity.";
                                }
                               
                            }
                        
                    }
                }
                if (dgv_Devices.Rows.Count > 0)
                    DeviceGridSelect();
            }
        }

        private bool ConnectDevice(int Port)
        {
            try
            {
                bool check = false;
                if (clsRFID.OpenPort(Port) == true)
                {
                   
                    check = true;
                    
                }
                return check;
               
            }
            catch
            {
                return false;
            }

        }

        private void uc_DeviceManager_Load(object sender, EventArgs e)
        {
            DockControl();
            clsRFID = new clsRFID_Reader(this);
            ZoomToImage();
            FillDeviceList();
         
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                
                clsRFID.ReadCheck = true;
                clsRFID.SetPowerDbm();
                InventoryT[0] = new Thread(clsRFID.Inventory);
                InventoryT[0].Priority = ThreadPriority.BelowNormal;
                InventoryT[0].Start();
                clsD.UpdateDeviceStatus_ByID(Convert.ToInt32(objv[RowIndex].Row["ID"]), "Started");
                dgv_Devices.Rows[RowIndex].Cells[0].Value = Properties.Resources.Dark_Blue;
                dgv_Devices.Rows[RowIndex].Cells[8].Value = "Started";
                DeviceGridSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void WriteReadLog(string tagResult)
        {
            if (tagResult != "")
            {
                try
                {
                    if (this.InvokeRequired)
                    {
                        object[] temp = { tagResult };
                        this.Invoke(new displayMessageDlgt(WriteReadLog), temp);
                        return;
                    }
                    else
                    {

                        rtxt_ReadLog.AppendText(tagResult + Environment.NewLine + "------------------------------------------------------------------------------------------");
                        rtxt_ReadLog.ScrollToCaret();

                        //clsClients.SendTagList(tagResult);
                        tagResult = "";

                        dgv_Devices.Rows[RowIndex].Cells[7].Value = clsRFID.ReadCount;
                        dgv_Devices.Rows[RowIndex].Cells[6].Value = DateTime.Now.ToString();

                    }

                }
                catch (Exception ex)
                {
                    rtxt_ReadLog.AppendText("Exception in the ReaderLog(): " + ex.Message + Environment.NewLine + "------------------------------------------------------------------------------------------");
                }


            }
        }

        public void btnStop_Click(object sender, EventArgs e)
        {
            clsRFID.ReadCheck = false;
            if (InventoryT[0] != null)
            {
                InventoryT[0].Join();
                InventoryT[0].Abort();

                clsD.UpdateDeviceStatus_ByID(Convert.ToInt32(objv[RowIndex].Row["ID"]), "Stopped");
                dgv_Devices.Rows[RowIndex].Cells[0].Value = Properties.Resources.Dark_Green;
                dgv_Devices.Rows[RowIndex].Cells[8].Value = "Stopped";
                DeviceGridSelect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtxt_ReadLog.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            DialogResult result = savefile.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (File.Create(savefile.FileName)) 
                rtxt_ReadLog.SaveFile(savefile.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (clsRFID.CLosePort(Convert.ToInt32(dgv_Devices.Rows[RowIndex].Cells[3].Value)))
            {
                dgv_Devices.Rows[RowIndex].Cells[0].Value = Properties.Resources.Red_Ball;
                dgv_Devices.Rows[RowIndex].Cells[8].Value = "Disconnected";
                btnStop.Enabled = false;
                btnStart.Enabled = false;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
            }
            else
                lblNotifications.Text = "Disconnecting reader was unsuccessful. Check reader connectivity and try again";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ConnectDevice(Convert.ToInt32(dgv_Devices.Rows[RowIndex].Cells[3].Value)))
            {
                dgv_Devices.Rows[RowIndex].Cells[0].Value = Properties.Resources.Dark_Green;
                dgv_Devices.Rows[RowIndex].Cells[8].Value = "Connected";
                btnStop.Enabled = false;
                btnStart.Enabled = true;
                btnClose.Enabled = true;
                btnOpen.Enabled = false;
            }
            else
                lblNotifications.Text = "Connecting to reader was unsuccessful. Check reader connectivity and try again";

        }

        private void dgv_Devices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgv_Devices.Rows.Count )
            {
                RowIndex = e.RowIndex;

                DeviceGridSelect();
            }
        }

        private void DeviceGridSelect()
        {
           
            string status = dgv_Devices.Rows[RowIndex].Cells[8].Value.ToString();
            if (dgv_Devices.Rows[RowIndex].Cells[8].Value == "Connected")
            {
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
            else if (dgv_Devices.Rows[RowIndex].Cells[8].Value == "Disconnected")
            {
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Enabled = false;
            }
            else if (dgv_Devices.Rows[RowIndex].Cells[8].Value == "Started")
            {
                btnOpen.Enabled = false;
                btnClose.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            else if (dgv_Devices.Rows[RowIndex].Cells[8].Value == "Stopped")
            {
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDeviceList();
        }

       


      
    }
}
