using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using youtube_dl_test.core.Helpers;
using youtube_dl_test.core.Models;

namespace youtube_dl_test.core.Services
{

    public interface IYoutubeService
    {
        void DownloadVideoAsync(YoutubeDownloadRequest request);
    }

    public class YoutubeService : IYoutubeService
    {

        public void DownloadVideoAsync(YoutubeDownloadRequest request)
        {
            var args = YoutubeDLArgumentHelper.BuildArguments(request);
            var processInfo = new ProcessStartInfo(@"YoutubeDL\youtube-dl.exe", args);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
            {
                Console.WriteLine("output>>" + e.Data);
            };
            process.BeginOutputReadLine();

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
            {
                Console.WriteLine("error>>" + e.Data);
            };
            process.BeginErrorReadLine();

            process.WaitForExit();

            Console.WriteLine("ExitCode: {0}", process.ExitCode);
            process.Close();
        }
    }
}
