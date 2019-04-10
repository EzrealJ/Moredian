using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Device
{
    public class UnbindRequestModel
    {

        public class Rootobject
        {
            [ApiParameterName("deviceId")]
            public string DeviceID { get; set; }
            [ApiParameterName("deviceSn")]
            public string DeviceSn { get; set; }
        }

    }
}
