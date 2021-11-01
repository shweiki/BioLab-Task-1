using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class Database
    {
        internal SqlDataReader Reader;
        internal SqlDataAdapter Adapter;
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();

        public string GotoDBKey(string Con)
        {
            string Conn = ConfigurationManager.AppSettings[Con];
            return Conn;
        }      

        public DataSet ExecuteDataSet(SqlCommand cmd)
        {
            using (cmd)
            {
                cmd.CommandType = CommandType.StoredProcedure;                
                cmd.CommandTimeout = 5000;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                Adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                try
                {
                    Adapter.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    return null;
                }
                finally
                {
                }
            }
        }

        public SqlCommand ExecuteCommand(string CommandText)
        {
            com = new System.Data.SqlClient.SqlCommand();
            com.CommandText = CommandText;
            var _with2 = com;
            _with2.CommandType = CommandType.Text;
            _with2.Connection = new SqlConnection();

            try
            {
                _with2.Connection.Open();
                com.ExecuteScalar();

                return com;

            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                _with2.Connection.Close();
            }
        }

        public SqlCommand Executevalue(SqlCommand cmd)
        {
            //DataAccessLayer

            com = new System.Data.SqlClient.SqlCommand();
            com = cmd;
            var _with4 = com;
            _with4.CommandType = CommandType.StoredProcedure;
            _with4.Connection = new SqlConnection();

            try
            {
                _with4.Connection.Open();
                com.ExecuteScalar();

                return com;

            }
            catch (Exception ex)
            {
                //MsgBox(ex.Message);
                return null;
            }
            finally
            {
                _with4.Connection.Close();
            }
        }
    }
}
