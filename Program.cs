using System;

namespace SourceCol
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            do{
                Console.WriteLine("1) Print string until the 20th character");
                Console.WriteLine("2) Does X number is on the fibonacci sequence?");
                Console.WriteLine("3) Ordering an Array");
                Console.WriteLine("4) Car list");
                Console.WriteLine("5) Rick & Morty character names");
                Console.WriteLine("6) Exit(or above)");
                Console.WriteLine("---");
                Console.Write("Select the option number: ");
                flag = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("*****************************************");
                Console.WriteLine(" ");
                switch(flag) 
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;
                    case 2:
                        Console.WriteLine("Case 2");
                        break;
                    case 3:
                        Console.WriteLine("Case 3");
                        break;
                    case 4:
                        Console.WriteLine("Case 4");
                        break;
                    case 5:
                        Console.WriteLine("Case 5");
                        break;
                    default:
                        Console.WriteLine("Case "+flag);
                        break;
                }
                Console.WriteLine(" ");
                Console.WriteLine("*****************************************");
                Console.WriteLine(" ");
            } while(flag < 6);
        }
    }
}
