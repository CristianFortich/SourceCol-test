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
                        Console.Write("Enter a string: ");
                        string wordToSlice = Console.ReadLine();
                        if(wordToSlice.Length<20){
                            Console.WriteLine(wordToSlice);
                        }else{
                            Console.WriteLine(wordToSlice.Substring(0,20)+"...");
                        }
                        break;
                    case 2:
                        Console.Write("Enter number to check: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        string result = isFibonacci(num) ? "number "+num+" is in the fibonacci sequence" : "number "+num+" is not in the fibonacci sequence";
                        Console.WriteLine(result);
                        break;
                    case 3:
                        int[] list = new int[] {2, 7, 4, 6, 1, 9};
                        Console.Write("Provided List: ");
                        printList(list);
                        int pairs = orderAndPairs(list);
                        Console.Write("Ordered List: ");
                        printList(list);
                        Console.WriteLine("this list has "+pairs+" pairs.");
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
                Console.ReadKey();
            } while(flag < 6);
        }
        static bool isPerfectSquare(int x){
            int aux = (int)Math.Sqrt(x);
            return (aux*aux == x);
        }
        static bool isFibonacci(int x){
            bool aux = isPerfectSquare(5*x*x+4) || isPerfectSquare(5*x*x-4);
            return aux;
        }
        static int orderAndPairs(int[] listToOrder){
            Array.Sort(listToOrder);
            Array.Reverse(listToOrder);
            int pairs = 0;
            foreach (var num in listToOrder)
            {
                if(num%2==0) pairs++;
            }
            return pairs;
        }
        static void printList(int[] list){
            foreach (var num in list)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine("");
        }
    }
}
