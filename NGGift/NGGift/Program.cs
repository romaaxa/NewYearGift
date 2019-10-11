using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NGGift
{
    class Program                      //Fruit  Banana  20  62  12,80  78  34             
    {
        public static void Task_1(Gift g)   //If no fruits, add any two fruit.
        {
            g.AddFruit();
            g.OutPut();
        }

        public static void Task_2(Gift g)   //Try to find the haviest candy
        {
            Candy c = new Candy();
            c = g.TheHaviestCandy();
            Console.Write("The haviest candy is: "); c.GetInfo();
            Console.WriteLine("---------------------------------------------");
        }

        public static void Task_3(Gift g)   //Try to sort by caloric
        {
            g.Sort();
            g.OutPut();
            Console.WriteLine("The list was sorted by calories.");
            Console.WriteLine("---------------------------------------------");
        }


        public static void Task_4(Gift g)   //Calculate the weight of the gift and if the weight is bigger than 1kg, delete the haviest candy in the gift
        {
            Console.WriteLine("The weight of the gift is " + g.CalculateWeight() + " gramms.");
            Console.WriteLine("The price of the gift is " + g.CalculatePrice() + " rubles.");
        }

        public static void Task_5(Gift g)   //Form output file and try to write each element and the sum of the gift
        {
            g.OutPutFile(@"E:\hackerman\txtfiles\output.txt");
        }

        static void Main(string[] args)
        {
            Gift g = new Gift();
            g.Parsing(@"E:\hackerman\txtfiles\input.txt");
            Task_1(g);
            Task_2(g);
            Task_3(g);
            Task_4(g);
            Task_5(g);
            Console.ReadKey();
        }
    }
}
