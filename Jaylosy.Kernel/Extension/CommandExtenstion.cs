using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Jaylosy.Kernel.Extension
{
    public static class CommandExtenstion
    {
        public static int ExecuteNonQueryWithTrans(this IDbCommand cmd, string sql, IDbTransaction transaction)
        {
            return ExecuteNonQueryWithTrans(cmd, sql,null, transaction);
        }
        public static int ExecuteNonQueryWithTrans(this IDbCommand cmd, string sql,IDbDataParameter[] parameters, IDbTransaction transaction)
        {
            return ExecuteNonQueryWithTrans(cmd, sql, CommandType.Text, null, transaction);
        }
        public static int ExecuteNonQueryWithTrans(this IDbCommand cmd,string sql,CommandType commandType,IDbDataParameter[] parameters,IDbTransaction transaction)
        {
            cmd.Transaction = transaction;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            if(parameters!=null&& parameters.Length > 0)
            {
                foreach(var parm in parameters)
                {
                    cmd.Parameters.Add(parm);
                }
            }
            return cmd.ExecuteNonQuery();
        }
    }
}
