using Repligram.IGObjects;
using System.Collections.Generic;
using System.Web.Http;

namespace Repligram.Controllers
{
    public class QEController : ApiController
    {
        [HttpPost]
        [Route("api/v1/qe/sync/")]
        public IGExperimentResponse Post()
        {
            return new IGExperimentResponse
            {
                Experiments = new List<IGExperiment>
                {
                    new IGExperiment
                    {
                        Name = "ig_android_direct_add_direct_to_android_native_photo_share_sheet",
                        Group = "test",
                        AdditionalParams = new List<string>{ },
                        Params = new List<IGParam>
                        {
                            new IGParam
                            {
                                Name = "is_enabled",
                                Value = "true"
                            }
                        }
                    },
                    new IGExperiment
                    {
                        Name = "ig_android_fb_account_linking_sampling_freq_universe",
                        Group = "test",
                        AdditionalParams = new List<string>{ },
                        Params = new List<IGParam>
                        {
                            new IGParam
                            {
                                Name = "freq",
                                Value = "100"
                            }
                        }
                    },
                    new IGExperiment
                    {
                        Name = "ig_android_login_identifier_fuzzy_match",
                        Group = "control",
                        AdditionalParams = new List<string>{ },
                        Params = new List<IGParam>
                        {
                            new IGParam
                            {
                                Name = "enabled",
                                Value = "false"
                            },
                            new IGParam
                            {
                                Name = "cost",
                                Value = "0"
                            }
                        }
                    },
                    new IGExperiment
                    {
                        Name = "ig_android_passwordless_account_password_creation_universe",
                        Group = "test_one_tap_check_box_hidden",
                        AdditionalParams = new List<string>{ },
                        Params = new List<IGParam>
                        {
                            new IGParam
                            {
                                Name = "show_save_password_checkbox",
                                Value = "true"
                            },
                            new IGParam
                            {
                                Name = "upsell_for_mac_flow",
                                Value = "false"
                            }
                        }
                    },
                    new IGExperiment
                    {
                        Name = "ig_android_quickcapture_keep_screen_on",
                        Group = "test",
                        AdditionalParams = new List<string>{ },
                        Params = new List<IGParam>
                        {
                            new IGParam
                            {
                                Name = "keep_screen_on_enabled",
                                Value = "true"
                            },
                        }
                    },
                    new IGExperiment
                    {
                        Name = "ig_android_gmail_oauth_in_reg",
                        Group = "rollout_1201",
                        AdditionalParams = new List<string>{ },
                        Params = new List<IGParam>
                        {
                            new IGParam
                            {
                                Name = "try_background_confirm",
                                Value = "true"
                            },
                        }
                    },
                    new IGExperiment
                    {
                        Name = "ig_android_security_intent_switchoff",
                        Group = "allusers",
                        AdditionalParams = new List<string>{ },
                        Params = new List<IGParam>
                        {
                            new IGParam
                            {
                                Name = "throw_exception",
                                Value = "false"
                            },
                            new IGParam
                            {
                                Name = "intent_matcher",
                                Value = ""
                            },
                            new IGParam
                            {
                                Name = "switch_offs",
                                Value = "false"
                            }
                        }
                    },
                    new IGExperiment
                    {
                        Name = "ig_android_sim_info_upload",
                        Group = "test",
                        AdditionalParams = new List<string>{ },
                        Params = new List<IGParam>
                        {
                            new IGParam
                            {
                                Name = "enable_upload",
                                Value = "true"
                            },
                        }
                    },
                },
                Status = "ok"
            };
        }
    }
}