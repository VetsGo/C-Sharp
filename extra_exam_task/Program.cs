using System;
using System.Collections.Generic;
using System.Linq;

namespace Headphone
{
    class Program
    {
        // Реалізація вибору покупцем характеристик і вивід результату.
        static void Main(string[] args)
        {
            Headphone headlist = new Headphone();

            Console.WriteLine("Enter headphone color:");
            var electcolor = Console.ReadLine();
            var color = new List<string> { electcolor };

            Console.WriteLine("Enter headphone graduation year:");
            var year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter headphone price:");
            var price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter headphone categorie:");
            var categorie = Console.ReadLine();

            Headphone.Headp choosed = headlist.Headrun(color, year, price, categorie, electcolor);
        }
    }

    public class Headphone
    {
        //Набір з 5 пар навушників і їх розписані характеристики
        private List<Headp> heads = new List<Headp>
        {
            new Headp {colors = new List<string> {"blue", "green", "orange", "yellow", "purple"}, year = 2023, price = 5000, categories = "over-ear"},
            new Headp {colors = new List<string> {"brown", "gray", "red", "orange", "green"}, year = 2020, price = 6000, categories = "on-ear"},
            new Headp {colors = new List<string> {"violet", "tan", "teal", "peach", "cyan"}, year = 2022, price = 5500, categories = "earbud"},
            new Headp {colors = new List<string> {"gray", "orange", "green", "tan", "pink"}, year = 2021, price = 4500, categories = "in-ear"},
            new Headp {colors = new List<string> {"white", "purple", "silver", "pink", "green"}, year = 2022, price = 6600, categories = "over-ear"}
        };
        //4 характеристики на 1 навушник
        public class Headp
        {
            public List<string> colors;
            public int year;
            public int price;
            public string categories;
        }
       //Перевірка введених характеристик з існуючими і повернення результату
        public Headphone.Headp Headrun(List<string> colors, int year, int price, string categorie, string elect)
        {
            Headp result = heads.Find(headp => colors.Any(color => headp.colors.Contains(color)) && headp.year == year && headp.price == price && headp.categories == categorie);

            if (result == null)
            {
                Console.WriteLine("There is no headphone (tablet) with these parameters");
            }
            else
            {
                Console.WriteLine("****wait****");
                Console.WriteLine("Headphone (tablet) exist. Description:");
                Console.WriteLine("Color: " + elect);
                Console.WriteLine("Year: " + year);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Categorie: " + categorie);
            }
            return result;
        }
    }
}
