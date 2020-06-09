using System;
using System.Collections.Generic;
using System.Text;

namespace QBModels
{
    public class QuestionBank
    {
        private string QBnum;//题库编号
        private string QBname;//题库名称
        private int QBqnum;//题目数量
        public QuestionBank()
        {

        }
        public string QBnum1 { get => QBnum; set => QBnum = value; }
        public string QBname1 { get => QBname; set => QBname = value; }
        public int QBqnum1 { get => QBqnum; set => QBqnum = value; }
    }
}
