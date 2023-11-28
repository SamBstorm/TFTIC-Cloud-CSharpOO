using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_exception.Models
{
    public class CompactDisk
    {
        public void Read()
        {
            Console.WriteLine("Lalalalala!");
            //Aoutch une griffe!
            throw new Exception("griffe...");
        }
    }
}
