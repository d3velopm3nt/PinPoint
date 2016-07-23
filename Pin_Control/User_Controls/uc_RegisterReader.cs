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

namespace Pin_Control.User_Controls
{
    public partial class uc_RegisterReader : UserControl
    {
        private byte fComAdr = 0xff;
        private byte fBaud;
        private bool ComOpen = false;
        private int fOpenComIndex;
        private int frmcomportindex;
        private int fCmdRet = 30;
        private string fInventory_EPC_List;
        clsUsers clsU = new clsUsers();
        clsAssetRegister clsA = new clsAssetRegister();
        bool start = false;
        bool Check = false;
        bool close = false;
        bool result = false;
        System.Collections.ArrayList Tags = new System.Collections.ArrayList();
       
       public uc_AssetRegister ucA;
       public uc_Users ucU;
        public uc_RegisterReader()
        {
            InitializeComponent();
        }

        public uc_RegisterReader(uc_AssetRegister ucA_)
        {
            InitializeComponent();
            ucA = ucA_;
        }

        public uc_RegisterReader(uc_Users ucU_)
        {
            ucU = ucU_;
            InitializeComponent();
        }

        private void uc_RegisterReader_Load(object sender, EventArgs e)
        {
            ComboBox_baud2.SelectedIndex = 3;

            ComboBox_COM.SelectedIndex = 0;
        }

        private void OpenPort_Click(object sender, EventArgs e)
        {
            int port = 0;
            int openresult, i;
            openresult = 30;
            string temp;
            Cursor = Cursors.WaitCursor;

            Edit_CmdComAddr.Text = "FF";
            fComAdr = Convert.ToByte(Edit_CmdComAddr.Text, 16); // $FF;
            try
            {
                if (ComboBox_COM.SelectedIndex == 0)//Auto
                {
                    fBaud = Convert.ToByte(ComboBox_baud2.SelectedIndex);
                    if (fBaud > 2)
                    {
                        fBaud = Convert.ToByte(fBaud + 2);
                    }
                    
                    openresult = StaticClassReaderB.AutoOpenComPort(ref port, ref fComAdr, fBaud, ref frmcomportindex);
                    fOpenComIndex = frmcomportindex;
                    if (openresult == 0)
                    {
                        ComOpen = true;
                        // Button3_Click(sender, e); 
                        if (fBaud > 3)
                        {
                            ComboBox_baud2.SelectedIndex = Convert.ToInt32(fBaud - 2);
                        }
                        else
                        {
                            ComboBox_baud2.SelectedIndex = Convert.ToInt32(fBaud);
                        }
                        // Button3_Click(sender, e); 
                        if ((fCmdRet == 0x35) | (fCmdRet == 0x30))
                        {
                            MessageBox.Show("Serial Communication Error or Occupied", "Information");
                            button4.Text = "No connection available";
                            StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                            ComOpen = false;
                        }
                    }
                    else
                    {
                        button4.Text = "Connection Successful";
                        btnActivate.Enabled = true;
                        //button6.Enabled = false;
                        //button7.Enabled = false;
                    }

                }
                else
                {
                    temp = ComboBox_COM.SelectedItem.ToString();
                    temp = temp.Trim();
                    port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
                    for (i = 6; i >= 0; i--)
                    {
                        fBaud = Convert.ToByte(i);
                        if (fBaud == 3)
                            continue;
                        openresult = StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref frmcomportindex);
                        fOpenComIndex = frmcomportindex;
                        if (openresult == 0x35)
                        {
                           // MessageBox.Show("COM Opened", "Information");
                            button4.Text = "Connection Failed";

                            return;
                        }
                        if (openresult == 0)
                        {
                            ComOpen = true;
                            // Button3_Click(sender, e);
                            if (fBaud > 3)
                            {
                                ComboBox_baud2.SelectedIndex = Convert.ToInt32(fBaud - 2);
                            }
                            else
                            {
                                ComboBox_baud2.SelectedIndex = Convert.ToInt32(fBaud);
                            }
                            if ((fCmdRet == 0x35) || (fCmdRet == 0x30))
                            {
                                ComOpen = false;
                                MessageBox.Show("Serial Communication Error or Occupied", "Information");
                                button4.Text = "No connection available";
                                StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                                return;
                            }

                            break;
                        }
                        else
                        {
                            button4.Text = "Connection Successful";
                            btnActivate.Enabled = true;

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            if ((fOpenComIndex != -1) & (openresult != 0X35) & (openresult != 0X30))
            {
                ComboBox_AlreadyOpenCOM.Items.Add("COM" + Convert.ToString(fOpenComIndex));
                ComboBox_AlreadyOpenCOM.SelectedIndex = ComboBox_AlreadyOpenCOM.SelectedIndex + 1;
                btnActivate.Enabled = true;
            }
            if ((fOpenComIndex == -1) && (openresult == 0x30))
                MessageBox.Show("Serial Communication Error", "Information");
            // button4.Text = "No connection available";

            if ((ComboBox_AlreadyOpenCOM.Items.Count != 0) & (fOpenComIndex != -1) & (openresult != 0X35) & (openresult != 0X30) & (fCmdRet == 0))
            {
                // fComAdr = Convert.ToByte(Edit_ComAdr.Text, 16);
                temp = ComboBox_AlreadyOpenCOM.SelectedItem.ToString();
                frmcomportindex = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
            }
        }

        public void Close()
        {
            int port;
            //string SelectCom ;
            string temp;

            try
            {
                if (ComboBox_AlreadyOpenCOM.SelectedIndex < 0)
                {
                    //if (close == false)
                  //  MessageBox.Show("Please Choose COM Port to close", "Information");
                }
                else
                {
                    temp = ComboBox_AlreadyOpenCOM.SelectedItem.ToString();
                    port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
                    fCmdRet = StaticClassReaderB.CloseSpecComPort(port);
                    if (fCmdRet == 0)
                    {
                         ComboBox_AlreadyOpenCOM.Items.RemoveAt(0);
                        if (ComboBox_AlreadyOpenCOM.Items.Count != 0)
                        {
                            
                            temp = ComboBox_AlreadyOpenCOM.SelectedItem.ToString();
                            port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
                            StaticClassReaderB.CloseSpecComPort(port);
                            fComAdr = 0xFF;
                            StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref frmcomportindex);
                            fOpenComIndex = frmcomportindex;
                          
                            //Button3_Click(sender, e); 
                        }
                    }
                    else
                        MessageBox.Show("Serial Communication Error", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
            if (ComboBox_AlreadyOpenCOM.Items.Count != 0)
                ComboBox_AlreadyOpenCOM.SelectedIndex = 0;
            else
            {
                fOpenComIndex = -1;
                ComboBox_AlreadyOpenCOM.Items.Clear();
                ComboBox_AlreadyOpenCOM.Refresh();


            }
        }

        private void ClosePort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            byte[] Parameter = { 0, 0, 1, 2, 1, 0 };
            try
            {
                fCmdRet = StaticClassReaderB.SetWorkMode(ref fComAdr, Parameter, frmcomportindex);

                if (fCmdRet == 0)
                {
                    btnActivate.Text = "Activated";
                    btnActivate.ForeColor = Color.Green;

                    comboBox1.Enabled = true;
                    comboBox1.SelectedIndex = 5;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox_baud2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox_baud2.Items.Clear();
            //if (ComboBox_COM.SelectedIndex == 0)
            //{
            //    ComboBox_baud2.Items.Add("9600bps");
            //    ComboBox_baud2.Items.Add("19200bps");
            //    ComboBox_baud2.Items.Add("38400bps");
            //    ComboBox_baud2.Items.Add("57600bps");
            //    ComboBox_baud2.Items.Add("115200bps");
            //}
            //ComboBox_baud2.SelectedIndex = 3;
       //     else
      //      {
       //         ComboBox_baud2.Items.Add("Auto");
     //           ComboBox_baud2.SelectedIndex = 0;
    //        }
        }

        private void calculate(string level)
        {
            double first = Convert.ToDouble(level);
            double second = first / 30;
            double per = 100;
            double total = second * per;
            int conTotal = Convert.ToInt32(total);
            progressBar1.Value = (conTotal);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte powerDbm;
            powerDbm = Convert.ToByte(comboBox1.SelectedIndex);
            fCmdRet = StaticClassReaderB.SetPowerDbm(ref fComAdr, powerDbm, frmcomportindex);

            calculate(comboBox1.SelectedItem.ToString());
        }

        private void Start()
        {
            start = true;
            timer1.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();

        }

        private void Stop()
        {
            start = false;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            timer1.Stop();
            Tags.Clear();
        }

        private void Inventory()
        {
            int CardNum = 0;
            int Totallen = 0;
            int EPClen, m;
            byte[] EPC = new byte[5000];
            //int CardIndex;
            string temps;
            string s, sEPC;
            // bool isonlistview;
            byte AdrTID = 0;
            byte LenTID = 0;
            byte TIDFlag = 0;
            btnStop.Enabled = true;
            int i = 0;

            try
            {
                //while (result.Equals(false))
                //{

                fCmdRet = StaticClassReaderB.Inventory_G2(ref fComAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, frmcomportindex);
                if ((fCmdRet == 1) | (fCmdRet == 2) | (fCmdRet == 3) | (fCmdRet == 4) | (fCmdRet == 0xFB))
                {
                    byte[] daw = new byte[Totallen];
                    Array.Copy(EPC, daw, Totallen);
                    temps = ByteArrayToHexString(daw);
                    fInventory_EPC_List = temps;
                    m = 0;
                    if (daw.Length > 0)
                    {
                        EPClen = daw[m];
                        sEPC = temps.Substring(m * 2 + 2, EPClen * 2);
                        m = m + EPClen + 1;


                        DataView objvTemp = new DataView();
                        if (!Tags.Contains(sEPC))
                        {
                            Tags.Add(sEPC);
                            if (ucU != null)
                                objvTemp = clsU.SelectAll_ByRFID(sEPC);
                            else if (ucA != null)
                                objvTemp = clsA.SelectAll_ByRFID(sEPC);

                            if (objvTemp.Count > 0)
                                objvTemp.RowFilter = "RFID = '" + sEPC + "'";
                            

                            if (objvTemp.Count == 0)
                            {

                                txtRFID.Text = sEPC;
                                
                                Stop();
                               
                            }
                            else
                            {
                                if (ucU != null)
                                    txtRFID.Text = "Existing User Found";
                                else if (ucA != null)
                                    txtRFID.Text = "Existing Asset Found";
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRFID.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ucA != null)
            {
                ucA.setRFID = txtRFID.Text;
            }
            else if (ucU != null)
            {
                ucU.setRFID = txtRFID.Text;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(start == true)
            Inventory();
        }

    }
}
