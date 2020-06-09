using System;
using System.Collections.Generic;
using System.Text;

namespace QBModels
{
    public class options
    {
        private int Onum;//选项号
        private string Oname;//选项名
        private string Otext;//选项内容
        public options()
        {

        }
        public int Onum1 { get => Onum; set => Onum = value; }
        public string Oname1 { get => Oname; set => Oname = value; }
        public string Otext1 { get => Otext; set => Otext = value; }
    }
}
