using System.Text.RegularExpressions;

namespace flydubai.Model.Content
{
    /// <summary>
    /// Web Video Source
    /// </summary>
    public abstract class WebVideoSource
    {
        public abstract string Name { get; }

        public string OriginalUrl { get; protected set; }

        public string EmbedUrl { get; protected set; }

        public abstract bool TryCreate(string url);
    }

    /// <summary>
    /// Youtube Web Video Source
    /// </summary>
    public class YoutubeWebVideoSource : WebVideoSource
    {
        public static readonly Regex ExtractVideoIdRegex =
            new Regex(@"youtu(?:\.be|be\.com)/(?:(.*)v(/|=)|(.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase);

        public static readonly string EmbedFormat = "http://www.youtube.com/v/{0}";

        public override string Name
        {
            get { return "Youtube"; }
        }

        /// <summary>
        /// Tries the create.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public override bool TryCreate(string url)
        {
            if (ExtractVideoIdRegex.IsMatch(url))
            {
                var videoId = ExtractVideoIdRegex.Match(url).Groups[4];
                EmbedUrl = string.Format(EmbedFormat, videoId);

                OriginalUrl = url;

                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// Vimeo Web Video Source
    /// </summary>
    public class VimeoWebVideoSource : WebVideoSource
    {
        public static readonly Regex ExtractVideoIdRegex = new Regex(@"vimeo\.com/(?:.*#|.*/videos/)?([0-9]+)", RegexOptions.IgnoreCase);
        public static readonly string EmbedFormat = "http://vimeo.com/moogaloop.swf?clip_id={0}&server=vimeo.com&show_title=0&show_byline=0&show_portrait=0&color=00adef&fullscreen=1&autoplay=0&loop=0";

        public override string Name
        {
            get { return "Vimeo"; }
        }

        /// <summary>
        /// Tries the create.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns></returns>
        public override bool TryCreate(string url)
        {
            if (ExtractVideoIdRegex.IsMatch(url))
            {
                var videoId = ExtractVideoIdRegex.Match(url).Groups[1];
                EmbedUrl = string.Format(EmbedFormat, videoId);

                OriginalUrl = url;

                return true;
            }

            return false;
        }
    }
}