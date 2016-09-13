using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningSkolan
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<VåraPizzor> allPizzaList = new List<VåraPizzor>();

            VåraPizzor pizza1 = new VåraPizzor();
            pizza1.name = "Margarita";
            pizza1.price = 50m;

            VåraPizzor pizza2 = new VåraPizzor();
            pizza2.name = "Vesuvio";
            pizza2.price = 60m;

            VåraPizzor pizza3 = new VåraPizzor();
            pizza3.name = "Hawai";
            pizza3.price = 70m;

            allPizzaList.Add(pizza1);
            allPizzaList.Add(pizza2);
            allPizzaList.Add(pizza3);

            Console.WriteLine("Våra pizzor: " + Environment.NewLine
                              + "1: " + pizza1.name + " " + pizza1.price);
            Console.WriteLine("2: " + pizza2.name + " " + pizza2.price);
            Console.WriteLine("3: " + pizza3.name + " " + pizza3.price);

            int Margarita = 0;
            int Vesuvio = 0;
            int Hawai = 0;

            while (true)
            {
                Console.WriteLine("Vilka/vilken pizzor vill ha? Mata in 1-3.");
                int pick = int.Parse(Console.ReadLine());
                if (pick == 1)
                {
                    Margarita++;
                }
                if (pick == 2)
                {
                    Vesuvio++;
                }
                if (pick == 3)
                {
                    Hawai++;
                }
                Console.WriteLine("Välja en till? Y/N");
                string answer = Console.ReadLine().ToLower();
                if (answer != "y")
                {
                    break;
                }
            }

            List<VåraPizzor> shopList = new List<VåraPizzor>();
            while (Margarita > 0 || Vesuvio > 0 || Hawai > 0)
            {
                if (Margarita > 0)
                {
                    shopList.Add(pizza1);
                    Margarita--;
                }
                else if (Vesuvio > 0)
                {
                    shopList.Add(pizza2);
                    Vesuvio--;
                }
               else if (Hawai > 0)
                {
                    shopList.Add(pizza3);
                    Hawai--;
                }
            }



        }
    }
}