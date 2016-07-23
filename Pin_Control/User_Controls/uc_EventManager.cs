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
    public partial class uc_EventManager : UserControl
    {
        public uc_EventManager()
        {
            InitializeComponent();
        }

        private void fillgrid()
        {
            try
            {
                int count = dataGridView1.Rows.Count;
                this.view_TrackEventsTableAdapter.FillBy(this.pinDBDataSet.View_TrackEvents);
                if (this.pinDBDataSet.View_TrackEvents.Rows.Count > count)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count -count; i++)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.SteelBlue;
                    }
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

        private void uc_EventManager_Load(object sender, EventArgs e)
        {
            DockControl();
            this.view_TrackEventsTableAdapter.FillBy(this.pinDBDataSet.View_TrackEvents);
            this.view_User_TrackEventsTableAdapter.FillBy(this.pinDBDataSet.View_User_TrackEvents);

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            fillgrid();
            FillUserTrackEvents();
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FillUserTrackEvents()
        {
            try
            {
                int count = view_User_TrackEventsDataGridView.Rows.Count;
               
                this.view_User_TrackEventsTableAdapter.FillBy(this.pinDBDataSet.View_User_TrackEvents);
                 if(this.pinDBDataSet.View_User_TrackEvents.Rows.Count > count)
                     for (int i = 0; i < view_User_TrackEventsDataGridView.Rows.Count - count; i++)
                     {
                         view_User_TrackEventsDataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.SteelBlue;
                     }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
