using Newtonsoft.Json;
using System.Collections.Generic;

namespace Repligram.IGObjects
{
    public class IGTimelineResponse
    {
        [JsonProperty("feed_items")]
        public List<IGFeedItem> FeedItems { get; set; }

        [JsonProperty("num_results")]
        public int NumResults { get; set; }

        [JsonProperty("more_available")]
        public bool MoreAvailable { get; set; }

        [JsonProperty("auto_load_more_enabled")]
        public bool AutoLoadMoreEnabled { get; set; }

        [JsonProperty("is_direct_v2_enabled")]
        public bool IsDirectV2Enabled { get; set; }

        [JsonProperty("view_state_version")]
        public string ViewStateVersion { get; set; }

        [JsonProperty("client_feed_changelist_applied")]
        public bool ClientFeedChangelistApplied { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("pull_to_refresh_window_ms")]
        public int PullToRefreshWindowMs { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("client_gap_enforcer_matrix")]
        public List<IGEnforcerMatrix> ClientGapEnforcerMatrix { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("suggested_users")]
        public IGSuggestedUsers SuggestedUsers { get; set; }

        [JsonProperty("startup_prefetch_configs")]
        public IGPrefetchConfigs StartupPrefetchConfigs { get; set; }

        [JsonProperty("is_split_head_load")]
        public bool IsSplitHeadLoad { get; set; }

        [JsonProperty("hide_like_and_view_counts")]
        public int HideLikeAndViewCounts { get; set; }
    }

    public class IGFeedItem
    {

    }

    public class IGEnforcerMatrix
    {
        [JsonProperty("list")]
        public List<int> List { get; set; }
    }

    public class IGSuggestedUsers
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("suggestion_cards")]
        public List<IGSuggestionCard> SuggestionCards { get; set; }

        [JsonProperty("netego_type")]
        public string NetegoType { get; set; }

        [JsonProperty("ranking_algorithm")]
        public string RankingAlgorithm { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
    }

    public class IGSuggestionCard
    {
        [JsonProperty("user_card")]
        public IGUserCard UserCard { get; set; }

        [JsonProperty("upsell_ci_card")]
        public IGUpsellCiCard UpsellCiCard { get; set; }
    }

    public class IGUpsellCiCard
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("primary_button_text")]
        public string PrimaryButtonText { get; set; }
    }

    public class IGFeedUser
    {
        [JsonProperty("pk")]
        public string Pk { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("profile_pic_url")]
        public string ProfilePicUrl { get; set; }

        [JsonProperty("profile_pic_id")]
        public string ProfilePicId { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("has_anonymous_profile_picture")]
        public bool HasAnonymousProfilePicture { get; set; }

        [JsonProperty("account_badges")]
        public List<object> AccountBadges { get; set; }
    }

    public class IGPrefetchConfigs
    {
        [JsonProperty("explore")]
        public IGExplore Explore { get; set; }
    }

    public class IGCandidate
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("scans_profile")]
        public string ScansProfile { get; set; }

        [JsonProperty("estimated_scans_sizes")]
        public List<int> EstimatedScansSizes { get; set; }
    }

    public class ImageVersions2
    {
        [JsonProperty("candidates")]
        public List<IGCandidate> Candidates { get; set; }
    }

    public class IGMediaInfo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("media_type")]
        public int MediaType { get; set; }

        [JsonProperty("image_versions2")]
        public ImageVersions2 ImageVersions2 { get; set; }

        [JsonProperty("original_width")]
        public int OriginalWidth { get; set; }

        [JsonProperty("original_height")]
        public int OriginalHeight { get; set; }
    }

    public class IGExplore
    {
        [JsonProperty("containermodule")]
        public string Containermodule { get; set; }

        [JsonProperty("should_prefetch")]
        public bool ShouldPrefetch { get; set; }

        [JsonProperty("should_prefetch_thumbnails")]
        public bool ShouldPrefetchThumbnails { get; set; }
    }

    public class IGReelResponse
    {
        [JsonProperty("tray")]
        public List<IGReel> Tray { get; set; }

        [JsonProperty("story_ranking_token")]
        public string StoryRankingToken { get; set; }

        [JsonProperty("emoji_reactions_config")]
        public IGEmojiReactionsConfig EmojiReactionsConfig { get; set; }

        [JsonProperty("broadcasts")]
        public List<IGBroadcast> Broadcasts { get; set; }

        [JsonProperty("sticker_version")]
        public int StickerVersion { get; set; }

        [JsonProperty("face_filter_nux_version")]
        public int FaceFilterNuxVersion { get; set; }

        [JsonProperty("stories_viewer_gestures_nux_eligible")]
        public bool StoriesViewerGesturesNuxEligible { get; set; }

        [JsonProperty("has_new_nux_story")]
        public bool HasNewNuxStory { get; set; }

        [JsonProperty("refresh_window_ms")]
        public int RefreshWindowMs { get; set; }

        [JsonProperty("response_timestamp")]
        public int ResponseTimestamp { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class IGEmojiReactionsConfig
    {
        [JsonProperty("ufi_type")]
        public int UfiType { get; set; }

        [JsonProperty("delivery_type")]
        public int DeliveryType { get; set; }

        [JsonProperty("overlay_skin_tone_picker_enabled")]
        public bool OverlaySkinTonePickerEnabled { get; set; }

        [JsonProperty("swipe_up_to_show_reactions")]
        public bool SwipeUpToShowReactions { get; set; }

        [JsonProperty("composer_nux_type")]
        public int ComposerNuxType { get; set; }

        [JsonProperty("hide_story_view_count")]
        public bool HideStoryViewCount { get; set; }

        [JsonProperty("double_tap_to_like_reactions")]
        public bool DoubleTapToLikeReactions { get; set; }

        [JsonProperty("reaction_tray_interactive_panning_enabled")]
        public bool ReactionTrayInteractivePanningEnabled { get; set; }

        [JsonProperty("presence_dot_enabled")]
        public bool PresenceDotEnabled { get; set; }

        [JsonProperty("tappable_reply_composer_enabled")]
        public bool TappableReplyComposerEnabled { get; set; }

        [JsonProperty("consolidated_feedback_enabled")]
        public bool ConsolidatedFeedbackEnabled { get; set; }

        [JsonProperty("persistent_self_story_badge_enabled")]
        public bool PersistentSelfStoryBadgeEnabled { get; set; }
    }

    public class IGReel
    {

    }

    public class IGBroadcast
    {

    }
}