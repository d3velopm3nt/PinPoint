using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pin_Control.Data_Access
{
    class clsAssetRegister
    {
        SqlCommand sqlcmd;
        string Conn = Properties.Settings.Default.PinDBConnectionString;

        public void Insert(string Serial,string RFID,string Description,int CateType)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_InsertAsset";

            sqlcmd.Parameters.Add("@RFID", SqlDbType.VarChar).Value = RFID;
            sqlcmd.Parameters.Add("@Serial", SqlDbType.VarChar).Value = Serial;
            sqlcmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description;
            sqlcmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = CateType;

            sqlcmd.ExecuteNonQuery();
            connect.Close();
            sqlcmd.Dispose();
           
        }

        public DataView SelectAll_ByRFID(string RFID)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectAssets_ByRFID";

            sqlcmd.Parameters.Add("@RFID", SqlDbType.VarChar).Value = RFID;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "assets");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

        public DataView SelectAll_CategoryType(int CategoryType_ID)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectAssets_ByCtype";

            sqlcmd.Parameters.Add("@Type", SqlDbType.Int).Value = CategoryType_ID;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "assets");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }
    }
}
