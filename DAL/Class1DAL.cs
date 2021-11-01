using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class1DAL : Database
    {

        #region "Attendance & Orders"
        //PATIENT_Select
        public DataSet selectData1(decimal? USERID, decimal? USERIDTo, string checkDateFrom, string checkDateTo, string branchname)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd)
            {
                cmd.Parameters.AddWithValue("@A", "Taha");
                cmd.Parameters.AddWithValue("@B", "123");

                cmd.Connection = new SqlConnection(GotoDBKey("Con"));
                cmd.CommandText = "Att_Select";
                return ExecuteDataSet(cmd);
            }
        }    
        #endregion
    }
}
