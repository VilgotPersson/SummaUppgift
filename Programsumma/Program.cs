using System;
using System.IO;
using System.Collections.Generic;
namespace Programsumma
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath=@"C:\Users\Admin\Desktop\Programsumma\Summa.txt";
            
            int i = 0;
            int summa = 0;
            string rad= "";

            StreamReader sr = new StreamReader(filepath);
            List<string> textRader = new List<string>();

            while((rad=sr.ReadLine()) != null)
            {
                summa += int.Parse(rad);
                textRader.Add(rad);
                if(rad.Contains("5"))
                i++;
            } 
            sr.Close();
            Console.WriteLine("Summan är: " + summa);
            Console.WriteLine("Antalet femmor är: " + i);
        }
    }
}
