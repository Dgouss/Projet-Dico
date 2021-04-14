﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Controller
    {
        public string source;
        public string resultat;
        public string resultat1;
        public string Label;
        public string varResult;
        public void CountChar(bool save)
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
                    resultat1 = String.Format("Letter: {0}  Frequency: {1}", (char)i, c[i]);
                    
                    if (save)
                    { 
                        WriteSave(String.Format("Letter: {0}  Frequency: {1}", (char)i, c[i]));
                    }
                    WriteVariable(String.Format("Letter: {0}  Frequency: {1}", (char)i, c[i]));
                    Console.WriteLine("Letter: {0}  Frequency: {1}", (char)i, c[i]);

                }
            }
        }
        public void CountWord(bool save)
        {
            varResult = "";
            // 1.
            // Array to store frequencies.
            int[] c = new int[(int)char.MaxValue];

            // 2.
            // Read entire text file.
            string s = File.ReadAllText(source);
            string[] w = s.Split();

            // 3.
            // Iterate over each character.
            int[] count;
            count = new int[50];
            for (int i = 1; i < count.Length; i++)
            {
                count[i] = 0;
            }
            foreach (string t in w)
            {
                count[t.Length]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    //resultat = String.Format("Mot de {0} caractères : {1}", i, count[i]);
                    if (save)
                    {
                        WriteSave(String.Format("Mot de {0} caractères : {1}", i, count[i]));
                    }
                    WriteVariable(String.Format("Mot de {0} caractères : {1}", i, count[i]));
                    Console.WriteLine("Mot de {0} caractères : {1}", i, count[i]);
                }
            }
        }
        public void WriteSave(string result)
        {
            string directory = @"C:\Users\donag\Documents\Documents\A COURS CESI\A3\Fichier_rattrapagC#";
            if (!Directory.Exists(directory))
            {
                directory = @"C:\Users\donag\Documents\Documents\A COURS CESI\A3\Fichier_rattrapagC#";
            }
            string path = directory + @"\" + Label + ".json";
            if (result != null)
            {
                string json = JsonConvert.SerializeObject(result, Formatting.Indented);
                File.WriteAllText(path, json + "\n");
            }
        }

        public void WriteVariable(string result)
        {
            if (result != null)
            {
                varResult = varResult + result + "\n";
            }
        }
    }
}
