using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql; 
namespace Pin_Control.User_Controls
{
    public partial class uc_DBConnection : UserControl
    {
        public uc_DBConnection()
        {
            InitializeComponent();
        }

        private void uc_DBConnection_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
            DataTable dt = null;
            int a = 0;
            string SqlInstanceName;
          ComboboxItem item = new ComboboxItem();
          
            try
            {
                dt = SqlDataSourceEnumerator.Instance.GetDataSources();


                foreach (DataRow dr in dt.Rows)
                {
                    SqlInstanceName = dr[0].ToString();
                    CmbSQLInstance.Items.Add("poes");
                    label1.Text = "poes";
                   a =+1 ;
                }
                //

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error!");

            }
            catch (Exception ex)
            {
                //Interaction.MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error!");

            }
            finally
            {
                //dr = null;
                dt = null;
            }

        }

   
	// This call is required by the Windows Form Designer.


        }

        
    }
public class ComboboxItem
{
    public string Text { get; set; }
    public object Value { get; set; }

    public override string ToString()
    {
        return Text;
    }
}
