using Demo_Delegate_01.Models;

namespace Demo_Delegate_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Editor vscode = new Editor();

            EditorExt ext01 = new EditorExt("Prettier", "PrettyProduction", "V2.0");
            EditorExt ext02 = new EditorExt("AutoTag Rename", "TotoProduction", "V4.0");
            EditorExt ext03 = new EditorExt("XML Reader", "OldiesProduction", "V4.0");
            EditorExt ext04 = new EditorExt("Theme Pinky", "RainbowProduction", "V3.0");
            EditorExt ext05 = new EditorExt("IconUnicorns", "RainvowProduction", "V1.0");

            vscode.AddExtension(ext01);
            vscode.AddExtension(ext02);
            vscode.AddExtension(ext03);
            vscode.AddExtension(ext04);
            vscode.AddExtension(ext05);

            vscode.StartEditor();
        }
    }
}