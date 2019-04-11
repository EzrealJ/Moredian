using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.Enums
{
    public enum EnumSex
    {
        [Description("男")]
        Male=0,
        [Description("女")]
        Female=1,
        [Description("未知")]
        Unknown=-1
    }
}
