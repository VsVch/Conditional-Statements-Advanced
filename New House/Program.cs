using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFlowers = Console.ReadLine();
            double numOfFlowers = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());

            double priceOfRoses = 5.00;
            double priceOfDalias = 3.80;
            double priceOfLales = 2.80;
            double priceOfNarcisis = 3.00;
            double priceOfGladiolias = 2.50;

            double discount = 0.00;
            double priceForFullGarden = 0.00;
            double priceForFlowers = 0.00;

            if (kindOfFlowers == "Roses" && numOfFlowers > 80)
            {
                discount = 10;
            }
            else if (kindOfFlowers == "Dahlias"&&numOfFlowers > 90)
            {
                discount = 15;
            }
            else if (kindOfFlowers == "Tulips" && numOfFlowers > 80)
            {
                discount = 15;
            }
            else if (kindOfFlowers == "Narcissus"&&numOfFlowers < 120)
            {
                discount = -15;
            }
            else if (kindOfFlowers == "Gladiolus"&&numOfFlowers<80)
            {
                discount = -20;
            }

            switch (kindOfFlowers)
            {
                case "Roses":
                    priceForFlowers = priceOfRoses;
                    break;
                case "Dahlias":
                    priceForFlowers = priceOfDalias;
                    break;
                case "Tulips":
                    priceForFlowers = priceOfLales;
                    break;
                case "Narcissus":
                    priceForFlowers = priceOfNarcisis;
                    break;
                case "Gladiolus":
                    priceForFlowers = priceOfGladiolias;
                    break;


                default:
                    break;
            }



            priceForFullGarden = priceForFlowers*numOfFlowers;
            priceForFullGarden = priceForFullGarden - priceForFullGarden*discount/100;

            double moneyRestNeeded = Math.Abs(priceForFullGarden-budjet);



            if (priceForFullGarden<budjet)
            {
                Console.WriteLine($"Hey, you have a great garden with {numOfFlowers} {kindOfFlowers} and {moneyRestNeeded:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyRestNeeded:f2} leva more.");
            }








        }
    }
}
