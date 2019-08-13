using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Data.SqlClient;
using System.Data.OracleClient;

namespace Jaylosy.Kernel.Database
{
    public abstract class BaseDatabase : IDatabase
    {
        const string SqlProvider = "System.Data.SqlClient";
        const string OracleProvider = "System.Data.OracleClient";
        string _DbProvider;
        string _ConnectionString;
        string _LastDbError;
        public string DbProvider
        {
            get { return _DbProvider; }
        }
        public string LastDbError
        {
            get { return _LastDbError; }
        }
        public string ConnectionString
        {
            get { return _ConnectionString; }
        }
        public BaseDatabase(string dbKey)
        {
            try
            {
                _ConnectionString = ConfigurationManager.ConnectionStrings[dbKey].ConnectionString;
                _DbProvider = ConfigurationManager.ConnectionStrings[dbKey].ProviderName;
                if (string.IsNullOrEmpty(_DbProvider))
                {
                    _DbProvider = SqlProvider;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DbConnection CreateCon()
        {
            if (_DbProvider == OracleProvider)
            {
                return new OracleConnection(_ConnectionString);
            }
            else
            {
                return new SqlConnection(_ConnectionString);
            }
        }
        public DbDataAdapter CreateDataAdapter(DbCommand cmd)
        {
            if (_DbProvider == OracleProvider)
            {
                return new OracleDataAdapter((OracleCommand)cmd);
            }
            else
            {
                return new SqlDataAdapter((SqlCommand)cmd);
            }
        }
        public DbDataAdapter CreateDataAdapter(string sql, DbConnection con)
        {
            if (_DbProvider == OracleProvider)
            {
                return new OracleDataAdapter(sql,(OracleConnection)con);
            }
            else
            {
                return new SqlDataAdapter(sql, (SqlConnection)con);
            }
        }

        public DataSet QueryDataset(string sql)
        {
            return QueryDataset(sql, null);
        }

        public DataSet QueryDataset(string sql, DbParameter[] parameters)
        {
            using (var con = CreateCon())
            {
                DataTable table = new DataTable();
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    DataSet ds = new DataSet();
                    var dapt = CreateDataAdapter(cmd);
                    dapt.Fill(ds);
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        return ds;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    SetLastDbError(ex.ToString());
                    return null;
                }
                finally
                {
                    con.Close();
                    GC.Collect();
                }
            }
        }

        public int ExecuteSingleSql(string sql)
        {
            return ExecuteSingleSql(sql, null);
        }

        public int ExecuteSingleSql(string sql, DbParameter[] parameters)
        {
            using (var con = CreateCon())
            {
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                    return 0;
                }
                catch (Exception ex)
                {
                    SetLastDbError(ex.ToString());
                    return -1;
                }
                finally
                {
                    con.Close();
                    GC.Collect();
                }
            }
        }

        public object ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, null);
        }

        public object ExecuteScalar(string sql, DbParameter[] parameters)
        {
            using (var con = CreateCon())
            {
                try
                {
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    SetLastDbError(ex.ToString());
                    return null;
                }
                finally
                {
                    con.Close();
                    GC.Collect();
                }
            }
        }

        public DataTable QueryDatatable(string sql)
        {
            return QueryDatatable(sql, null);
        }

        public DataTable QueryDatatable(string sql, DbParameter[] parameters)
        {
            DataSet ds = QueryDataset(sql, parameters);
            if (ds != null)
            {
                return ds.Tables[0];
            }
            else
            {
                return null;
            }
        }

        public void SetLastDbError(string error)
        {
            _LastDbError = error;
        }
    }
}
