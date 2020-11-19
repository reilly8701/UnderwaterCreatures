using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwaterCreatures
{
    class Food:Item
    {

        //Attributes
        protected bool Edible;

        // Constructor

        public Food(string t, string n, bool e): base(t,n,e)
        {
            
        }
    }
}
