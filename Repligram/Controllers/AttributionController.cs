using Repligram.IGObjects;
using System.Web.Http;

namespace Repligram.Controllers
{
    public class AttributionController : ApiController
    {
        [HttpPost]
        [Route("api/v1/attribution/log_attribution/")]
        public IGStatus PostLogAttribution()
        {
            return new IGStatus
            {
                Status = "ok"
            };
        }

        [HttpPost]
        [Route("api/v1/attribution/log_resurrect_attribution")]
        public IGStatus PostLogResurrect()
        {
            return new IGStatus
            {
                Status = "ok"
            };
        }

        [HttpPost]
        [Route("logging_client_events")]
        public IGLogStatus PostClientEvent()
        {
            return new IGLogStatus
            {
                Checksum = "",
                Config = "",
                ConfigOwnerID = "",
                AppData = new object { }
            };
        }
    }
}