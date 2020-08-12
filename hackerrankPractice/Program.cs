using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrankPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = caesarCipher(s, k);
            Console.WriteLine(result);

            /*
            
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

            */
            //Original alphabet:      abcdefghijklmnopqrstuvwxyz333
            //Alphabet rotated + 3:    defghijklmnopqrstuvwxyzabc

            Console.ReadKey();
        }
        static string caesarCipher(string s, int k)
        {
            byte[] ASCIIValues = Encoding.ASCII.GetBytes(s);
            for (int i=0;i< ASCIIValues.Length;i++)
            {
                int z = k;
                if (65 <= ASCIIValues[i] && ASCIIValues[i] <= 90)
                {
                    while (z != 0)
                    {
                        if (ASCIIValues[i] == 90)
                        {
                            ASCIIValues[i] = 64;
                        }
                        ASCIIValues[i]++;
                        z--;
                    }
                }
                else if (97 <= ASCIIValues[i] && ASCIIValues[i] <= 122)
                {
                    while (z != 0)
                    {
                        if (ASCIIValues[i] == 122)
                        {
                            ASCIIValues[i] = 96;
                        }
                        ASCIIValues[i]++;
                        z--;
                    }
                }
            }
            return System.Text.Encoding.ASCII.GetString(ASCIIValues);
        }
    }
}
