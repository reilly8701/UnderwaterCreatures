using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnderwaterCreatures
{
    class Game
    {
        Random ran = new Random();
        // Class Attributes
        
        //TODO: List of Items to store default items
        List<Item> DefaultItems = new List<Item>()
        {
            new Item("Environment", "Coral"),
            new Item("Environment", "Seaweed"),
            new Food("Fish", "Salmon", true),
            new Food("Plant", "Kelp", true)
        };
        //TODO: List of Creatures to store deafult creatures
        private List<Creature> DefaultCreatures = new List<Creature>()
        {
            new Creature(20, "Cat","Cheese"),
            new Frog(5, "Amphibian", "Frogger"),
            new Mosasour(20, "Dinosaur", "Nessie"),
            new Platypus(42, "Mammal", "Perry")
        };
        //TODO Create default creatures and add to List
        //TODO Create default Items and Food (2 each minimum) and add to List

        //Hint: Creating a lists or arrays of the base class will allow you to store derived objects
        //i.e. List<Item> or Item[] these would store objects of Item AND objects of Food

        public void Start()
        {
            //TODO: Call Show method
            //Console.WriteLine("Underwater Creatures");
            Console.Clear();
            Show();
            //TODO: Call the Choose method
            ChooseCreature();
            //TODO: With the chosen creature, communicate or talk
            CreateCreature();

            AddItem();
            //TODO: Use Random to pass a random item from the food/item list to critter's Eat method
            Start();
        }

        public void Show()
        {
            //TODO: Show all creatures in the world
            //use a foreach loop to call their Communicate methods
            foreach (Creature c in DefaultCreatures)
            {
                c.Communicate();
            }
        }

        public void ChooseCreature()
        {
            //TODO: Search the list / array of creature instances for a specific creature
            for (int i = 0; i < DefaultCreatures.Count; i++)
            {
                Console.WriteLine($"{i + 1} {DefaultCreatures[i].about()}");
            }

            Console.WriteLine("Please enter the number of the creature you want to see.");
            string Input = Console.ReadLine();
            int Choice = Convert.ToInt32(Input);
            DefaultCreatures[Choice -1].Communicate();
            DefaultCreatures[Choice - 1].Eat(DefaultItems[Number(DefaultItems.Count)]);
            Console.ReadKey();
        }

        public void AddItem()
        {
            //TODO: Create an item and add to the default list
            //Hint: Player will need to chose from predefined types so think through what types you want
            Console.WriteLine("What type is your item?");
            string type = Console.ReadLine();
            Console.WriteLine("What is the name of your item?");
            string name = Console.ReadLine();
            Console.WriteLine("Is your item food? (Y/N)");
            string food = Console.ReadLine();

            if(food.ToUpper() == "Y")
            {
                DefaultItems.Add(new Food(type, name, true));
            }

            else
            {
                DefaultItems.Add(new Item(type, name));
            }
        }

        public void CreateCreature()
        {
            //TODO: Create Custom Creature
            //Let player choose Name, type, age
            Console.WriteLine("Name your creature.");
            string name = Console.ReadLine();
            Console.WriteLine("What type is your creature.");
            string type = Console.ReadLine();
            Console.WriteLine("How old is your creature.");
            string age = Console.ReadLine();
            int numb = Convert.ToInt32(age);

            DefaultCreatures.Add(new Creature(numb, type, name));
        }
        private int Number(int max)
        {
            return ran.Next(max);
        }
    }
}
