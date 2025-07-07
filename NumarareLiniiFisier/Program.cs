using System;
using System.IO;
namespace NumarareLiniiFisier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string locatieFisier = @"C:\C#\ExempluProgramNumarare.docx";
            if (File.Exists(locatieFisier))
            {
                string[] linii = File.ReadAllLines(locatieFisier);
                Console.WriteLine($"Numarul de linii este {linii.Length} ");
            }
            else
            {
                Console.WriteLine("Fisierul nu exista");
            }
        }
    }
}
