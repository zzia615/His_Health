using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Jaylosy.Kernel.Database
{
    public interface IDatabase
    {
        string LastDbError { get; }
        string DbProvider { get; }
        string ConnectionString { get;  }
        void SetLastDbError(string error);
        DbConnection CreateCon();
        DbDataAdapter CreateDataAdapter(DbCommand cmd);
        DbDataAdapter CreateDataAdapter(string sql,DbConnection con);
        object ExecuteScalar(string sql);
        object ExecuteScalar(string sql, DbParameter[] parameters);
        int ExecuteSingleSql(string sql);
        int ExecuteSingleSql(string sql, DbParameter[] parameters);
        DataSet QueryDataset(string sql);
        DataSet QueryDataset(string sql, DbParameter[] parameters);
        DataTable QueryDatatable(string sql);
        DataTable QueryDatatable(string sql, DbParameter[] parameters);
    }
}
