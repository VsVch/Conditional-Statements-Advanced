using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfCinema = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double Premiere = 12.00;
            double Normal = 7.50;
            double Discount = 5.00;
            double price = 0.00;
            double allOfPrice = 0.00;
            int s = num1 * num2;


            switch (typeOfCinema)
            {
                case "Premiere":
                    allOfPrice = s * Premiere;
                    break;
                case "Normal":
                    allOfPrice = s * Normal;
                    break;
                case "Discount":
                    allOfPrice = s * Discount;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            Console.WriteLine($"{allOfPrice:f2} leva");
           



        }
    }
}
