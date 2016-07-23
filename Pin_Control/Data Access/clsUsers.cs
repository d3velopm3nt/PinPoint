using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pin_Control.Data_Access
{
    class clsUsers
    {
        SqlCommand sqlcmd;
        string Conn = Properties.Settings.Default.PinDBConnectionString; 

        public DataView SelectAll()
        {
            DataSet objv = new DataSet();
            

            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectUsers";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "Users");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

        public DataView SelectAll_ByRFID(string RFID)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectUser_ByRFID";

            sqlcmd.Parameters.Add("@RFID", SqlDbType.VarChar).Value = RFID;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "Users");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

    }
}
