using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NGGift
{
    class Fruit : Sweetness
    {
        double VitC { get; set; }
        double VitA { get; set; }

        public Fruit() : base()
        {
            VitA = 0;
            VitC = 0;
        }

        public Fruit(string name, double weigth, int caloric, double price, double VitA, double VitC) : base(name, weigth, caloric, price)
        {
            this.VitA = VitA;
            this.VitC = VitC;
        }

        public double VitaminC
        {
            get { return VitC; }
            set { VitC = value; }
        }

        public double VitaminA
        {
            get { return VitA; }
            set { VitA = value; }
        }

        public override void FillProperties(string word, int n)
        {
            if (n < 6) Fill(word, n);
            else if (n == 6) VitA = Convert.ToDouble(word);
            else if (n == 7) VitC = Convert.ToDouble(word);
        }

        public override void GetInfo()
        {
            Console.WriteLine(Name + "  " + Weight + "g.  " + Caloric + "cal.  " + Price + "rub.  " + VitA + " vitamin A.  " + VitC + " vitamin C.");
        }

        public override void Writer(StreamWriter writer)
        {
            //StreamWriter writer = new StreamWriter(FileName);
            writer.WriteLine(Name + "  " + Weight + "g.  " + Caloric + "cal.  " + Price + "rub.  " + VitA + " vitamin A.  " + VitC + " vitamin C.");
            // writer.Close();
        }
    }
}
