using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System.IO_streamPisac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Upišite prezime: ");
            string prezime = Console.ReadLine();

            StreamWriter sw = new StreamWriter(
                @"c:\prviDir\mojaDatoteka.txt");

            sw.WriteLine("Ime: " + ime);
            sw.WriteLine("Prezime: " + prezime);
            sw.Close();

            StreamReader sr = new StreamReader(
                @"c:\prviDir\mojaDatoteka.txt");

            while(!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();

            Console.ReadKey();
        }
    }
}
