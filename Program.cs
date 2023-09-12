using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2.ödev._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************EXAM SYSTEM ******************");
            Random rand = new Random();
            while (true)
            {
               int number1 = rand.Next(1,10);
               int number2 = rand.Next(1,10);
                Console.WriteLine($"\n{number1} kere {number2} kaçtır?");
                int answer = int.Parse( Console.ReadLine() );
                int correctAnswer = number1 * number2;
                if (answer == correctAnswer)
                {
                    Console.WriteLine("*Very Nice*");

                    Console.ReadLine();
                   
                    break;
                }
                else
                {
                    Console.WriteLine("try again");
                    while( answer != correctAnswer )
                    {
                        Console.WriteLine($"{number1} kere {number2} kaçtır ?");
                        answer = int.Parse( Console.ReadLine() );
                    }
                    Console.WriteLine("very nice");
                    Console.ReadLine() ;
                    break;
                }
            }
        }
    }
}
