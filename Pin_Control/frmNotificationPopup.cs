using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pin_Control
{
    public partial class frmNotificationPopup : Form
    {
        int counttime = 0;
        
        public frmNotificationPopup(string Asset,string Location,string Date,string Status)
        {
            InitializeComponent();
            lblAsset.Text = Asset;
            lblDate.Text = Date;
            lblLocation.Text = Location;
            lblEvent.Text = Status;

        }

        private void frmNotificationPopup_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y);

            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }


        public void fade_out()
        {
            double FadeOut = 0;
            for (FadeOut = 90; FadeOut >= 10; FadeOut += -10)
            {
                this.Opacity = FadeOut / 100;
                this.Refresh();
                System.Threading.Thread.Sleep(200);
            }
        }


        private void pc_Close_Click(object sender, EventArgs e)
        {
            fade_out();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counttime != 5)
                counttime += 1;
            else
            {
                timer1.Stop();
                fade_out();
                this.Close();
            }
        }




    }
}
