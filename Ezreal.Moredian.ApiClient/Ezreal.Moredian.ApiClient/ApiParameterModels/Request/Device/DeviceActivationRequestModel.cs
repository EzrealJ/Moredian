using Ezreal.Moredian.ApiClient.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient.ApiParameterModels.Request.Device
{
    public class DeviceActivationRequestModel
    {
        [ApiParameterName("qrCode")]
        public string QRCode { get; set; }
    }
}
