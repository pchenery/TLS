using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
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

            // Find matches.
            MatchCollection matches = rx.Matches(readText);

            // Report the number of matches found.
            Console.WriteLine("{0} matches found: ",
                matches.Count);

            // Report on each match.
            foreach (Match match in matches)
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                    groups["word"].Value,
                    groups[0].Index,
                    groups[1].Index);
            }

            //int counter = 0;

            //for (int i = 0; i < readText.Length; i++)
            //{
            //    if (readText[i] == 't' && readText[i + 1] == 'r' && readText[i + 2] == 'a')
            //    {
            //        counter++;
            //    }
            //}

            //Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
