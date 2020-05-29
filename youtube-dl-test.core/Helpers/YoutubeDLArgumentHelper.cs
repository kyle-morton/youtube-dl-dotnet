using System.Collections.Generic;
using System.Text;
using youtube_dl_test.core.Models;

namespace youtube_dl_test.core.Helpers
{
    public static class YoutubeDLArgumentHelper
    {

        private static readonly string _defaultFileLocation = @"C:\Users\mkmor\OneDrive\Desktop\YoutubeArchive\";

        public static string BuildArguments(YoutubeDownloadRequest request)
        {
            var argsList = new List<string>();

            // output location
            var outputLocation = (request.OutputLocation ?? _defaultFileLocation) + "%(title)s.%(ext)s";
            argsList.Add($"-o {outputLocation}");

            if (request.AudioOnly)
            {
                argsList.Add("--extract-audio --audio-format mp3");
            }
            else
            {
                argsList.Add("-f mp4");
            }

            // final arg is youtube video to download
            argsList.Add(request.Url);

            return string.Join(' ', argsList);
        }
    }
}
