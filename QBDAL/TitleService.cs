using QBModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QBDAL
{
    public static partial class TitleService
    {
        /// <summary>
        /// 添加题目
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static title AddTitle(title title)
        {
            string sql =
                "INSERT title(Tnum,Tstem,Tsubject,Ttype,Tanswer)" +
                "VALUES (@Tnum,@Tstem,@Tsubject,@Ttype,@Tanswer)";
            sql += ";SELECT @ @IDENTITY";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Tstem",title.Tstem1),
                    new SqlParameter("@Tsubject",title.Tsubject1),
                    new SqlParameter("@Ttype",title.Ttype1),
                    new SqlParameter("@Tanswer",title.Tanswer1),
                };
                string newNum = DBHelper.GetScalar(sql,para).ToString();
                return GetByTitleNum(newNum);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 根据题目号获取题目
        /// </summary>
        /// <param name="Tnum"></param>
        /// <returns></returns>
        public static title GetByTitleNum(string Tnum)
        {
            string sql = "SELECT * FROM title WHERE Tnum = @Tnum";
            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Tnum", Tnum));
                if (reader.Read())
                {
                    title title = new title();
                    title.Tnum1 = (string)reader["Tnum"];
                    title.Tstem1 = (string)reader["Tstem"];
                    title.Tsubject1 = (string)reader["Tsubject"];
                    title.Ttype1 = (string)reader["Ttype"];
                    title.Tanswer1 = (string)reader["Tanswer"];
                    reader.Close();
                    return title;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        //删除题目
        public static void DeleteTitle(title title)
        {
            DeleteTitleByTitleNum(title.Tnum1);
        }
        //删除题目
        public static void DeleteTitleByTitleNum(string Tnum1)
        {
            string sql = "DELETE title WHERE Tnum = @Tnum";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Tnum",Tnum1)
                };
                DBHelper.ExecuteCommand(sql, para);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 修改题目信息
        /// </summary>
        /// <param name="title"></param>
        public static void ModifyTitle(title title)
        {
            string sql =
                "UPDATE title" +
                "SET" +
                    "Tname=@Tname," +
                    "Tstem=@Tsteum" +
                    "Tsubject=@Tsubject" +
                    "Ttype=@Ttype" +
                "WHERE Tnum=@Tnum";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Tnum",title.Tnum1),
                    new SqlParameter("@Tstem",title.Tstem1),
                    new SqlParameter("@Tsubject",title.Tsubject1),
                    new SqlParameter("@Tanswer",title.Tanswer1),
                };
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 获取所有题目
        /// </summary>
        /// <returns></returns>
        public static IList<title> GetAllTitle()
        {
            string sqlAll = "SELECT * FROM title";
            return GetTitleBySql(sqlAll);
        }
        /// <summary>
        /// 根据sql获取题目
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static IList<title> GetTitleBySql(string safeSql)
        {
            List<title> list = new List<title>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql);
                foreach (DataRow row in table.Rows)
                {
                    title title = new title();
                    title.Tnum1 = (string)row["Tnum"];
                    title.Tstem1 = (string)row["Tstem"];
                    title.Tsubject1 = (string)row["Tsubject"];
                    title.Ttype1 = (string)row["Ttype"];
                    title.Tanswer1 = (string)row["Tanswer"];
                    list.Add(title);
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
        /// <summary>
        /// 根据sql带参数查找题目
        /// </summary>
        /// <param name="safeSql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IList<title> GetTitleBySql(string safeSql, params SqlParameter[] values)
        {
            List<title> list = new List<title>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql, values);
                foreach (DataRow row in table.Rows)
                {
                    title title = new title();
                    title.Tnum1 = (string)row["Tnum"];
                    title.Tstem1 = (string)row["Tstem"];
                    title.Tsubject1 = (string)row["Tsubject"];
                    title.Ttype1 = (string)row["Ttype"];
                    title.Tanswer1 = (string)row["Tanswer"];
                    list.Add(title);
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
        /// <summary>
        /// 插入选项
        /// </summary>
        /// <param name="options"></param>
        public static void AddOptions(options options,title title)
        {
            string sql = "INSERT OT(Onum,Tnum) VALUES(@Onum,@Tnum)";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Onum",options.Onum1),
                    new SqlParameter("@Tnum",options.Onum1),
                };
                sql += sql += ";SELECT @ @IDENTITY";
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        //按选项号删除题目中一个选项
        public static void DeleteByTitlekNum(string Onum, string Tnum)
        {
            string sql = "DELETE OT WHERE Onum = @Onum and Tnum=@Tnum";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Onum",Onum),
                    new SqlParameter("@Tnum",Tnum)
                };
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 获取某题目选项列表
        /// </summary>
        /// <returns></returns>
        public static IList<options> GetAllOptions(title title)
        {
            string sqlAll = "SELECT * FROM OT WHERE Tnum=@Tnum";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Tnum",title.Tnum1)
            };
            return GetOptionsBySql(sqlAll,para);
        }
        /// <summary>
        /// 根据sql获取题目
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static IList<options> GetOptionsBySql(string safeSql,SqlParameter[] values)
        {
            List<options> list = new List<options>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql, values);
                foreach (DataRow row in table.Rows)
                {
                    options options = new options();
                    options.Onum1 = (int)row["Onum"];
                    options.Oname1 = (string)row["Oname"];
                    options.Otext1 = (string)row["Otext"];
                    list.Add(options);
                }
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
    }
}
