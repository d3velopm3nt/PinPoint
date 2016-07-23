using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin_Control.Business_Logic
{
    class clsSoftwareLicense
    {
        string  Serial1 = "38214-7485-HJ243-J234K-3434K";
        DateTime InstalledDate ;


        public void CheckLicenseDate()
        {
            bool check = false;
            try
            {
                TimeSpan ts = DateTime.Now.Subtract(InstalledDate);
                if (ts.TotalDays > 6)
                {

                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
