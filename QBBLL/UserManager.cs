using QBModels;
using QBDAL;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace QBBLL
{
    public class UserManager
    {
        //添加用户
        public static User AddUser(User user)
        {
            return UserService.AddUser(user);
        }
        //删除用户
        public static void DeleteUser(User user)
        {
            UserService.DeleteUser(user);
        }
        //根据username删除用户
        public static void DeleteUserByUserName(string username)
        {
            UserService.DeleteUserByUserId(username);
        }
        //修改用户
        public static void ModifyUser(User user)
        {
            UserService.ModifyUser(user);
        }
        //获取所有用户
        public static IList<User> GetAllUsers()
        {
            return UserService.GetAllUsers();
        }
        //根据username获取用户
        public static User GetUserByUserName(string username)
        {
            return UserService.GetUserByUserId(username);
        }
    }
}
