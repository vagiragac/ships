using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253001HW4
{
    class Gemi
    {
       public string gemiName;
       public string gemiYil;

        public Gemi(string gemiName, string gemiYil)//constructor
           
        {
            this.gemiName = gemiName;
            this.gemiYil = gemiYil;
            
        }

        public string GemiName//property
        {
            get
            {
                return gemiName;
            }

            set
            {
                gemiName = value;
            }
        }

        public string GemiYil
        {
            get
            {
                return gemiYil;
            }

            set
            {
                gemiYil = value;
            }
        }
        public override string ToString()
        {
           return "Geminin ismi:" + gemiName + "\n" + "Geminin inşa edildiği yıl:" + gemiYil;
        }
    }
}
