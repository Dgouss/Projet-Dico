using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace ConsoleApp1
{
    class Controller
    {
        public string source;
        public void CountChar()
        {
            // 1.
            // Array to store frequencies.
            int[] c = new int[(int)char.MaxValue];

            // 2.
            // Read entire text file.
            string s = File.ReadAllText(source);

            // 3.
            // Iterate over each character.
            foreach (char t in s)
            {
                // Increment table.
                c[(int)t]++;
            }

            // 4.
            // Write all letters found.
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0 &&
                    char.IsLetterOrDigit((char)i))
                {
                    Console.WriteLine("Letter: {0}  Frequency: {1}",
                        (char)i,
                        c[i]);
                }
            }
        }
    }
}
