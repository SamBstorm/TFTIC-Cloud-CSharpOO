using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_01.Models
{
    public class EditorExt
    {
        public string ExtensionName { get; set; }

        public string Producer { get; set; }
        public string Version { get; set; }

        public EditorExt(string extensionName, string producer, string version)
        {
            ExtensionName = extensionName;
            Producer = producer;
            Version = version;
        }

        public bool Loading()
        {
            Console.WriteLine($"Chargement de {ExtensionName} ({Version}) ...");
            Console.WriteLine("Prêt!");
            return true;
        }
    }
}
