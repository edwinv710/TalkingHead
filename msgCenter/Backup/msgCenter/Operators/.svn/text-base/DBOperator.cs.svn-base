using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Odbc;
//using System.Data.OracleClient;// Need to add refference "system.data.oracleclient"
using System.Data.OleDb;

namespace msgCenter.Operators
{
    public class DBOperator
    {
        //private static string connectionstring = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["OracleDB"].ConnectionString;
        private static string connectionstring = string.Empty;
        private static string acc_connectionsStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=test.mdb;";
        public struct Parameter
        {
            public string Name;
            public string Value;
            public bool Quote;

            public Parameter(string name, string value, bool quote)
            {
                Name = name;
                Value = value;
                Quote = quote;
            }
        }

        public const int Operation_Insert = 0;
        public const int Operation_Update = 1;

        //private static string connectionstring = "Data Source=Kashin-Laptop;Initial Catalog=Xiaonei;user id=xn_admin;password=123456;";


        public DBOperator()
        {

        }

        #region SQL Server

        public static DataTable GetDataTable(string sqltext)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand(sqltext, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable GetDataTable(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static DataSet GetDataSet(string sqltext)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand(sqltext, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public static DataSet GetDataSet(string sqltext, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(sqltext, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public static object ExecuteScalar(string sqltext)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand(sqltext, connection);
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();
            return result;
        }

        public static object ExecuteScalar(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            command.Connection = connection;
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();
            return result;
        }

        public static SqlDataReader ExecuteReader(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            command.Connection = connection;
            connection.Open();
            SqlDataReader result = command.ExecuteReader(CommandBehavior.CloseConnection);
            connection.Close();
            return result;
        }

        public static SqlDataReader ExecuteReader(string sqltext)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand(sqltext, connection);
            connection.Open();
            SqlDataReader result = command.ExecuteReader(CommandBehavior.CloseConnection);
            return result;
        }

        public static bool ExcuteNon(string sqltext)
        {

            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand(sqltext, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;

        }

        public static bool ExcuteNon(string sqltext, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand(sqltext, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public static bool ExcuteNon(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public static DataSet GetDataSet(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public static DataSet GetDataSet(SqlCommand command, SqlConnection connection)
        {
            command.Connection = connection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        #endregion


        #region EXCEL
        public static DataSet GetDataSetFromXls(string sqltext, string sFilePath)
        {
            string connstr = "Driver={Microsoft Excel Driver (*.xls)};DriverId=790;Dbq=" + sFilePath + ";DefaultDir=" + sFilePath + ";";
            //connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sFilePath + ";Extended Properties='Excel 8.0;IMEX=1;'";

            OdbcConnection connection = new OdbcConnection(connstr);
            OdbcCommand command = new OdbcCommand(sqltext, connection);
            OdbcDataAdapter adapter = new OdbcDataAdapter(command);
            connection.Open();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            connection.Close();
            return ds;
        }

        public static DataSet OLEDB_GetDataSetFromXls(string sqltext, string sFilePath)
        {
            try
            {
                string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sFilePath + ";Extended Properties=\"Excel 8.0;HDR=no;IMEX=0;\"";
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(connstr);
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(sqltext, connection);
                connection.Open();
                System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(command);
                System.Data.DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                return ds;
            }
            catch (Exception ex)
            {
                string log = "Type: OLEDB Error;  " + "Error Message: " + ex.Message + ";  Error Source: " + ex.Source + ";  Error Track: " + ex.StackTrace + "; SQL Text: " + sqltext + ";  File Path: " + sFilePath;
                //FileOperator.WriteToFile(log);
                return null;
            }

        }

        public static void OLEDB_Xls_ExcuteNon(string sqltext, string sFilePath)
        {
            try
            {
                string connstr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sFilePath + ";Extended Properties=\"Excel 8.0;HDR=no;IMEX=0;\"";
                System.Data.OleDb.OleDbConnection connection = new System.Data.OleDb.OleDbConnection(connstr);
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(sqltext, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                string log = "Type: OLEDB Error;  " + "Error Message: " + ex.Message + ";  Error Source: " + ex.Source + ";  Error Track: " + ex.StackTrace + "; SQL Text: " + sqltext + ";  File Path: " + sFilePath;
                //FileOperator.WriteToFile(log);
            }
        }

        public static string GetSQLText(Parameter[] paraList, string table, string termList, int operation)
        {
            string sqlText = string.Empty;
            switch (operation)
            {
                case Operation_Insert:
                    sqlText = "insert into ";
                    sqlText += table + " ( ";
                    string temp = " values (";
                    foreach (Parameter para in paraList)
                    {
                        sqlText += para.Name + ",";
                        if (para.Quote)
                        {
                            temp += "'" + para.Value + "',";
                        }
                        else
                        {
                            temp += para.Value + ",";
                        }
                    }

                    temp = temp.Remove(temp.Length - 1) + ")";

                    sqlText = sqlText.Remove(sqlText.Length - 1) + temp;
                    return sqlText;
                    break;
                case Operation_Update:
                    sqlText = "Update ";
                    sqlText += table + " set ";
                    foreach (Parameter para in paraList)
                    {
                        if (para.Quote)
                        {
                            sqlText += para.Name + "='" + para.Value + "',";
                        }
                        else
                        {
                            sqlText += para.Name + "=" + para.Value + ",";
                        }
                    }
                    sqlText = sqlText.Remove(sqlText.Length - 1) + " where " + termList;
                    return sqlText;
                    break;
                default:
                    return string.Empty;
                    break;
            }
        }
        #endregion

        #region ACCESS
        public static bool Acc_ExcuteNon(string sqltext)
        {
            //try
            //{
                OleDbConnection connection = new OleDbConnection(acc_connectionsStr);
                OleDbCommand cmd = new OleDbCommand(sqltext, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;

            //}
            //catch (Exception e)
            //{
            //    return false;
            //}

        }

        public static DataSet Acc_GetDataSet(string sqltext)
        {
            OleDbConnection connection = new OleDbConnection(acc_connectionsStr);

            OleDbCommand command = new OleDbCommand(sqltext, connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds);
            connection.Close();
            return ds;


        }
        #endregion


        //#region Oracle
        //public static bool OracleExcuteNon(string sqltext)
        //{

        //    OracleConnection connection = new OracleConnection(connectionstring);
        //    OracleCommand command = new OracleCommand(sqltext, connection);
        //    connection.Open();
        //    command.ExecuteNonQuery();
        //    connection.Close();
        //    return true;

        //}


        //public static DataSet OracleGetDataSet(string sqltext)
        //{
        //    OracleConnection connection = new OracleConnection(connectionstring);
        //    connection.Open();
        //    OracleCommand command = new OracleCommand(sqltext, connection);
        //    OracleDataAdapter adapter = new OracleDataAdapter(command);
        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds);
        //    connection.Close();
        //    return ds;
        //}

        //public static bool OracleExcuteNon(OracleCommand command)
        //{
        //    OracleConnection connection = new OracleConnection(connectionstring);
        //    command.Connection = connection;
        //    connection.Open();
        //    command.ExecuteNonQuery();
        //    connection.Close();
        //    return true;
        //}

        //public static string OracleExcuteScalar(string sqltext)
        //{
        //    OracleConnection connection = new OracleConnection(connectionstring);
        //    OracleCommand command = new OracleCommand(sqltext, connection);
        //    connection.Open();
        //    string result = command.ExecuteScalar().ToString();
        //    connection.Close();
        //    return result;
        //}

        //public static DataSet OracleGetDataSet(OracleCommand command)
        //{
        //    OracleConnection connection = new OracleConnection(connectionstring);
        //    command.Connection = connection;
        //    connection.Open();
        //    OracleDataAdapter adapter = new OracleDataAdapter(command);
        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds);
        //    connection.Close();
        //    return ds;
        //}
        //#endregion
    }
}
