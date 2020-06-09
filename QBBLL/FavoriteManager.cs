using QBDAL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace QBBLL
{
    public static partial class FavoriteManager
    {
        //创建空白收藏夹
        public static Favorite CreateBlankFavorite(Favorite Favorite)
        {
            return FavoritesService.CreateBlankFavorite(Favorite);
        }
        //删除收藏夹
        public static void DeleteFavorite(Favorite Favorite)
        {
            FavoritesService.DeleteFavorite(Favorite);
        }
        //根据收藏夹号删除收藏夹
        public static void DeleteFavoriteByNum(string QBNum)
        {
            FavoritesService.DeleteByFavoriteNum(QBNum);
        }
        //修改收藏夹信息
        public static void ModifyFavorite(Favorite Favorite)
        {
            FavoritesService.ModifyFavorite(Favorite);
        }
        //获取所有收藏夹信息
        public static IList<Favorite> GetAllFavorite()
        {
            return FavoritesService.GetAllFavorite();
        }
        //根据收藏夹名称获取收藏夹信息
        public static Favorite GetFavoriteByName(string QBname)
        {
            return FavoritesService.GetFavoriteByName(QBname);
        }
        //根据sql获取收藏夹信息
        public static IList<Favorite> GetFavoriteBySql(string safeSql)
        {
            return FavoritesService.GetFavoriteBySql(safeSql);
        }
        //根据sql带参数获取收藏夹信息
        public static IList<Favorite> GetFavoriteBySql(string safeSql, SqlParameter[] values)
        {
            return FavoritesService.GetFavoriteBySql(safeSql, values);
        }
        //添加题库
        public static void QuestionBankAppend(QuestionBank QuestionBank, Favorite Favorite)
        {
            FavoritesService.QuestionBankAppend(QuestionBank, Favorite);
        }
        //根据题库号删除题库
        public static void DeleteQuestionBankByNum(string QBName, string Tnum)
        {
            FavoritesService.DeleteByQuestionBankkNum(QBName, Tnum);
        }
        //获取收藏夹题库列表
        public static IList<QuestionBank> GetAllQuestionBank(Favorite Favorite)
        {
            return FavoritesService.GetAllQuestionBank(Favorite);
        }
        //根据sql获取收藏夹信息
        public static IList<QuestionBank> GetQuestionBankBySql(string safeSql, SqlParameter[] para)
        {
            return FavoritesService.GetQuestionBankBySql(safeSql, para);
        }
        //获取某用户收藏夹信息
        public static IList<Favorite> GetAllFavorite(User User)
        {
            return FavoritesService.GetAllFavorite(User);
        }
    }
}
