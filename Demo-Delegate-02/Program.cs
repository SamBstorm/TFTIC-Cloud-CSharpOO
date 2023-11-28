using Demo_Delegate_02.Models;

namespace Demo_Delegate_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicSingle music01 = new MusicSingle("Johnny Halliday", "Allumez le feu", 180000);
            MusicSingle music02 = new MusicSingle("Rammstein", "Sonne", 240000);
            MusicSingle music03 = new MusicSingle("Johan Strauss", "Le Danube bleu", 1856000);
            MusicSingle music04 = new MusicSingle("2pac", "All eyes on me", 360000);

            CompactDisk mon_cd = new CompactDisk("Ma compil' 01", music01, music02,music03,music04);

            CdPlayer lecteur = new CdPlayer();

            lecteur.CurrentCD = mon_cd;

            //lecteur.PlayCd();

            lecteur.SetProgram(2);
            lecteur.SetProgram(4);
            lecteur.SetProgram(2);
            lecteur.SetProgram(1);
            lecteur.SetProgram(3);
            lecteur.SetProgram(2);

            lecteur.PlayCd();
        }
    }
}