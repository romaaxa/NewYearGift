using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NGGift
{
    public class Candy : Sweetness
    {
        int percocao { get; set; }
        string filling { get; set; }

        public Candy() : base()
        {
            percocao = 0;
            filling = null;
        }

        public Candy(string name, double weight, int caloric, double price, int percocao, string filling) : base(name, weight, caloric, price)
        {
            this.percocao = percocao;
            this.filling = filling;
        }

        public int PerCocao
        {
            get { return percocao; }
            set { percocao = value; }
        }

        public string Filling
        {
            get { return filling; }
            set { filling = value; }
        }


        public override void FillProperties(string word, int n)
        {
            if (n < 6) Fill(word, n);
            else if (n == 6) percocao = Convert.ToInt32(word);
            else if (n == 7) filling = word;
        }

        public override void GetInfo()
        {
            Console.WriteLine(Name + "  " + Weight + "g.  " + Caloric + "cal.  " + Price + "rub.  " + percocao + "%  " + filling);
        }

        public override void Writer(StreamWriter writer)
        {
            writer.WriteLine(Name + "  " + Weight + "g.  " + Caloric + "cal.  " + Price + "rub.  " + percocao + "%  " + filling);
        }
    }
}
