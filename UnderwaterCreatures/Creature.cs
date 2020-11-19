using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwaterCreatures
{
    class Creature
    {
        protected double Age;
        protected string Type;
        public string Name = "name";
        protected bool Alive = true;


        // 4 Methods

        // Constructor
        public Creature()
        {
            
        }

        public Creature(double a, string t, string n)
        {
            Age = a;
            Type = t;
            Name = n;
        }

        public string about()
        {
            return Name;
        }

        // Eat

        public void Eat(Item i)
        {
            /*
             * TODO: method should accept an item as an argument (added already), 
             *  and a response should be written to the screen
             *  If the item is food the critter can eat it
             *  If the item is not food, the critter will not eat it
             *  */
            if(i.Edible)
            {
                Console.WriteLine("The creature eats the " + i.Name + ".");
            }
            else
            {
                Console.WriteLine("The creature didn't eat " + i.Name + ", it was inedible.");
            }
        }

        // Communicate
        public virtual void Communicate()
        {
           //Define in derived class only
           Console.WriteLine("Meow.");
        }


        // Move

        public virtual void Move()
        {
            //Define in derived class only
            
        }

    }
}
