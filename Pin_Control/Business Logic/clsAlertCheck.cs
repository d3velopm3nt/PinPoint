using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pin_Control.Data_Access;

namespace Pin_Control.Business_Logic
{
    class clsAlertCheck
    {
        public void CheckAssetsWithoutUSers()
        {
            DataView objv = new DataView();
            clsAlerts clsA = new clsAlerts();
             frmNotificationPopup frmN = null;

            objv = clsA.CheckAssetWithoutUsers();
            if (objv.Count > 0)
            {
                if(objv.Count == 1)
                    frmN = new frmNotificationPopup(objv[0].Row[0].ToString(), objv[0].Row[1].ToString(), objv[0].Row[2].ToString(), objv[0].Row[3].ToString());
                else
                    frmN = new frmNotificationPopup(objv.Count.ToString(), objv[0].Row[1].ToString(), objv[0].Row[2].ToString(), objv[0].Row[3].ToString());

                frmN.Show();
            }
        }
    }
}
