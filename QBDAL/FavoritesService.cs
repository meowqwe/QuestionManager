using QBModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace QBDAL
{
    public static partial class FavoritesService
    {
        /// <summary>
        /// 创建空收藏夹
        /// </summary>
        /// <param name="Favorite"></param>
        /// <returns></returns>
        public static Favorite CreateBlankFavorite(Favorite Favorite)
        {
            String sql =
                "INSERT Favorites(Fname,QBnumber)" +
                "VALUES(@Fname,@QBnumber)";
            sql += ";SELECT @ @IDENTITY";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@QBnumber",Favorite.Fname1)
                };
                string newNum = DBHelper.GetScalar(sql, para).ToString();
                return GetFavoriteByNum(newNum);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 根据收藏夹号获取收藏夹信息
        /// </summary>
        /// <param name="Fname"></param>
        /// <returns></returns>
        public static Favorite GetFavoriteByNum(string Fname)
        {
            string sql = "SELECT * FROM Favorites WHERE Fname = @Fname";
            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Fname", Fname));
                if (reader.Read())
                {
                    Favorite Favorite = new Favorite();
                    Favorite.QBnumber1 = (int)reader["QBnumber"];
                    Favorite.Fname1 = (string)reader["Fname"];
                    reader.Close();
                    return Favorite;
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
        //删除收藏夹
        public static void DeleteFavorite(Favorite Favorite)
        {
            DeleteByFavoriteNum(Favorite.Fname1);
        }
        //删除收藏夹
        public static void DeleteByFavoriteNum(string Fname1)
        {
            string sql = "DELETE Favorites WHERE Fname = @Fname";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Fname",Fname1)
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
        /// 修改收藏夹信息
        /// </summary>
        /// <param name="Favorite"></param>
        public static void ModifyFavorite(Favorite Favorite)
        {
            string sql =
                "UPDATE Favorites" +
                "SET" +
                    "QBnumber=@QBnumber" +
                "WHERE Fname=@Fname";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Fname",Favorite.Fname1),
                    new SqlParameter("@QBnumber",Favorite.QBnumber1),
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
        /// 获取所有收藏夹
        /// </summary>
        /// <returns></returns>
        public static IList<Favorite> GetAllFavorite()
        {
            string sqlAll = "SELECT * FROM Favorite";
            return GetFavoriteBySql(sqlAll);
        }
        /// <summary>
        /// 根据收藏夹名称获取收藏夹
        /// </summary>
        /// <param name="Fname"></param>
        /// <returns></returns>
        public static Favorite GetFavoriteByName(string Fname)
        {
            string sql = "SELECT * FROM Favorite WHERE Fname=@Fname";
            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql, new SqlParameter("@Fname", Fname));
                if (reader.Read())
                {
                    Favorite Favorite = new Favorite();
                    Favorite.Fname1 = (string)reader["Fname"];
                    Favorite.QBnumber1 = (int)reader["QBnumber"];
                    reader.Close();
                    return Favorite;
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
        /// <summary>
        /// 根据sql获取收藏夹
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static IList<Favorite> GetFavoriteBySql(string safeSql)
        {
            List<Favorite> list = new List<Favorite>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql);
                foreach (DataRow row in table.Rows)
                {
                    Favorite Favorite = new Favorite();
                    Favorite.Fname1 = (string)row["Fname"];
                    Favorite.QBnumber1 = (int)row["QBnumber"];
                    list.Add(Favorite);
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
        /// 根据sql带参数查找收藏夹
        /// </summary>
        /// <param name="safeSql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static IList<Favorite> GetFavoriteBySql(string safeSql, params SqlParameter[] values)
        {
            List<Favorite> list = new List<Favorite>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql, values);
                foreach (DataRow row in table.Rows)
                {
                    Favorite Favorite = new Favorite();
                    Favorite.QBnumber1 = (int)row["QBnumber"];
                    Favorite.Fname1 = (string)row["Fname"];
                    list.Add(Favorite);
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
        /// 将一个题库插入到一个收藏夹中
        /// </summary>
        /// <param name="questionBank"></param>
        /// <param name="Favorite"></param>
        public static void QuestionBankAppend(QuestionBank questionBank, Favorite Favorite)
        {
            string sql = "INSERT FQB(Fname,QBname) VALUES(@Fname,@QBname)";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Fname",Favorite.Fname1),
                    new SqlParameter("@QBname",questionBank.QBname1)
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
        //按题号删除收藏夹中一个题库
        public static void DeleteByQuestionBankkNum(string Fname, string QBname)
        {
            string sql = "DELETE FQB WHERE Fname = @Fname and QBname=@QBname";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Fname",Fname),
                    new SqlParameter("@Tnum",QBname)
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
        /// 获取某收藏夹题库列表
        /// </summary>
        /// <returns></returns>
        public static IList<QuestionBank> GetAllQuestionBank(Favorite Favorite)
        {
            string sqlAll = "SELECT * FROM FQB WHERE Fname=@Fname";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Fname",Favorite.Fname1)
            };
            return GetQuestionBankBySql(sqlAll, para);
        }
        /// <summary>
        /// 根据sql获取题库
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static IList<QuestionBank> GetQuestionBankBySql(string safeSql, SqlParameter[] para)
        {
            List<QuestionBank> list = new List<QuestionBank>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql, para);
                foreach (DataRow row in table.Rows)
                {
                    QuestionBank QuestionBank = new QuestionBank();
                    QuestionBank.QBname1 = (string)row["QBnum"];
                    QuestionBank.QBnum1 = (string)row["QBname"];
                    QuestionBank.QBqnum1 = (int)row["QBQnum"];
                    list.Add(QuestionBank);
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
        /// 获取某用户收藏夹列表
        /// </summary>
        /// <returns></returns>
        public static IList<Favorite> GetAllFavorite(User User)
        {
            string sqlAll = "SELECT * FROM UF WHERE Uusername=@Uusername";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Uusername",User.UuserName1)
            };
            return GetFavoriteBySql(sqlAll, para);
        }
    }
}
