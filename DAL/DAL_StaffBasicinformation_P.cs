using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_StaffBasicinformation_P : Database
    {
        #region "DAL_StaffBasicinformation_P"
        public DataSet Get(int? empno, int? empno2, string empname)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd)
            {
                cmd.Parameters.AddWithValue("@empno", empno);
                cmd.Parameters.AddWithValue("@empno2", empno2);
                cmd.Parameters.AddWithValue("@empname", empname);


                cmd.Connection = new SqlConnection(GotoDBKey("SCon"));
                cmd.CommandText = "hr_staff_basicinformation_listSelect";
                return ExecuteDataSet(cmd);
            }
        }
        #endregion
    }
}
