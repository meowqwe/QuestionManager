using System;

namespace QBModels
{
    public class User
    {
        private string UuserName = String.Empty;//用户名
        private string UpassWord = String.Empty;//用户密码
        private string Usex;//性别
        private string Uclass;//班级
        private string Ugrade;//年级
        private int Urole;//权限，0为用户，1为管理
        public User()
        {

        }

        public string UuserName1 { get => UuserName; set => UuserName = value; }
        public string UpassWord1 { get => UpassWord; set => UpassWord = value; }
        public string Usex1 { get => Usex; set => Usex = value; }
        public string Uclass1 { get => Uclass; set => Uclass = value; }
        public string Ugrade1 { get => Ugrade; set => Ugrade = value; }
        public int Urole1 { get => Urole; set => Urole = value; }

    }
}
