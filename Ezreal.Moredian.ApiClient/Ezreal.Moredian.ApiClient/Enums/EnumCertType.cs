using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.Enums
{
    public enum EnumCertType
    {
        [Description("身份证")]
        IDCard = 1,
        [Description("军官证")]
        OfficerCard = 2,
        [Description("护照")]
        Passport = 3
    }
}
