﻿using System;
using System.IO;

namespace Using_Block_Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\OneDrive\Cursos Udemy\C# COMPLETO 2020\Using_Block_Example_01\temp\file01.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream) // vai ler todas as linhas do meu arquivo.
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
