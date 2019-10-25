using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NGGift
{
    class Waffle : Sweetness
    {
        string taste { get; set; }
        bool glaze { get; set; }

        public Waffle() : base()
        {
            taste = null;
            glaze = false;
        }

        public Waffle(string name, double weight, int caloric, double price, string taste, bool glaze) : base(name, weight, caloric, price)
        {
            this.taste = taste;
            this.glaze = glaze;
        }

        public string Taste
        {
            get { return taste; }
            set { taste = value; }
        }

        public bool Glaze
        {
            get { return glaze; }
            set { glaze = value; }
        }

        public override void FillProperties(string word, int n)
        {
            if (n < 6) Fill(word, n);
            else if (n == 6) taste = word;
            else if (n == 7)
            {
                if (word == "yes") glaze = true;
                else glaze = false;
            }
        }

        public override void GetInfo()
        {
            Console.WriteLine(Name + "  " + Weight + "g.  " + Caloric + "cal.  " + Price + "rub.  " + taste + " taste.  " + glaze + " glaze.");
        }

        public override void Writer(StreamWriter writer)
        {
            //StreamWriter writer = new StreamWriter(FileName);
            writer.WriteLine(Name + "  " + Weight + "g.  " + Caloric + "cal.  " + Price + "rub.  " + taste + " taste.  " + glaze + " glaze.");
            // writer.Close();
        }
    }
}
