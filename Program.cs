using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

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
                        List<Car> cars = new List<Car>();
                        cars.Add(new Car("test1", 1991, "red"));
                        cars.Add(new Car("test2", 2018, "yellow"));
                        cars.Add(new Car("test3", 2020, "black"));
                        cars.Add(new Car("test4", 2021, "red"));
                        cars.Add(new Car("test5", 2015, "green"));
                        cars.Add(new Car("test6", 2000, "white"));
                        cars.Add(new Car("test7", 2023, "blue"));
                        cars.Add(new Car("test8", 2017, "blue"));
                        var recentModels = newCarsList(cars);
                        foreach (var c in recentModels)
                        {
                            Console.WriteLine("Brand: "+c.brand+" model: "+c.model);
                        }
                        break;
                    case 5:
                        var client = new WebClient();
                        string url = "https://rickandmortyapi.com/api/character";
                        do{
                            var text = client.DownloadString(url);
                            Root root = JsonConvert.DeserializeObject<Root>(text);
                            var pjs = root.results;
                            foreach (var pj in pjs)
                            {
                                Console.WriteLine(pj.name);
                            }
                            url = root.info.next;
                        } while (!String.IsNullOrEmpty(url));
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
        static List<Car> newCarsList(List<Car> cars){
            var year = Convert.ToInt32(DateTime.Now.Year);
            var newCars = from c in cars where year - 5 <  c.model select c;
            List<Car> recentModels = new List<Car>();
            foreach (var c in newCars)
            {
                recentModels.Add(new Car(c.brand, c.model, c.color));
            }
            return recentModels;
        }
    }
}
