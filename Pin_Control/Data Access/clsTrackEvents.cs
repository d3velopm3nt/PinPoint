using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Pin_Control.Data_Access
{
    class clsTrackEvents
    {
        SqlCommand sqlcmd;
        string Conn = Properties.Settings.Default.PinDBConnectionString;



        public DataView Search(int Asset_ID,int User_ID,string Dt_Start, string Dt_End)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SearchTrackEvents";
            if(Asset_ID > 0)
            sqlcmd.Parameters.Add("@Asset_ID", SqlDbType.Int).Value = Asset_ID;

            if(User_ID > 0)
                sqlcmd.Parameters.Add("@User_ID", SqlDbType.Int).Value = User_ID;

            if (Dt_Start != "")
            {
                sqlcmd.Parameters.Add("@Dt_Start", SqlDbType.VarChar).Value = Dt_Start;
            }
            if(Dt_End != "")
                sqlcmd.Parameters.Add("@Dt_End", SqlDbType.VarChar).Value = Dt_End;
            

            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "Users");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

    }
}
