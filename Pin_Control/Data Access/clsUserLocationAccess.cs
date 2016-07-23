using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pin_Control.Data_Access
{
    class clsUserLocationAccess
    {
        SqlCommand sqlcmd;
        string Conn = Properties.Settings.Default.PinDBConnectionString;

        public void Insert(int User_ID, int Location_ID)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_InsertUserLocationAccess";

            sqlcmd.Parameters.Add("@User_ID", SqlDbType.Int).Value = User_ID;
            sqlcmd.Parameters.Add("@Location_ID", SqlDbType.Int).Value = Location_ID;
         

            sqlcmd.ExecuteNonQuery();
            connect.Close();
            sqlcmd.Dispose();

        }
    }

    

}
