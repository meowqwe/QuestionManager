using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
//using System.Configuration;


namespace QBDAL
{
	//数据库访问基础类
	public static class DBHelper
	{

		private static SqlConnection connection;
		//连接属性
		public static SqlConnection Connection
		{
			get
			{
				//从配置文件中获取连接数据库的连接字符串
				//string connectionString = ConfigurationManager.ConnectionStrings["QBConStr"].ConnectionString;
				string connectionString = "";
				if (connection == null)
				{
					connection = new SqlConnection(connectionString);
					connection.Open();
				}
				else if (connection.State == System.Data.ConnectionState.Closed)
				{
					connection.Open();
				}
				else if (connection.State == System.Data.ConnectionState.Broken)
				{
					connection.Close();
					connection.Open();
				}
				return connection;
			}
		}
		//不带参数的执行命令
		public static int ExecuteCommand(string safeSql)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(safeSql, Connection);
				int result = cmd.ExecuteNonQuery();
				return result;
			}
			finally
			{
				Connection.Close();
			}

		}
		//带参数的执行命令
		public static int ExecuteCommand(string sql, params SqlParameter[] values)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(sql, Connection);
				cmd.Parameters.AddRange(values);
				return cmd.ExecuteNonQuery();
			}
			finally
			{
				Connection.Close();
			}
		}

		public static int GetScalar(string safeSql)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(safeSql, Connection);
				int result = Convert.ToInt32(cmd.ExecuteScalar());
				return result;
			}
			finally
			{
				Connection.Close();
			}

		}
		public static int GetScalar(string sql, params SqlParameter[] values)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(sql, Connection);
				cmd.Parameters.AddRange(values);
				int result = Convert.ToInt32(cmd.ExecuteScalar());
				return result;
			}
			finally
			{
				Connection.Close();
			}

		}

		public static SqlDataReader GetReader(string safeSql)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(safeSql, Connection);
				SqlDataReader reader = cmd.ExecuteReader();
				return reader;
			}
			finally
			{
				Connection.Close();
			}

		}

		public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(sql, Connection);
				cmd.Parameters.AddRange(values);
				SqlDataReader reader = cmd.ExecuteReader();
				return reader;
			}
			finally
			{
				Connection.Close();
			}

		}

		public static DataTable GetDataSet(string safeSql)
		{
			DataSet ds = new DataSet();
			SqlCommand cmd = new SqlCommand(safeSql, Connection);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(ds);
			return ds.Tables[0];
		}

		public static DataTable GetDataSet(string sql, params SqlParameter[] values)
		{
			DataSet ds = new DataSet();
			SqlCommand cmd = new SqlCommand(sql, Connection);
			cmd.Parameters.AddRange(values);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(ds);
			return ds.Tables[0];
		}

	}
}
