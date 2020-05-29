using System;
using youtube_dl_test.core.Models;
using youtube_dl_test.core.Services;

namespace youtube_dl_test.app
{
    class Program
    {
        static void Main(string[] args)
        {
            IYoutubeService service = new YoutubeService();
            service.DownloadVideoAsync(new YoutubeDownloadRequest
            {
                Url = "https://www.youtube.com/watch?v=C0DPdy98e4c"
            });
        }
    }
}
