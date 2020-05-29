using System;
using System.Collections.Generic;
using System.Text;

namespace youtube_dl_test.core.Models
{
    public abstract class YoutubeRequestBase
    {
        public bool AudioOnly { get; set; }
        public string OutputLocation { get; set; }
    }
}
