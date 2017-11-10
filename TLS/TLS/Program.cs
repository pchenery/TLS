using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TLS
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\work\training\tls\sampletext.txt";

            //Open the file to read from.
            string readText = File.ReadAllText(path);

            int counter = 0;

            for (int i = 0; i < readText.Length; i++)
            {
                if (readText[i] == 't' && readText[i + 1] == 'r' && readText[i + 2] == 'a')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
