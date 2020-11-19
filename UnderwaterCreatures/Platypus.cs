using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderwaterCreatures
{
    class Platypus:Creature
    {

        // Attributes


        //Constructor
        public Platypus(double a, string t, string n) : base(a, t, n)
        {
            
        }
        // Methods

        // Communicate
        public override void Communicate()
        {
            //TODO: Communicate - each creature should have a unique way of communicating
            Console.WriteLine("Grrr.");
        }


        // Move

        public override void Move()
        {
            // TODO: each creature should have a unique way to move
            
        }
    }
}
