using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        protected void Display(int x, int y, string s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        static void Main(string[] args)
        {
            int userNumber;
            int suma = 0;
            Console.Write("Iveskite bet koki skaiciu: ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x <= userNumber; x++)
            {
                suma = suma + x;
            }
            Console.Clear();

            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50);
                Program p = new Program();
                p.Display(0, 0, $"Skaiciuojama... {i} %");
                p.Display(i, 1, "#");
                
            }
            Console.WriteLine();
            Console.WriteLine("Suma nuo 1 iki {0} yra {1}", userNumber, suma);
            Console.ReadLine();
        }
    }
}
