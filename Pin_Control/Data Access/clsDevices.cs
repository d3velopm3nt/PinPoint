using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Pin_Control.Data_Access
{
    class clsDevices
    {
        SqlCommand sqlcmd;
        string Conn = Properties.Settings.Default.PinDBConnectionString;
        //stian commentssd
        public DataView SelectAllWithLocation()
        {
            DataSet objv = new DataSet();

            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectDevicesWithLocation";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "Devices");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

        public DataView SelectAll_ByPort(int Port)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectDeviceByPort";
            sqlcmd.Parameters.Add("@Port", SqlDbType.Int).Value = Port;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "Devices");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

        public void UpdateDeviceStatus_ByID(int ID,string Status)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_UpdateDeviceStatus_ByID";
            sqlcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlcmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;

            sqlcmd.ExecuteNonQuery();
            connect.Close();
            sqlcmd.Dispose();
     
        }
    }
}
