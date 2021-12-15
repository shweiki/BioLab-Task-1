using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PremiumsDiscountStaff_P : Database
    {
        #region "DAL_PremiumsDiscountStaff_P"
        public DataSet Get(int? PD, DateTime fromdate, DateTime todate, String option,int? empno, int? empno2, string empname, int? branchno, int? departmentno)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd)
            {
              cmd.Parameters.AddWithValue("@PD", PD);
              cmd.Parameters.AddWithValue("@option", option);
              cmd.Parameters.AddWithValue("@todate", todate);
              cmd.Parameters.AddWithValue("@fromdate", fromdate);
              cmd.Parameters.AddWithValue("@empno", empno);
              cmd.Parameters.AddWithValue("@empno2", empno2);
              cmd.Parameters.AddWithValue("@empname", empname);
              cmd.Parameters.AddWithValue("@branchno", branchno);
              cmd.Parameters.AddWithValue("@departmentno", departmentno);

                cmd.Connection = new SqlConnection(GotoDBKey("SCon"));
               // cmd.CommandText = "hr_salary_basicinformation_Select";
                return ExecuteDataSet(cmd);
            }
        }
      #endregion
    }
}
