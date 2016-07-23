using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pin_Control;

namespace Pin_Control.User_Controls
{

    public partial class uc_Configuration : UserControl
    {
        frmPinPoint frmPP;

        public uc_Configuration(frmPinPoint frmPP_)
        {
            frmPP = frmPP_;
            InitializeComponent();
        }


        private void uc_Configuration_Load(object sender, EventArgs e)
        {

        }

        private void lblUsers_Click(object sender, EventArgs e)
        {

            frmPP.SetPanel("users");
        }

        private void lblLocation_Click(object sender, EventArgs e)
        {
            frmPP.SetPanel("location");
        }

        private void lblCategories_Click(object sender, EventArgs e)
        {
            frmPP.SetPanel("categories");
        }

        private void lblDevices_Click(object sender, EventArgs e)
        {
            frmPP.SetPanel("devices");
        }

        private void lblUnitofMeasure_Click(object sender, EventArgs e)
        {
            frmPP.SetPanel("Unit of Measure");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmPP.SetPanel("Suppliers");
        }

      
    }
}
