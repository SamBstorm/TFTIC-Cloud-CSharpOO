using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_02.Models
{
    public class CompactDisk
    {

        public string Name { get; set; }
        public List<MusicSingle> Musics { get; set; } = new List<MusicSingle>();

        public CompactDisk(string name, params MusicSingle[] musics)
        {
            Name = name;
            Musics = musics.ToList();
        }

    }
}
