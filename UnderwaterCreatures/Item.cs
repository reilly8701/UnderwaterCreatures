using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwaterCreatures
{
    class Item
    {
        public string Type, Name;
        public bool Edible = false;

        //Constructor

        public Item()
        {
            
        }

        public Item(string t,string n)
        {
            Type = t;
            Name = n;
        }

        public Item(string t, string n, bool e)
        {
            Type = t;
            Name = n;
            Edible = e;
        }

        // Methods if needed
    }
}
