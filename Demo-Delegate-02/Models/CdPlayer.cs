using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_02.Models
{
    public delegate void DelegateProgram();

    public class CdPlayer
    {
        private DelegateProgram _monProgram;
        public CompactDisk CurrentCD { get; set; }

        public void PlayProgram(int trackNumber,MusicSingle music, int timer)
        {
            //Joue un program
            Console.WriteLine($"Lecture de la piste {trackNumber} : {music.Title} - {music.ArtistName} ({timer}ms.)");
        }

        private DelegateProgram GenerateProgram(int trackNumber) {
            int timer = 0;
            for (int i = 0; i < trackNumber-1; i++)
            {
                timer += CurrentCD.Musics[i].Milliseconds;
            }
            MusicSingle currentMusic = CurrentCD.Musics[trackNumber - 1];
            return delegate () { PlayProgram(trackNumber,currentMusic, timer); };
        }

        public void SetProgram(int trackNumber)
        {
            _monProgram += GenerateProgram(trackNumber);
        }

        public void PlayCd()
        {
            if(_monProgram != null)
            {
                _monProgram();
            }
            else
            {
                int trackNumber = 1;
                int timer = 0;
                foreach (MusicSingle music in CurrentCD.Musics)
                {
                    PlayProgram(trackNumber,music, timer);
                    timer += music.Milliseconds;
                    trackNumber++;
                }
            }
        }
    }
}
