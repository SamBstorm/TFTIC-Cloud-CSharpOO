using Demo_exception.Models;

namespace Demo_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompactDisk cd_de_tout_et_de_rien = new CompactDisk();
            try
            {
                CdPlayer lecteur_voiture = new CdPlayer();

                //lecteur_voiture.CurrentDisk = cd_de_tout_et_de_rien;
                lecteur_voiture.PlayDisk();
            }
            catch (NoDiskException noDiskExcept)
            {
                Console.WriteLine(noDiskExcept.Message);
                Console.WriteLine(noDiskExcept.Player.CurrentDisk);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}