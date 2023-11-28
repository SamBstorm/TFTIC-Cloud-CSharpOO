using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegate_01.Models
{
    public delegate bool LoadingMethod();
    public class Editor
    {
        public List<EditorExt> Extensions { get; set; } = new List<EditorExt>();
        private LoadingMethod _extensionLoading;

        public void AddExtension(EditorExt extension)
        {
            Extensions.Add(extension);
            _extensionLoading += extension.Loading;
        }

        public void StartEditor()
        {
            //Load Extensions
            //foreach (EditorExt extension in Extensions)
            //{
            //    extension.Loading();
            //}

            if(_extensionLoading != null)
            {
                _extensionLoading();
            }

            Console.WriteLine("Fin chargement.");
        }
    }
}
