using System;
using System.Collections.Generic;

namespace CSharpDictionaries {

    class Program {

        static void Main(string[] args) {

            Dictionary<string, string> fileTypes = new Dictionary<string, string>();
            fileTypes.Add(".txt", "Text file");
            fileTypes.Add(".htm", "HTML web page file");
            fileTypes.Add(".html", "HTML web page file");
            fileTypes.Add(".css", "Cascading Style Sheet");
            fileTypes.Add(".xml", "XML file type");

            Console.WriteLine("There are {0} items in the fileTypes dictionary", fileTypes.Count);

            try {
                fileTypes.Add(".htm", "Some File Type");
            } catch (ArgumentException e) {
                Console.WriteLine("Keyword .htm already added to dictionary");
            }

            fileTypes.Remove(".css");
            Console.WriteLine("Does dictionary contain .css = {0}", fileTypes.ContainsKey(".css"));

            Console.WriteLine("Dumping the entire dictionary :");
            foreach(KeyValuePair<string, string> kvp in fileTypes) {
                Console.WriteLine("Key = {0} ::: Value = {1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("\nPress Enter to continue...\n");
            Console.ReadLine();
        }
    }
}