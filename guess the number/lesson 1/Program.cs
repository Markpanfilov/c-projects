using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            bool iswin = false;
            int secretnumber = rd.Next(1,11);
            int attempts = 3;
            Console.WriteLine("This computer chose a number from 1 to 10. Your goal is to find out what the number is. ");
            while (attempts > 0)
            {


                Console.Write("ENTER NUMBER :  ");
                int usernumber = int.Parse(Console.ReadLine());
                if (usernumber > secretnumber)
                {
                    Console.WriteLine($"THE SECRET NUMBER IS SMALLER THAN {usernumber}");


                }
                else if (usernumber == secretnumber)
                {
                    iswin = true;

                }

                else
                {
                    Console.WriteLine($"THE SECRET NUMBER IS BIGGER THAN {usernumber}");

                }

                attempts--;
                if (iswin == true)
                {
                    Console.WriteLine("YOU HAVE GUESSED THE NUMBER");
                    break;

                }
                else if (attempts == 0) {
                    Console.WriteLine($"YOU LOST. THE SECRET NUMBER WAS:{secretnumber}");
                }
            }
                Console.ReadKey();
        }
    }
}
