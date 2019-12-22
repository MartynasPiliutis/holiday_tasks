using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        protected void Display (int x, int y, string s)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
        static void Main(string[] args)
        {
            int userNumber = 0;
            Console.Write("Iveskite eiluciu skaiciu: ");
            userNumber = Convert.ToInt32(Console.ReadLine());
            int cursorPositionX = userNumber;
            int cursorPositionY = userNumber;
            Console.Clear();
            for (int i = 0; i < userNumber; i++)
            {
                for (int a = 0; a < i+1; a = a+1)
                {
                    Program p = new Program();
                    p.Display(cursorPositionY, i, "*");
                    cursorPositionY = cursorPositionY + 2;
                }
                cursorPositionY = cursorPositionX - 1;
                cursorPositionX = cursorPositionY;
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
