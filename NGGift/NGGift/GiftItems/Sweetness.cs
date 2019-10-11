using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NGGift
{
    public abstract class Sweetness
    {
        string name { get; set; }
        double weight { get; set; }
        int caloric { get; set; }
        double price { get; set; }

        public Sweetness()
        {
            name = null;
            weight = 0;
            caloric = 0;
            price = 0;
        }

        public Sweetness(string name, double weight, int caloric, double price)
        {
            this.name = name;
            this.weight = weight;
            this.caloric = caloric;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Caloric
        {
            get { return caloric; }
            set { caloric = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Fill(string word, int n)
        {
            switch (n)
            {
                case 2:
                    {
                        Name = word;
                        break;
                    }
                case 3:
                    {
                        Weight = Convert.ToDouble(word);
                        break;
                    }
                case 4:
                    {
                        Caloric = Convert.ToInt32(word);
                        break;
                    }
                case 5:
                    {
                        Price = Convert.ToDouble(word);
                        break;
                    }
            }
        }

        public abstract void FillProperties(string word, int n);
        public abstract void GetInfo();
        public abstract void Writer(StreamWriter writer);
    }
}
