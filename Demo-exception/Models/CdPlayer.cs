using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_exception.Models
{
    public class CdPlayer
    {

        public CompactDisk CurrentDisk { get; set; }

        public void PlayDisk()
        {
            try
            {
                CurrentDisk.Read();
            }
            catch (NullReferenceException nullRefExcept)
            {
                NoDiskException noDiskExcept = new NoDiskException(this);
                throw noDiskExcept;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
