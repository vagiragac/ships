using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253001HW4
{
    class TuristikGemi:Gemi
        
    {
        int maxYolcu;
      

        public TuristikGemi(string gemiName, string gemiYil,int maxYolcu)//constructor
            :base(gemiName,gemiYil)
        {
            MaxYolcu = maxYolcu;
        }
        public int MaxYolcu//property
        {
            get
            {
                return maxYolcu;
            }

            set
            {
                if (value >= 0 && value <= 500)
                    maxYolcu = value;
                else
                    throw new Exception("kişi sayısı yanlış girilmiş:");
            }
        }


        public override string ToString()
        {
            return base.ToString() + "\n" + "Maximum yolcu kapasitesi:" + MaxYolcu + " "+ "KİŞİ";
        }
    }
}
