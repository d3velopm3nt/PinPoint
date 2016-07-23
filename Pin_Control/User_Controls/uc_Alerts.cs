using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pin_Control.User_Controls
{
    public partial class uc_Alerts : UserControl
    {
        public uc_Alerts()
        {
            InitializeComponent();
        }
        private void DockControl()
        {
            this.Dock = DockStyle.Fill;
        }
        private void FillAlerts()
        {
            try
            {
                if(this.pinDBDataSet.View_UserAlerts.Rows.Count > view_UserAlertsDataGridView.Rows.Count)
                this.view_UserAlertsTableAdapter.FillBy(this.pinDBDataSet.View_UserAlerts);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void uc_Alerts_Load(object sender, EventArgs e)
        {
            DockControl();
            this.view_UserAlertsTableAdapter.FillBy(this.pinDBDataSet.View_UserAlerts);
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FillAlerts();
        }
    }
}
