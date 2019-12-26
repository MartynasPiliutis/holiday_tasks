using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sakinys =
            {
                "sesios",
                "zasys",
                "su",
                "sesiais",
                "zasiukais"
            };

            for (int i = 0; i < sakinys.Length; i++)
            {
                Console.Write(sakinys[i]);
                Console.Write(" ");
            }
            Console.ReadLine();

            int y = 0;
            string[] sakinysNew = new string[5];

            for (int x = sakinys.Length-1; x >= 0; x--)
            {
                sakinysNew[y] = sakinys[x];
                y++;
            }

            for (int i = 0; i < sakinysNew.Length; i++)
            {
                Console.Write(sakinysNew[i]);
                Console.Write(" ");
            }
            Console.ReadLine();

        }
    }
}
