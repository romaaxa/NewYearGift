using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NGGift
{
    class Gift
    {
        List<Sweetness> sweetnesses = new List<Sweetness>();

        public void Parsing(string FileName)
        {
            StreamReader reader = File.OpenText(FileName);
            char ch;
            int n = 1;
            string type = "";
            string word = "";
            Candy candy = new Candy();
            Waffle waffle = new Waffle();
            Fruit fruit = new Fruit();
            while ((!reader.EndOfStream))
            {
                ch = Convert.ToChar(reader.Read());
                word = word + ch;
                if ((ch == ' ') && (word != " "))
                {
                    if ((ch == ' ') && (word[word.Length - 2] == ' '))
                    {
                        if (n == 1) type = word.Substring(0, word.Length - 2);
                        // Console.WriteLine(type);
                        if (type == "Candy") candy.FillProperties(word.Substring(0, word.Length - 2), n);
                        if (type == "Fruit") { fruit.FillProperties(word.Substring(0, word.Length - 2), n); }
                        if (type == "Waffle") waffle.FillProperties(word.Substring(0, word.Length - 2), n);
                        n++;
                        word = "";
                    }
                }
                if ((ch == '\n'))
                {
                    if (type == "Candy") { candy.FillProperties(word.Substring(0, word.Length - 1), n); sweetnesses.Add(candy); candy = new Candy(); n = 1; word = ""; }
                    if (type == "Fruit") { fruit.FillProperties(word.Substring(0, word.Length - 1), n); sweetnesses.Add(fruit); fruit = new Fruit(); n = 1; word = ""; }
                    if (type == "Waffle") { waffle.FillProperties(word.Substring(0, word.Length - 2), n); sweetnesses.Add(waffle); waffle = new Waffle(); n = 1; word = ""; }
                }
            }
        }

        public void AddFruit()
        {
            bool b = false;
            foreach (Sweetness s in sweetnesses)
            {
                if (s.GetType() == typeof(Fruit))
                {
                    b = true;
                    break;
                }
            }
            if (b == false)
            {
                Fruit f1 = new Fruit("Orange", 3.25, 45, 89.90, 3, 78);
                Fruit f2 = new Fruit("Banana", 5.67, 78, 67.35, 89, 10);
                sweetnesses.Add(f1);
                sweetnesses.Add(f2);
            }
        }

        public Candy TheHaviestCandy()
        {
            Candy c = new Candy();
            double w = 0;
            foreach (Sweetness s in sweetnesses)
            {
                if (s.GetType() == typeof(Candy))
                {
                    if (s.Weight > w) { w = s.Weight; c = (Candy)s; }
                }
            }
            return c;
        }

        public double CalculateWeight()
        {
            double weight = 0;
            foreach (Sweetness s in sweetnesses) weight = s.Weight + weight;
            if (weight > 1000) { weight = weight - TheHaviestCandy().Weight; sweetnesses.Remove(TheHaviestCandy()); }
            return weight;
        }

        public void Sort()
        {
            sweetnesses.Sort((v1, v2) => v1.Caloric.CompareTo(v2.Caloric));
        }

        public double CalculatePrice()
        {
            double sum = 0;
            foreach (Sweetness s in sweetnesses) sum = sum + s.Price;
            return sum;
        }

        public void OutPutFile(string FileName)
        {
            StreamWriter writer = new StreamWriter(FileName);
            foreach (Sweetness s in sweetnesses) s.Writer(writer);
            writer.WriteLine("The sum of the gift is " + CalculatePrice());
            writer.Close();
        }

        public void OutPut()
        {
            foreach (Sweetness s in sweetnesses)
            {
                s.GetInfo();
            }
        }
    }
}
