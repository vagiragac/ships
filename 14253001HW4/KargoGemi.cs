using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253001HW4
{
    class KargoGemi:Gemi
    {
        int kargoAlanAgirligi;
        public KargoGemi(string gemiName, string gemiYil,int Kagırlık)//constructor
            :base(gemiName,gemiYil)
        {
           KargoAlanAgirligi = Kagırlık;
        }
        public int KargoAlanAgirligi//property
        {
            get
            {
                return kargoAlanAgirligi;
            }
            set
            {
                if (value>0 && value<500)
                {
                    kargoAlanAgirligi = value;
                }
                else
                    throw new Exception("ağırlığı giremezsin:");
            }
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "kargonun ağırlığı:" + kargoAlanAgirligi + " " + "KG"; 
        }
    }
}
