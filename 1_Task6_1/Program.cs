using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string dlinnoeSlovo = "";
            int dlinaSlova = 0;
            int i = 0;
            foreach (string s in stringArray)
            {
                if (s.Length > dlinaSlova)
                {
                    dlinaSlova = s.Length;
                    dlinnoeSlovo = s;
                    i = 0;
                }
                else
                {
                    if (s.Length == dlinaSlova)
                    {
                        dlinaSlova = s.Length;
                        dlinnoeSlovo += ", " + s;
                        i++;
                    }
                }
            }
            if (i > 0)
            {
                Console.WriteLine("Самые длинные слова в предложении: {0}", dlinnoeSlovo);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Самое длинное слово в предложении: {0}", dlinnoeSlovo);
                Console.ReadKey();
            }
        }
        

    }
}
