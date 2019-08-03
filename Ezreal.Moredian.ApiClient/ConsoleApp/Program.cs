using Ezreal.Moredian.ApiClient;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MoredianGlobal.InitializeDefaultConfig();
            ApiFactory.CreateGroupClient().CreateGroup("", new Ezreal.Moredian.ApiClient.ApiParameterModels.Generic.GroupBaseInfoModel()
            {
                GroupId = 0,
                GroupName = "1001",
                TpGroupId = "1001"
            });
            Console.WriteLine("Hello World!");
        }
    }
}
