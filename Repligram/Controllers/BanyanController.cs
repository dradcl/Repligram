//
//  BanyanController: Not sure of its function at this moment.
//

using Repligram.IGObjects;
using System.Collections.Generic;
using System.Web.Http;

namespace Repligram.Controllers
{
    public class BanyanController : ApiController
    {
        [HttpGet]
        [Route("api/v1/banyan/banyan/")]
        public IGViewResponse GetViews(List<string> views)
        {
            return new IGViewResponse
            {
                Ranking = new List<IGView>
                {
                    new IGView
                    {
                        ViewName = "direct_inbox_active_now",
                        ScoreMap = new IGScoreMap { },
                        Expiration = 86401000,
                        RequestID = "1617580555,active_now,,"
                    },
                    new IGView
                    {
                        ViewName = "forwarding_recipient_sheet",
                        ScoreMap = new IGScoreMap { },
                        Expiration = 86401000,
                        RequestID = "1617580555,forwarding_recipient_sheet,,"
                    },
                    new IGView
                    {
                        ViewName = "group_stories_share_sheet",
                        ScoreMap = new IGScoreMap { },
                        Expiration = 86401000,
                        RequestID = "1617580555,group_stories_share_sheet,,"
                    }
                },
                Entities = new IGEntity
                {
                    User = new List<IGUser> { },
                    Thread = new List<object> { }
                },
                FailedNames = new List<string> { },
                Status = "ok"
            };
        }
    }
}