using QBDAL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace QBBLL
{
    public static partial class TitleManager
    {
        //添加试题
        public static title AddTitle(title title)
        {
            return TitleService.AddTitle(title);
        }
        //删除试题
        public static void DeleteTitle(title title)
        {
            TitleService.DeleteTitle(title);
        }
        //根据试题号删除试题
        public static void DeleteTitleByNum(string TNum)
        {
            TitleService.DeleteTitleByTitleNum(TNum);
        }
        //修改试题信息
        public static void ModifyTitle(title Title)
        {
            TitleService.ModifyTitle(Title);
        }
        //获取所有试题信息
        public static IList<title> GetAllTitle()
        {
            return TitleService.GetAllTitle();
        }
        //根据试题号获取试题信息
        public static title GetTitleByTnum(string Tnum)
        {
            return TitleService.GetByTitleNum(Tnum);
        }
        //根据sql获取试题信息
        public static IList<title> GetTitleBySql(string safeSql)
        {
            return TitleService.GetTitleBySql(safeSql);
        }
        //根据sql带参数获取试题信息
        public static IList<title> GetTitleBySql(string safeSql, SqlParameter[] values)
        {
            return TitleService.GetTitleBySql(safeSql, values);
        }
        //添加选项
        public static void TitleAppend(options options,title title )
        {
            TitleService.AddOptions(options, title);
        }
        //获取题库选项列表
        public static IList<options> GetAllTitle(title Title)
        {
            return TitleService.GetAllOptions(Title);
        }
        //根据sql获取题库信息
        public static IList<options> GetOptionsBySql(string safeSql, SqlParameter[] para)
        {
            return TitleService.GetOptionsBySql(safeSql, para);
        }
    }
}
