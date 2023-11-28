using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_02.Models
{
    public class MusicSingle
    {
        public string ArtistName { get; set; }
        public string Title { get; set; }
        public int Milliseconds { get; set; }

        public MusicSingle(string artistName, string title, int milliseconds)
        {
            ArtistName = artistName;
            Title = title;
            Milliseconds = milliseconds;
        }

    }
}
