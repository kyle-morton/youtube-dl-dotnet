namespace youtube_dl_test.core.Models
{
    public class YoutubeDownloadRequest
    {
        public string Url { get; set; }
        public bool AudioOnly { get; set; }
        public string OutputLocation { get; set; }
    }
}
