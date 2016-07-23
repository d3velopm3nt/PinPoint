using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pin_Control.User_Controls;
using System.Configuration;
using Pin_Control.Business_Logic;
using System.Xml;

namespace Pin_Control
{
    public partial class frmPinPoint : Form
    {
        uc_DeviceManager uc_DM;
        uc_Configuration uc_C;
        public uc_RegisterReader uc_R;
        clsAlertCheck clsA = new clsAlertCheck();
        public frmPinPoint()
        {
            InitializeComponent();
        }

        private void changeValue()
        {
            string KeyName = "Pin_Control.Properties.Settings.PinDBConnectionString";
            string KeyValue = "Data Source=localhost;Initial Catalog=PinDB;Integrated Security=false;";
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Update the setting.
            config.AppSettings.Settings[KeyName].Value = KeyValue;

            // Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of the changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc_DM = new uc_DeviceManager(this);
            btnDeviceController_Click(sender, e);
            timer_Alerts.Start();
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            panelNav.Controls.Clear();
           
            uc_C = new uc_Configuration(this);
            panelNav.Controls.Add(uc_C);
        }

        public void SetPanel( string select)
        {
            panelNav.Controls.Clear();

            if (select == "users")
            {
                if(uc_R != null)
                uc_R.Close();
                uc_Users uc_U = new uc_Users(this);
                panelNav.Controls.Add(uc_U);
            }
            else if (select == "location")
            {
                if (uc_R != null)
                uc_R.Close();
                uc_Locations uc_L = new uc_Locations();
                panelNav.Controls.Add(uc_L);
            }
            else if (select == "categories")
            {
                if (uc_R != null)
                uc_R.Close();
                uc_Categories uc_C = new uc_Categories();
                panelNav.Controls.Add(uc_C);
            }
            else if (select == "devices")
            {
                if (uc_R != null)
                uc_R.Close();
                uc_Devices uc_D = new uc_Devices();
                panelNav.Controls.Add(uc_D);
            }
            else if (select == "Unit of Measure")
            {
                if (uc_R != null)
                    uc_R.Close();
                uc_UnitofMeasure uc_UOM = new uc_UnitofMeasure();
                panelNav.Controls.Add(uc_UOM);
               
            }
            else if (select == "Suppliers")
            {
                if (uc_R != null)
                    uc_R.Close();
                uc_Suppliers uc_S = new uc_Suppliers();
                panelNav.Controls.Add(uc_S);

            }

        }

        private void btnEventManager_Click(object sender, EventArgs e)
        {
            panelNav.Controls.Clear();
            uc_EventManager uc_E = new uc_EventManager();
            panelNav.Controls.Add(uc_E);



        }

        private void btnAssetRegister_Click(object sender, EventArgs e)
        {
            if (uc_R != null)
                uc_R.Close();
            panelNav.Controls.Clear();
            uc_AssetRegister uc_A = new uc_AssetRegister(this);
            panelNav.Controls.Add(uc_A);
        }

        private void btnDeviceController_Click(object sender, EventArgs e)
        {
            if (uc_R != null)
                uc_R.Close();
            panelNav.Controls.Clear();
           
            panelNav.Controls.Add(uc_DM);

        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            if (uc_R != null)
                uc_R.Close();
            panelNav.Controls.Clear();
            uc_Alerts uc_A = new uc_Alerts();
            panelNav.Controls.Add(uc_A);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (uc_R != null)
                uc_R.Close();
            panelNav.Controls.Clear();
            uc_Reports uc_A = new uc_Reports();
            panelNav.Controls.Add(uc_A);
        }

        private void timer_Alerts_Tick(object sender, EventArgs e)
        {
         
            timer_Alerts.Stop();
            clsA.CheckAssetsWithoutUSers();
            timer_Alerts.Start();
        }

        private void frmPinPoint_FormClosing(object sender, FormClosingEventArgs e)
        {
            uc_DM.btnStop_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelNav.Controls.Clear();
            uc_Inventory_Register ucIR = new uc_Inventory_Register();
            panelNav.Controls.Add(ucIR);

        }

    }
}
