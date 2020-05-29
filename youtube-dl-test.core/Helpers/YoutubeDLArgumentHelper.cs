using System.Collections.Generic;
using System.Text;
using youtube_dl_test.core.Models;

namespace youtube_dl_test.core.Helpers
{
    public static class YoutubeDLArgumentHelper
    {

        private static readonly string _defaultFileLocation = @"C:\Users\mkmor\OneDrive\Desktop\YoutubeArchive\";

        public static string BuildArguments(YoutubeVideoRequest request)
        {
            var argsList = new List<string>();

            argsList = BuildGenericArguments(request, argsList);

            // final arg is youtube video to download
            argsList.Add(request.Url);

            return string.Join(' ', argsList);
        }

        public static string BuildArguments(YoutubePlaylistRequest request)
        {
            var argsList = new List<string>();

            argsList = BuildGenericArguments(request, argsList);

            // final arg is youtube video to download
            argsList.Add($"-i {request.PlaylistId}");

            return string.Join(' ', argsList);
        }

        private static List<string> BuildGenericArguments(YoutubeRequestBase request, List<string> argsList)
        {
            // output location
            var outputLocation = (request.OutputLocation ?? _defaultFileLocation) + "%(title)s.%(ext)s";
            argsList.Add($"-o {outputLocation}");

            if (request.AudioOnly) // get MP3 if audio-only
            {
                argsList.Add("--extract-audio --audio-format mp3");
            }
            else // otherwise -> mp4
            {
                argsList.Add("-f mp4");
            }

            return argsList;
        }
    }
}
