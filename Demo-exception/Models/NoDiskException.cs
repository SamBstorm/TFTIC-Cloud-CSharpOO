using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_exception.Models
{
    public class NoDiskException : NullReferenceException
    {
        public CdPlayer Player { get; set; }
        public NoDiskException() : base("Pas de disque.") { 
        
        }

        public NoDiskException( CdPlayer player) : this()
        {
            Player = player;
        }
    }
}
