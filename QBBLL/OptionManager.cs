using QBDAL;
using QBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace QBBLL
{
    public static partial class OptionManager
    {
        //添加选项
        public static options AddOption(options Option)
        {
            return OptionService.CreateOption(Option);
        }
        //删除选项
        public static void DeleteOption(options Option)
        {
            OptionService.DeleteOptions(Option);
        }
        //根据选项号删除选项
        public static void DeleteOptionByNum(int Onum)
        {
            OptionService.DeleteByOptionsNum(Onum);
        }
        //修改选项信息
        public static void ModifyOption(options Option)
        {
            OptionService.ModifyOptions(Option);
        }
    }
}
