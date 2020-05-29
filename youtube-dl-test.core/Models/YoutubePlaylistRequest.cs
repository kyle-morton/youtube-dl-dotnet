using System;
using System.Collections.Generic;
using System.Text;

namespace youtube_dl_test.core.Models
{
    public class YoutubePlaylistRequest : YoutubeRequestBase
    {
        public string PlaylistId { get; set; }
    }
}
