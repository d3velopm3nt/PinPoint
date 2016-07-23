using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Pin_Control.Data_Access
{
    class clsReaderEvents
    {
        SqlCommand sqlcmd;
        string Conn = Properties.Settings.Default.PinDBConnectionString;

        public DataView SelectLast_ByReaderAndRFID(int Reader, string RFID)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectLastReaderEvent_ByReaderIDANDRFID";
            sqlcmd.Parameters.Add("@ReaderID", SqlDbType.Int).Value = Reader;
            sqlcmd.Parameters.Add("@RFID", SqlDbType.VarChar).Value = RFID;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "LastEvent");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

        public DataView SelectLast_ByRFID( string RFID)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectLastReaderEvent_ByRFID";
         
            sqlcmd.Parameters.Add("@RFID", SqlDbType.VarChar).Value = RFID;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "LastEvent");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

        public void Insert(int ReaderID, string RFID,string Status)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_InsertReaderEvents";

            sqlcmd.Parameters.Add("@RFID", SqlDbType.VarChar).Value = RFID;
            sqlcmd.Parameters.Add("@ReaderID", SqlDbType.Int).Value = ReaderID;
            sqlcmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = Status;
         
            sqlcmd.ExecuteNonQuery();
            connect.Close();
            sqlcmd.Dispose();

        }



    }
}
