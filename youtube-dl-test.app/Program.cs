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
            //service.DownloadVideoAsync(new YoutubeVideoRequest
            //{
            //    Url = "https://www.youtube.com/watch?v=2oTk3VaYdz4",
            //    IsPlaylist = true
            //});
            service.DownloadPlaylistAsync(new YoutubePlaylistRequest
            {
                PlaylistId =  "PLhGHzr0CJYGjDgieMIvTurewU1RXsVEJK",
                OutputLocation = @"C:\Users\mkmor\OneDrive\Desktop\YoutubeArchive\CowChopHouseEra\"
            });
        }
    }
}
