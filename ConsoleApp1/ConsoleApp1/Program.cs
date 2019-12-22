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
        protected void display(int x, int y, string s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                Program p = new Program();
                p.display(0, 0, $"{i} %");
                p.display(i, 1, "#");
                
            }
            Console.ReadLine();
        }
    }
}
