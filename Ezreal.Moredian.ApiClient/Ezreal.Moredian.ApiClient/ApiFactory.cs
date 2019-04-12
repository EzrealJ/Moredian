using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ezreal.Moredian.ApiClient
{
    public class ApiFactory
    {
        public static Api.AppClient CreateAppClient() => new Api.AppClient(null);

        public static Api.OrganizationClient CreateOrganizationClient() => new Api.OrganizationClient(null);

        public static Api.DeviceClient CreateDeviceClient() => new Api.DeviceClient(null);

        public static Api.MemberClient CreateMemberClient() => new Api.MemberClient(null);

    }
}
