using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReaderB;
using Pin_Control.Data_Access;
using System.Data;
using Pin_Control.User_Controls;
using Pin_Control.Data_Access;
using System.Threading;
namespace Pin_Control.Business_Logic
{
    class clsRFID_Reader
    {
        private byte fComAdr = 0xff;
        private byte fBaud;
        private bool ComOpen = false;
        private int fOpenComIndex;
        private int frmcomportindex;
        private int fCmdRet = 30;
        public string EditComAddr = "";
        public string CommSelected = "";
        public bool Activated = false;
        private string fInventory_EPC_List;
        public bool ReadCheck = false;
        int PowerLevel = 0;
        clsUsers clsU = new clsUsers();
        clsDevices clsD = new clsDevices();
        clsAssetRegister clsA = new clsAssetRegister();
        uc_RegisterReader uc_R = new uc_RegisterReader();
        clsReaderEvents clsRE = new Data_Access.clsReaderEvents();
        System.Collections.ArrayList Tags = new System.Collections.ArrayList();
        string sEPC = "";
        string RFID_Found = "";
        public bool Register = false;
       public int ReadCount = 0;
        int ReaderID = 0;
        string ReaderName = "";
        int TimeLimit = 0;
        string TimeType = "";
        uc_DeviceManager uc_D;

        public clsRFID_Reader(uc_DeviceManager uc_D_)
        {
            uc_D = uc_D_;
        }

        public string set_EditComAddr
        {
            set
            {
                EditComAddr = value;
            }
        }

        public byte set_fBaud
        {
            set
            {
                fBaud = value;
            }
        }

        public bool OpenPort(int Port_)
        {
            int port = 0;
            int openresult, i;
            openresult = 30;
            string temp;
            EditComAddr = "FF";
            fComAdr = Convert.ToByte(EditComAddr, 16); // $FF;
            ComOpen = false;
          

            for (i = 6; i >= 0; i--)
            {
                fBaud = Convert.ToByte(i);
                if (fBaud == 3)
                    continue;
                openresult = StaticClassReaderB.OpenComPort(Port_, ref fComAdr, fBaud, ref frmcomportindex);
                fOpenComIndex = frmcomportindex;
                if (openresult == 0)
                {
                    ComOpen = true;

                    if (fBaud > 3)
                    {
                        fBaud = Convert.ToByte(fBaud - 2);
                    }

                    if ((fCmdRet == 0x35) | (fCmdRet == 0x30))
                    {
                        StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                        ComOpen = false;

                    }

                    break;
                }
            }
              return ComOpen;
        }

        public bool CLosePort(int OpenCom)
        {
            bool check = false;
            if (OpenCom > 0)
            {
                
                fCmdRet = StaticClassReaderB.CloseSpecComPort(OpenCom);
                if (fCmdRet == 0)
                {

                    StaticClassReaderB.CloseSpecComPort(OpenCom);
                    fComAdr = 0xFF;
                   // StaticClassReaderB.OpenComPort(OpenCom, ref fComAdr, fBaud, ref frmcomportindex);
                    fOpenComIndex = frmcomportindex;
                    check = true;
                    //Button3_Click(sender, e); 
                }
                else
                    check = true;
                }
           else
            {
                throw new Exception("Serial Communication Error");
            }
            return check;
        }
        
        public void Activate(int Port_)
        {
            byte[] Parameter = { 0, 0, 1, 2, 1, 0 };
            try
            {
                fCmdRet = StaticClassReaderB.SetWorkMode(ref fComAdr, Parameter, Port_);

                if (fCmdRet == 0)
                {
                    Activated = true;

                    SetPowerDbm();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SetPowerDbm()
        {
            DataView objv = clsD.SelectAll_ByPort(frmcomportindex);
            if (objv.Count > 0)
            {
                if (objv[0].Row["Attenuation"] != DBNull.Value)
                {
                    byte powerDbm;
                    powerDbm = Convert.ToByte(objv[0].Row["Attenuation"]);
                    fCmdRet = StaticClassReaderB.SetPowerDbm(ref fComAdr, powerDbm, frmcomportindex);
                }
            }
        }

        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();

        }

        public void Inventory()
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
            
            int i = 0;

            try
            {
                while (ReadCheck == true)
                {
                    uc_D.Invoke((EventHandler)delegate
                    {
                    fCmdRet = StaticClassReaderB.Inventory_G2(ref fComAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, frmcomportindex);
                    });
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

                            uc_D.Invoke((EventHandler)delegate
                            {
                                CheckTaginReader(sEPC, frmcomportindex);
                                ReadCount += 1;

                                
                            });
                            
                        }

                        Thread.Sleep(500);
                    }
                }
            }
            catch (Exception ex)
            {
                         uc_D.Invoke((EventHandler)delegate
                           {
                               throw new Exception(ex.Message);
                           });
            }
            
        }

        public void CheckIfTagExists()
        {
            DataView objvTemp = new DataView();
            if (!Tags.Contains(sEPC))
            {
                Tags.Add(sEPC);
                if (uc_R.ucU != null)
                    objvTemp = clsU.SelectAll_ByRFID(sEPC);
                else if (uc_R.ucA != null)
                    objvTemp = clsA.SelectAll_ByRFID(sEPC);

                if (objvTemp.Count > 0)
                    objvTemp.RowFilter = "RFID = '" + sEPC + "'";


                if (objvTemp.Count == 0)
                {
                    RFID_Found = sEPC;

                }
                else
                {
                    if (uc_R.ucU != null)
                        RFID_Found = "Existing User Found";
                    else if (uc_R.ucA != null)
                        RFID_Found = "Existing Asset Found";
                }
            }
        }

        private void GetReaderInfo(int port)
        {
            
            DataView objv = clsD.SelectAll_ByPort(port);
            if (objv.Count > 0)
            {
                ReaderID = Convert.ToInt32(objv[0].Row["ID"]);
                if (objv[0].Row["TimeLimitType"] != DBNull.Value)
                {
                    TimeType = objv[0].Row["TimeLimitType"].ToString();
                    TimeLimit = Convert.ToInt32(objv[0].Row["TimeLimit"]);
                    ReaderName = objv[0].Row["Device"].ToString();


                }
            }
        }

        private string CheckTagStatus(string Status)
        {
            if (Status == "IN")
                Status = "OUT";
            else if (Status == "OUT")
                Status = "IN";

            return Status;
        }

        private void CheckTaginReader(string EPC, int port)
        {

            bool Saved = false;
            try
            {
                if (ReaderID == 0)
                    GetReaderInfo(port);
                DateTime LastEvent_Time;
                TimeSpan last_ts = new TimeSpan();
                DataView objv_RE = clsRE.SelectLast_ByRFID(EPC);
                string LastStatus = "";
                string Status = "";
                if (objv_RE.Count > 0)
                {
                    objv_RE.RowFilter = "Reader_ID = " + ReaderID;
                    if (objv_RE.Count > 0)
                    {
                        //Reader Events found for RFID - Check TimeLimit
                        LastEvent_Time = Convert.ToDateTime(objv_RE[0].Row["DateTime"]);
                        last_ts = DateTime.Now.Subtract(LastEvent_Time);
                        LastStatus = objv_RE[0].Row["Status"].ToString();
                        
                        if (TimeType == "Minutes")
                        {
                            if (last_ts.TotalMinutes > TimeLimit)
                            {
                                
                                Saved = true;
                            }
                        }
                        else if (TimeType == "Seconds")
                        {
                            if (last_ts.TotalSeconds > TimeLimit)
                            {
                                
                                Saved = true;
                            }
                        }
                        else if (TimeType == "Hours")
                        {
                            if (last_ts.TotalHours > TimeLimit)
                            {
                              
                                Saved = true;
                            }
                        }
                        else if (TimeType == "Days")
                        {
                            if (last_ts.TotalDays > TimeLimit)
                            {
                              
                                Saved = true;
                            }
                        }

                        if (Saved == true)
                        {
                            Status = CheckTagStatus(LastStatus);
                            clsRE.Insert(ReaderID, EPC, Status);
                        }
                       

                    }
                    else
                    {
                        //NO Events found for RFID - Insert into Reader Events
                        if (TimeType != "")
                            clsRE.Insert(ReaderID, EPC, "IN");
                        else
                            clsRE.Insert(ReaderID, EPC, "");

                        Saved = true;
                    }
                }
                else
                {
                    if (TimeType != "")
                        clsRE.Insert(ReaderID, EPC, "IN");
                    else
                        clsRE.Insert(ReaderID, EPC, "");

                    Saved = true;

                }

                if (Saved == true)
                    uc_D.WriteReadLog(Environment.NewLine + " Inserted - Reader: " + ReaderName + " read " + EPC + " Status: " + Status + " - Time Seen: " + DateTime.Now.ToString()); 
                else
                    uc_D.WriteReadLog(Environment.NewLine + " Seen NOT Saved - Reader: " + ReaderName + " read " + EPC + " Status: " + Status + " - Time Seen: " + DateTime.Now.ToString()); 

                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
