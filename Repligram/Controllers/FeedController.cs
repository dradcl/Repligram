using Repligram.IGObjects;
using System.Collections.Generic;
using System.Web.Http;

namespace Repligram.Controllers
{
    public class FeedController : ApiController
    {
        [HttpPost]
        [Route("api/v1/feed/reels_tray/")]
        public IGReelResponse PostReels()
        {
            return new IGReelResponse
            {
                Tray = new List<IGReel> { },
                StoryRankingToken = "5a3aef8d-348a-4d25-8b1c-7b3da214dc87",
                EmojiReactionsConfig = new IGEmojiReactionsConfig
                {
                    UfiType = 0,
                    DeliveryType = 0,
                    OverlaySkinTonePickerEnabled = false,
                    SwipeUpToShowReactions = false,
                    ComposerNuxType = 0,
                    HideStoryViewCount = false,
                    DoubleTapToLikeReactions = false,
                    ReactionTrayInteractivePanningEnabled = false,
                    PresenceDotEnabled = false,
                    TappableReplyComposerEnabled = false,
                    ConsolidatedFeedbackEnabled = false,
                    PersistentSelfStoryBadgeEnabled = false,
                },
                Broadcasts = new List<IGBroadcast> { },
                StickerVersion = 5,
                FaceFilterNuxVersion = 7,
                StoriesViewerGesturesNuxEligible = true,
                HasNewNuxStory = false,
                RefreshWindowMs = 5000,
                ResponseTimestamp = 1617583199,
                Status = "ok"
            };
        }

        [HttpPost]
        [Route("api/v1/feed/timeline/")]
        public IGTimelineResponse PostTimeline()
        {
            return new IGTimelineResponse
            {
                FeedItems = new List<IGFeedItem> { },
                NumResults = 0,
                MoreAvailable = false,
                AutoLoadMoreEnabled = true,
                IsDirectV2Enabled = true,
                ViewStateVersion = "",
                ClientFeedChangelistApplied = false,
                RequestId = "",
                PullToRefreshWindowMs = 5000,
                Status = "ok",
                ClientGapEnforcerMatrix = new List<IGEnforcerMatrix>
                {
                    new IGEnforcerMatrix
                    {
                        List = new List<int> {2, 2}
                    },
                    new IGEnforcerMatrix
                    {
                        List = new List<int> {2, 2}
                    }
                },
                SessionId = "",
                SuggestedUsers = new IGSuggestedUsers
                {
                    Title = "Welcome to Instagram",
                    Style = "with_content_thumbnail",
                    SuggestionCards = new List<IGSuggestionCard>
                    {
                        new IGSuggestionCard // The list to add more suggested users.
                        {
                            UserCard = new IGUserCard
                            {
                                User = new IGFeedUser
                                {
                                    Pk = "45610096595",
                                    Username = "vp",
                                    FullName = "Vice President Kamala Harris",
                                    IsPrivate = false,
                                    ProfilePicUrl = "https://scontent-atl3-2.cdninstagram.com/v/t51.2885-19/s150x150/139962074_228789918793054_4758764948820781524_n.jpg?tp=1\u0026_nc_ht=scontent-atl3-2.cdninstagram.com\u0026_nc_ohc=G7Qf2IAjmcIAX8N0-vh\u0026edm=AJ9x6zYAAAAA\u0026ccb=7-4\u0026oh=0b681ab29aca5e8058ea3a5cd0593149\u0026oe=608F8D98\u0026_nc_sid=cff2a4",
                                    ProfilePicId = "2490880422458144173_45610096595",
                                    IsVerified = true,
                                    HasAnonymousProfilePicture = false,
                                    AccountBadges = new List<object> { }
                                },
                                Algorithm = "ig_regional_interests_algorithm",
                                SocialContext = "Popular",
                                Icon = "",
                                Caption = "Vice President of the United States. Wife to the first @SecondGentleman. Momala. Auntie. Fighting for the people.",
                                MediaIds = new List<string>
                                {
                                    "2544630595855976306",
                                    "2542636425318730531",
                                    "2542381872623114010",
                                    "2541890182929920700"
                                },
                                ThumbnailUrls = new List<string>
                                {
                                    "https://scontent-atl3-2.cdninstagram.com/v/t51.2885-15/e35/c140.0.1160.1160a/s150x150/169243108_325458619021303_7180569227664459621_n.jpg?tp=1\u0026_nc_ht=scontent-atl3-2.cdninstagram.com\u0026_nc_cat=1\u0026_nc_ohc=ZMk2p0lQUpAAX9PrrKb\u0026edm=AJ9x6zYAAAAA\u0026ccb=7-4\u0026oh=582da5853dee1f18b6e23ed276a634a0\u0026oe=60910261\u0026_nc_sid=cff2a4\u0026ig_cache_key=MjU0NDYzMDU5NTg1NTk3NjMwNg%3D%3D.2.c-ccb7-4",
                                    "https://scontent-atl3-2.cdninstagram.com/v/t51.2885-15/e35/c173.0.1093.1093a/s150x150/167617657_3937785242971587_2255263404610005098_n.jpg?tp=1\u0026_nc_ht=scontent-atl3-2.cdninstagram.com\u0026_nc_cat=1\u0026_nc_ohc=LNJuGv8xgWIAX8glr8r\u0026edm=AJ9x6zYAAAAA\u0026ccb=7-4\u0026oh=b8c660234c9c5d97fe65a9519539a9f4\u0026oe=6090040D\u0026_nc_sid=cff2a4\u0026ig_cache_key=MjU0MjYzNjQyNTMxODczMDUzMQ%3D%3D.2.c-ccb7-4",
                                    "https://scontent-atl3-2.cdninstagram.com/v/t51.2885-15/e35/c196.0.1047.1047a/s150x150/167147371_885536155631694_6880925601172733957_n.jpg?tp=1\u0026_nc_ht=scontent-atl3-2.cdninstagram.com\u0026_nc_cat=106\u0026_nc_ohc=hu2EqgyqvpkAX9bTWoY\u0026edm=AJ9x6zYAAAAA\u0026ccb=7-4\u0026oh=cef2365924b3f639020baa62118013e2\u0026oe=608FC97C\u0026_nc_sid=cff2a4\u0026ig_cache_key=MjU0MjM4MTg3MjYyMzExNDAxMA%3D%3D.2.c-ccb7-4",
                                    "https://scontent-atl3-2.cdninstagram.com/v/t51.2885-15/e35/s150x150/167572546_920387732054800_4695936863226320032_n.jpg?tp=1\u0026_nc_ht=scontent-atl3-2.cdninstagram.com\u0026_nc_cat=104\u0026_nc_ohc=0LYsuw_T1nEAX-i5gKn\u0026edm=AJ9x6zYAAAAA\u0026ccb=7-4\u0026oh=310d34d573b27f174213a254e26b9649\u0026oe=6090EDB4\u0026_nc_sid=cff2a4\u0026ig_cache_key=MjU0MTg5MDE4MjkyOTkyMDcwMA%3D%3D.2-ccb7-4"
                                },
                                LargeUrls = new List<string> { },
                                MediaInfos = new List<IGMediaInfo>
                                {
                                    new IGMediaInfo
                                    {
                                        Id = 0,
                                        MediaType = 1,
                                        ImageVersions2 = new ImageVersions2
                                        {
                                            Candidates = new List<IGCandidate>
                                            {
                                                new IGCandidate
                                                {
                                                    Width = 1080,
                                                    Height = 870,
                                                    Url = "https://scontent-atl3-2.cdninstagram.com/v/t51.2885-15/e35/s1080x1080/169243108_325458619021303_7180569227664459621_n.jpg?tp=1\u0026_nc_ht=scontent-atl3-2.cdninstagram.com\u0026_nc_cat=1\u0026_nc_ohc=ZMk2p0lQUpAAX9PrrKb\u0026edm=AJ9x6zYAAAAA\u0026ccb=7-4\u0026oh=4664b5c4ae173b25fd3d7482ff25b3d9\u0026oe=60912D4D\u0026_nc_sid=cff2a4\u0026ig_cache_key=MjU0NDYzMDU5NTg1NTk3NjMwNg%3D%3D.2-ccb7-4",
                                                    ScansProfile = "e35",
                                                    EstimatedScansSizes = new List<int>
                                                    {
                                                        8236, 16473, 24710, 32947, 41184, 46085, 58645, 66653, 74132
                                                    }
                                                },
                                                new IGCandidate
                                                {
                                                    Width = 360,
                                                    Height = 290,
                                                    Url = "https://scontent-atl3-2.cdninstagram.com/v/t51.2885-15/e35/s360x360/169243108_325458619021303_7180569227664459621_n.jpg?tp=1\u0026_nc_ht=scontent-atl3-2.cdninstagram.com\u0026_nc_cat=1\u0026_nc_ohc=ZMk2p0lQUpAAX9PrrKb\u0026edm=AJ9x6zYAAAAA\u0026ccb=7-4\u0026oh=1a3f5db4211829ec856af695b9594bb6\u0026oe=608FE5E1\u0026_nc_sid=cff2a4\u0026ig_cache_key=MjU0NDYzMDU5NTg1NTk3NjMwNg%3D%3D.2-ccb7-4",
                                                    ScansProfile = "e35",
                                                    EstimatedScansSizes = new List<int>
                                                    {
                                                        1942, 3884, 5827, 7769, 9711, 11692, 337422, 17481, 17481
                                                    }
                                                }
                                            }
                                        },
                                        OriginalWidth = 1440,
                                        OriginalHeight = 1160
                                    }
                                },
                                Value = 0.00184181,
                                FollowedBy = false,
                                IsNewSuggestion = false,
                                Uuid = "47291206777|1617580553"
                            }
                        }
                    },
                    NetegoType = "suggested_users",
                    RankingAlgorithm = "su_default",
                    Subtitle = "When you follow people, you'll see the photos and videos they post here."
                },
                StartupPrefetchConfigs = new IGPrefetchConfigs
                {
                    Explore = new IGExplore
                    {
                        Containermodule = "explore",
                        ShouldPrefetch = true,
                        ShouldPrefetchThumbnails = false
                    }
                },
                IsSplitHeadLoad = false,
                HideLikeAndViewCounts = 0
            };
        }
    }
}