using Jaylosy.Kernel.Database;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Jaylosy.Kernel.Extension
{
    public class ExecuteModel
    {
        public string Sql { get; set; }
        private System.Data.CommandType _CommandType = System.Data.CommandType.Text;
        public System.Data.CommandType CommandType
        {
            get { return _CommandType; }
            set { _CommandType = value; }
        }
        public DbParameter[] Parameters { get; set; }
    }
    public static class DatabaseExtension
    {
        public static int ExecuteSingleSql(this IDatabase db, List<string> sqlList)
        {
            List<ExecuteModel> executeList = new List<ExecuteModel>();
            foreach(var sql in sqlList)
            {
                executeList.Add(new ExecuteModel
                {
                    Sql = sql,
                    Parameters = null
                });
            }
            return db.ExecuteSingleSql(executeList);
        }
        public static int ExecuteSingleSql(this IDatabase db,List<ExecuteModel> executeList)
        {
            using(var con = db.CreateCon())
            {
                try
                {
                    int i = 0;
                    con.Open();
                    var trans = con.BeginTransaction();
                    var cmd = con.CreateCommand();
                    try
                    {
                        foreach (var execute in executeList)
                        {
                            cmd.ExecuteNonQueryWithTrans(execute.Sql,execute.CommandType,execute.Parameters, trans);
                            i++;
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                    trans.Commit();
                    return i;
                }
                catch (Exception ex)
                {
                    db.SetLastDbError(ex.ToString());
                    return -1;
                }
                finally
                {
                    con.Close();
                    GC.Collect();
                }
            }
        }


        public static int ExecuteProcedure(this IDatabase db, string prcName,DbParameter[] parameters)
        {
            using (var con = db.CreateCon())
            {
                try
                {
                    int i = 0;
                    con.Open();
                    var cmd = con.CreateCommand();
                    cmd.CommandText = prcName;
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.Add(parameters);
                    }
                    cmd.ExecuteNonQuery();
                    return i;
                }
                catch (Exception ex)
                {
                    db.SetLastDbError(ex.ToString());
                    return -1;
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
