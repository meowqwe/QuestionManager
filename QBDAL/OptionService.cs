using QBModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace QBDAL
{
    public static partial class OptionService
    {
        /// <summary>
        /// 创建一个选项
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static options CreateOption(options options)
        {
            String sql =
                "INSERT options(Onum,Oname,Otext)" +
                "VALUES(@Onum,@Oname,@Otext)";
            sql += ";SELECT @ @IDENTITY";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Oname",options.Oname1),
                    new SqlParameter("@Otext",options.Otext1)
                };
                int newNum = DBHelper.GetScalar(sql, para);
                return GetOptionByNum(newNum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 由选项号查找
        /// </summary>
        /// <param name="Onum"></param>
        /// <returns></returns>
        public static options GetOptionByNum(int Onum)
        {
            string sql = "SELECT * FROM options WHERE Onum = @Onum";
            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Onum", Onum));
                if (reader.Read())
                {
                    options options = new options();
                    options.Onum1 = (int)reader["Onum"];
                    options.Oname1 = (string)reader["Oname"];
                    options.Otext1 = (string)reader["Otext"];
                    reader.Close();
                    return options;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        //删除选项
        public static void DeleteOptions(options options)
        {
            DeleteByOptionsNum(options.Onum1);
        }
        //删除选项
        public static void DeleteByOptionsNum(int Onum)
        {
            string sql = "DELETE options WHERE Onum = @Onum";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Onum",Onum)
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
        /// 修改选项信息
        /// </summary>
        /// <param name="options"></param>
        public static void ModifyOptions(options options)
        {
            string sql =
                "UPDATE options" +
                "SET" +
                    "Oname=@Oname," +
                    "Otext=@Otext" +
                "WHERE Onum=@Onum";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Onum",options.Onum1),
                    new SqlParameter("@Oname",options.Oname1),
                    new SqlParameter("@Otext",options.Otext1),
                };
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
