using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string Outfit = "";
            string Shoes = "";

            if (10<=degree&&degree<=18)
            {
                switch (partOfDay)
                {
                    case "Morning":
                        Outfit = "Sweatshirt";
                        Shoes = "Sneakers";
                        break;
                    case "Afternoon":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;

                    default:
                        break;
                }
            }
            else if (18<degree&&degree<=24)
            {
                switch (partOfDay)
                {
                    case "Morning":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                        break;
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;

                    default:
                        break;
                }
            }
            else if (degree>=25)
            {
                switch (partOfDay)
                {
                    case "Morning":
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                        break;
                    case "Afternoon":
                        Outfit = "Swim Suit";
                        Shoes = "Barefoot";
                        break;
                    case "Evening":
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine($"It's {degree} degrees, get your {Outfit} and {Shoes}.");





        }
    }
}
