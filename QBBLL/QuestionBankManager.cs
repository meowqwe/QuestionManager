using QBModels;
using System;
using System.Collections.Generic;
using System.Text;
using QBDAL;
using System.Data.SqlClient;

namespace QBBLL
{
    public static partial class QuestionBankManager
    {
        //创建空白题库
        public static QuestionBank CreateBlankQuestionBank(QuestionBank questionBank)
        {
            return QuestionBankService.CreateBlankQuestionBank(questionBank);
        }
        //删除题库
        public static void DeleteQuestionBank(QuestionBank questionbank)
        {
            QuestionBankService.DeleteQuestionBank(questionbank);
        }
        //根据题库号删除题库
        public static void DeleteQuestionBankByNum(string QBNum)
        {
            QuestionBankService.DeleteByQuestionBankNum(QBNum);
        }
        //修改题库信息
        public static void ModifyQuestionBank(QuestionBank questionbank)
        {
            QuestionBankService.ModifyQuestionBank(questionbank);
        }
        //获取所有题库信息
        public static IList<QuestionBank> GetAllQuestionBank()
        {
            return QuestionBankService.GetAllQuestionBank();
        }
        //根据题库号获取题库信息
        public static QuestionBank GetQuestionBankByQBnum(string QBnum)
        {
            return QuestionBankService.GetQuestionBankByQBnum(QBnum);
        }
        //根据题库名称获取题库信息
        public static QuestionBank GetQuestionBankByName(string QBname)
        {
            return QuestionBankService.GetQuestionBankByName(QBname);
        }
        //根据sql获取题库信息
        public static IList<QuestionBank> GetQuestionBankBySql(string safeSql)
        {
            return QuestionBankService.GetQuestionBankBySql(safeSql);
        }
        //根据sql带参数获取题库信息
        public static IList<QuestionBank> GetQuestionBankBySql(string safeSql,SqlParameter[] values)
        {
            return QuestionBankService.GetQuestionBankBySql(safeSql,values);
        }
        //添加题目
        public static void TitleAppend(title title,QuestionBank questionBank)
        {
            QuestionBankService.TitleAppend(title,questionBank);
        }
        //根据题目号删除题目
        public static void DeleteTitleByNum(string QBName,string Tnum)
        {
            QuestionBankService.DeleteByTitlekNum(QBName,Tnum);
        }
        //获取题库题目列表
        public static IList<title> GetAllTitle(QuestionBank questionBank)
        {
            return QuestionBankService.GetAllTitle(questionBank);
        }
        //根据sql获取题库信息
        public static IList<title> GetTitleBySql(string safeSql,SqlParameter[] para)
        {
            return QuestionBankService.GetTitleBySql(safeSql,para);
        }
    }
}
