using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using QBModels;

namespace QBDAL
{
    public static partial class QuestionBankService
    {
        /// <summary>
        /// 创建空题库
        /// </summary>
        /// <param name="questionBank"></param>
        /// <returns></returns>
        public static QuestionBank CreateBlankQuestionBank(QuestionBank questionBank)
        {
            String sql =
                "INSERT questionbank(QBnum,QBname,QBqnum)" +
                "VALUES(@QBnum,@QBname,@QBqnum)";
            sql += ";SELECT @ @IDENTITY";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@QBname",questionBank.QBname1),
                    new SqlParameter("@QBanum",questionBank.QBqnum1)
                };
                string newNum = DBHelper.GetScalar(sql, para).ToString();
                return GetQuestionBankByQBnum(newNum);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 根据题库号获取题库信息
        /// </summary>
        /// <param name="QBnum"></param>
        /// <returns></returns>
        public static QuestionBank GetQuestionBankByQBnum(string QBnum)
        {
            string sql = "SELECT * FROM questionbank WHERE QBnum = @QBnum";
            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql,new SqlParameter("@QBnum",QBnum));
                if (reader.Read())
                {
                    QuestionBank questionbank = new QuestionBank();
                    questionbank.QBnum1 = (string)reader["QBnum"];
                    questionbank.QBname1 = (string)reader["QBname"];
                    questionbank.QBqnum1 = (int)reader["QBqnum"];
                    reader.Close();
                    return questionbank;
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
        //删除题库
        public static void DeleteQuestionBank(QuestionBank questionBank)
        {
            DeleteByQuestionBankNum(questionBank.QBnum1);
        }
        //删除题库
        public static void DeleteByQuestionBankNum(string qBnum1)
        {
            string sql = "DELETE questionbank WHERE QBnum = @QBnum";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@QBnum",qBnum1)
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
        /// 修改题库信息
        /// </summary>
        /// <param name="questionBank"></param>
        public static void ModifyQuestionBank(QuestionBank questionBank)
        {
            string sql =
                "UPDATE questionbank" +
                "SET" +
                    "QBname=@QBname," +
                    "QBqnum=@QBqnum" +
                "WHERE QBnum=@QBnum";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@QBnum",questionBank.QBnum1),
                    new SqlParameter("@QBname",questionBank.QBname1),
                    new SqlParameter("@QBqnum",questionBank.QBqnum1),
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
        /// 获取所有题库
        /// </summary>
        /// <returns></returns>
        public static IList<QuestionBank> GetAllQuestionBank()
        {
            string sqlAll = "SELECT * FROM questionbank";
            return GetQuestionBankBySql(sqlAll);
        }
        /// <summary>
        /// 根据题库名称获取题库
        /// </summary>
        /// <param name="QBname"></param>
        /// <returns></returns>
        public static QuestionBank GetQuestionBankByName(string QBname)
        {
            string sql = "SELECT * FROM questionbank WHERE QBname=@QBname";
            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@QBname", QBname));
                if (reader.Read())
                {
                    QuestionBank questionBank = new QuestionBank();
                    questionBank.QBnum1 = (string)reader["QBnum"];
                    questionBank.QBname1 = (string)reader["QBname"];
                    questionBank.QBqnum1 = (int)reader["QBqnum"];
                    reader.Close();
                    return questionBank;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 根据sql获取题库
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static IList<QuestionBank> GetQuestionBankBySql(string safeSql)
        {
            List<QuestionBank> list = new List<QuestionBank>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql);
                foreach(DataRow row in table.Rows)
                {
                    QuestionBank questionbank = new QuestionBank();
                    questionbank.QBnum1 = (string)row["QBnum"];
                    questionbank.QBname1 = (string)row["QBname"];
                    questionbank.QBqnum1 = (int)row["QBqnum"];
                    list.Add(questionbank);
                }
                return list;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }
        /// <summary>
        /// 根据sql带参数查找题库
        /// </summary>
        /// <param name="safeSql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IList<QuestionBank> GetQuestionBankBySql(string safeSql,params SqlParameter[] values)
        {
            List<QuestionBank> list = new List<QuestionBank>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql,values);
                foreach (DataRow row in table.Rows)
                {
                    QuestionBank questionbank = new QuestionBank();
                    questionbank.QBnum1 = (string)row["QBnum"];
                    questionbank.QBname1 = (string)row["QBname"];
                    questionbank.QBqnum1 = (int)row["QBqnum"];
                    list.Add(questionbank);
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
        /// 将一个题目插入到一个题库中
        /// </summary>
        /// <param name="title"></param>
        /// <param name="questionBank"></param>
        public static void TitleAppend(title title,QuestionBank questionBank)
        {
            string sql = "INSERT QBT(QBname,Tnum) VALUES(@QBname,@Tnum)";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@QBname",questionBank.QBname1),
                    new SqlParameter("@Tnum",questionBank.QBname1),
                };
                sql+= sql += ";SELECT @ @IDENTITY";
                DBHelper.ExecuteCommand(sql, para);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        //按题号删除题库中一个题目
        public static void DeleteByTitlekNum(string qBname,string Tnum)
        {
            string sql = "DELETE QBT WHERE QBname = @QBname and Tnum=@Tnum";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@QBname",qBname),
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
        /// 获取某题库题目列表
        /// </summary>
        /// <returns></returns>
        public static IList<title> GetAllTitle(QuestionBank questionBank)
        {
            string sqlAll = "SELECT * FROM QBT WHERE QBname=@QBname";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@QBname",questionBank.QBname1)
            };
            return GetTitleBySql(sqlAll,para);
        }
        /// <summary>
        /// 根据sql获取题目
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static IList<title> GetTitleBySql(string safeSql,SqlParameter[] para)
        {
            List<title> list = new List<title>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql,para);
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
    }
}
