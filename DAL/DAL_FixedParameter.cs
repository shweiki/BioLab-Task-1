using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_FixedParameter : Database
    {
        #region "fixedParameter"
        public DataSet Get()
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd)
            {
                cmd.Parameters.AddWithValue("@flag", 0);
                cmd.Connection = new SqlConnection(GotoDBKey("Con"));
                cmd.CommandText = "P_fixedParameter";
                return ExecuteDataSet(cmd);
            }
        }
        public DataSet Set(int id,decimal Hourovertime , decimal highestsalary , decimal expmarroed ,decimal socialper , decimal expsingle)
        {
            SqlCommand cmd = new SqlCommand();
            using (cmd)
            {
                cmd.Parameters.AddWithValue("@flag", 1);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Hourovertime", Hourovertime);
                cmd.Parameters.AddWithValue("@highestsalary", highestsalary);
                cmd.Parameters.AddWithValue("@expmarroed", expmarroed);
                cmd.Parameters.AddWithValue("@socialper", socialper);
                cmd.Parameters.AddWithValue("@expsingle", expsingle);

                cmd.Connection = new SqlConnection(GotoDBKey("Con"));
                cmd.CommandText = "P_fixedParameter";
                return ExecuteDataSet(cmd);
            }
        }    
        #endregion
    }
}
