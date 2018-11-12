using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LZSS
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(@"f:\input.txt");

            string compressed=LZSS.CompressLZSS(input);


            var decompressed = LZSS.DecompressLZSS(compressed);

            int compresion = (compressed.Length)*100/input.Length;
            bool sth = (input.Equals(decompressed));

            Console.WriteLine(input);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(compressed);

            Console.WriteLine(Environment.NewLine+Environment.NewLine+Environment.NewLine);

            if (sth)
            {
                Console.WriteLine("Teksty się zgadzają");
            }
            else
            {
                Console.WriteLine("Teksty się nie zgadzają");
            }

            Console.WriteLine("Kompresja: "+compresion+"%");

            

            Console.ReadLine();
        }
    }
}
