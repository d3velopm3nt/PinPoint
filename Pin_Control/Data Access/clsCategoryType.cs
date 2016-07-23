using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pin_Control.Data_Access
{
    class clsCategoryType
    {
        SqlCommand sqlcmd;
        string Conn = Properties.Settings.Default.PinDBConnectionString;

        public DataView SelectAll_CategoryID(int ID)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_SelectCategoryType_ByCategoryID";

            sqlcmd.Parameters.Add("@Category_ID", SqlDbType.Int).Value = ID;
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlcmd);

            sqlDA.Fill(objv, "CategoryType");
            connect.Close();
            sqlcmd.Dispose();
            return objv.Tables[0].DefaultView;
        }

        public void Insert( int ID,int Catgory_ID,string Type)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_InsertCategoryType";

            sqlcmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = Type;
           if(ID > 0)
            sqlcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
           sqlcmd.Parameters.Add("@Category_ID", SqlDbType.Int).Value = Catgory_ID;


            sqlcmd.ExecuteNonQuery();
            connect.Close();
            sqlcmd.Dispose();

        }

        public void Delete(int ID)
        {
            DataSet objv = new DataSet();


            SqlConnection connect = new SqlConnection(Conn);
            connect.Open();

            sqlcmd = new SqlCommand();
            sqlcmd.Connection = connect;
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = "sp_DeleteCategoryType";

                sqlcmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
          


            sqlcmd.ExecuteNonQuery();
            connect.Close();
            sqlcmd.Dispose();

        }
    }
}
