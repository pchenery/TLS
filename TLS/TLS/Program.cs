using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TLS
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\work\training\tls\sampletext.txt";
 
            //Open the file to read from.
            string readText = File.ReadAllText(path);

            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"tra",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = rx.Matches(readText);

            // Report the number of matches found.
             Console.WriteLine("{0} matches found: ",
                 matches.Count);

            //@"(?i:\w{3})

            //string strippedText = String.Join("", readText.Where(c => !char.IsWhiteSpace(c)));

            var dict = Regex.Matches(readText, @"\w{3}", RegexOptions.Compiled | RegexOptions.IgnoreCase)
                .Cast<Match>()
                .GroupBy(o => o.Value.ToLower())
                .ToDictionary(o => o.Key, o => o.Count());

            foreach (var d in dict)
            {
                Console.WriteLine(d.Value + " " + d.Key);
            }

            Console.WriteLine(dict["tra"]);
            Console.WriteLine(dict["the"]);
            Console.WriteLine(dict["pre"]);
            Console.ReadLine();

        }
    }
}
