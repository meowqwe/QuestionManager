using QBDAL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Configuration;

namespace QBDAL
{
    public class UserService
    {
        /// <summary>
        /// 添加User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static User AddUser(User user)
        {
            string sql =
                "INSERT Userdetail (Uusername,Upassword,Usex,Uclass,Ugrade,Urole)" +
                "VALUES (@userName,@userPass,@sex,@class,@grade,@role)";
            sql += ";SELECT @ @IDENTITY";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                       new SqlParameter("@userName",user.UuserName1),
                       new SqlParameter("@userPass",user.UpassWord1),
                       new SqlParameter("@sex",user.Usex1),
                       new SqlParameter("@class",user.Uclass1),
                       new SqlParameter("@grade",user.Ugrade1),
                       new SqlParameter("@role",user.Urole1)
                };
                DBHelper.GetScalar(sql, para);
                return GetUserByUserId(user.UuserName1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        ///<summary>
        /// 删除User
        /// </summary>
        /// <param name="user"></param>
        public static void DeleteUser(User user)
        {
            DeleteUserByUserId(user.UuserName1);
        }
        /// <summary>
        /// 根据userId删除用户
        /// </summary>
        /// <param name="uuserName1"></param>
        public static void DeleteUserByUserId(string uuserName1)
        {
            string sql = "DELETE Userdetail WHERE Uusername = @UserId";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@UserId",uuserName1)
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
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        public static void ModifyUser(User user)
        {
            string sql =
                "UPDATE userdetails" +
                "SET" +
                    "Upassword = @userPass," +
                    "Usex = @sex," +
                    "Uclass = @class," +
                    "Ugrade = @grade," +
                    "Urole = @role" +
                "WHERE Uusername = @userName";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@userName",user.UuserName1),
                       new SqlParameter("@userPass",user.UpassWord1),
                       new SqlParameter("@sex",user.Usex1),
                       new SqlParameter("@class",user.Uclass1),
                       new SqlParameter("@grade",user.Ugrade1),
                       new SqlParameter("@role",user.Urole1)
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
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public static IList<User> GetAllUsers()
        {
            string sqlAll = "SELECT * FROM Userdetail";
            return GetUserBySql(sqlAll);
        }
        public static User GetUserByUserId(string userId)
        {
            string sql = "SELECT * FROM Userdetail WHERE Uusername = @UserId";
            try
            {
                SqlParameter[] para = new SqlParameter[] { new SqlParameter("@UserId", userId) };
                SqlDataReader reader = DBHelper.GetReader(sql, para);
                if (reader.Read())
                {
                    User user = new User();
                    user.UuserName1 = (string)reader["Uusername"];
                    user.UpassWord1 = (string)reader["Upassword"];
                    user.Usex1 = (string)reader["Usex"];
                    user.Uclass1 = (string)reader["Uclass"];
                    user.Ugrade1 = (string)reader["Ugrade"];
                    user.Urole1 = (int)reader["Urole"];
                    reader.Close();
                    return user;
                }
                else
                {
                    //reader.Close();
                    return null;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
        /// <summary>
        /// 根据sql获取用户列表，带参数
        /// </summary>
        /// <param name="sqlAll"></param>
        /// <returns></returns>
        private static IList<User> GetUserBySql(string safeSql)
        {
            List<User> list = new List<User>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql);
                foreach(DataRow row in table.Rows)
                {
                    User user = new User();
                    user.UuserName1 = (string)row["Uusername"];
                    user.UpassWord1 = (string)row["Upassword"];
                    user.Usex1 = (string)row["Usex"];
                    user.Uclass1 = (string)row["Uclass"];
                    user.Ugrade1 = (string)row["Ugrade"];
                    user.Urole1 = (int)row["Urole"];
                    list.Add(user);
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
        /// 将收藏夹分配给用户
        /// </summary>
        /// <param name="Favorite"></param>
        /// <param name="User"></param>
        public static void FavoriteAppend(Favorite Favorite, User User)
        {
            string sql = "INSERT UF(Uusername,Fname) VALUES(@Uusername,@Fname)";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Uusername",User.UuserName1),
                    new SqlParameter("@Fname",Favorite.Fname1)
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
        //按题号删除用户中一个收藏夹
        public static void DeleteByFavoritekNum(string Fname, string Uusername)
        {
            string sql = "DELETE UF WHERE Fname = @Fname and Uusername=@Uusername";
            try
            {
                SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@Fname",Fname),
                    new SqlParameter("@Uusername",Uusername)
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
        /// 根据sql获取收藏夹
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static IList<Favorite> GetFavoriteBySql(string safeSql, SqlParameter[] para)
        {
            List<Favorite> list = new List<Favorite>();
            try
            {
                DataTable table = DBHelper.GetDataSet(safeSql, para);
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
    }
}
