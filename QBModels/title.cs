using System;
using System.Collections.Generic;
using System.Text;

namespace QBModels
{
    public class title
    {
        private string Tnum;//题目编号
        private string Tstem;//题干
        private string Tsubject;//学科
        private string Ttype;//题目类型
        private string Tanswer;//题目答案

        public title()
        {

        }

        public string Tnum1 { get => Tnum; set => Tnum = value; }
        public string Tstem1 { get => Tstem; set => Tstem = value; }
        public string Tsubject1 { get => Tsubject; set => Tsubject = value; }
        public string Ttype1 { get => Ttype; set => Ttype = value; }
        public string Tanswer1 { get => Tanswer; set => Tanswer = value; }
    }
}
