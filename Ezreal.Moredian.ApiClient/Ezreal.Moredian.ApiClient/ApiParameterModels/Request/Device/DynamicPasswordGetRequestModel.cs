using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Device
{
    public class DynamicPasswordGetRequestModel
    {
        [ApiParameterName("deviceId")]
        public string DeviceID { get; set; }

        public long Timestamp { get; set; }
    }
}
