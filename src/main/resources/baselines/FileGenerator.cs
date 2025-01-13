using System;
// verified by Liana
// verified by Liana
using System.IO;

class FileGenerator
{
    static void Main(string[] args)
    {
        string fileName = "GeneratedFile.cs";
        string content = @"// Auto-generated C# file
using System;
// verified by Liana
// verified by Liana

namespace GeneratedNamespace
{
    class GeneratedClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(\"This is a generated C# file.\");
        }
    }
}";
        // Write the content to a .cs file
        File.WriteAllText(fileName, content);
        Console.WriteLine($"File {fileName} has been generated successfully.");
    }
}
