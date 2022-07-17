namespace Poke_Battle
{
    // defining the properties of the Pokemon class so any future instances will share these properties
    class Pokemon
    {
        public string Name;
        public int Health;
        public int Attack;
    }

    // im now creating lists of both my rivals and my own pokemon so I can select from them to decide who is battling who
    class Program
    {
        static List<Pokemon> garyPokemon = new List<Pokemon>() {
            new Pokemon {
                Name = "Mr.Mime",
                Health = 250,
                Attack = 500
            },
            new Pokemon {
                Name = "Dragonite",
                Health = 600,
                Attack = 600
            },
            new Pokemon {
                Name= "Electrode",
                Health = 300,
                Attack = 300
            },
            new Pokemon {
                Name = "Lapras",
                Health = 200,
                Attack = 50
            },
            new Pokemon {
                Name = "Haunter",
                Health = 400,
                Attack = 350
            },
            new Pokemon {
                Name = "Zapdos",
                Health = 500,
                Attack = 350
            }
        };


        static List<Pokemon> myPokemon = new List<Pokemon>() {
            new Pokemon {
                Name = "Blastoise",
                Health = 400,
                Attack = 350
            },
            new Pokemon {
                Name = "Charizard",
                Health = 500,
                Attack = 500
            },
            new Pokemon {
                Name = "Venasaur",
                Health= 600,
                Attack = 450
            },
            new Pokemon
            {
                Name = "Arcanine",
                Health = 400,
                Attack = 400
            },
            new Pokemon
            {
                Name = "Mewtwo",
                Health = 1000,
                Attack = 1000
            },
            new Pokemon
            {
                Name = "Articuno",
                Health = 500,
                Attack = 350
            }
        };

        static void Main(string[] args)
        {

            Console.WriteLine("Your rival Gary wants to battle!");
            Console.WriteLine("Do you accept? (yes or no)");


            string input = Console.ReadLine();
            string text = "";


            if (input == "yes")
                text = "Yeah let's show him whos boss!";
            else
                text = "This is no time to chicken out! We're doing this!";

            // this will randomly select an entry from the list garyPokemon to set our opponent
            var rnd = new Random();
            var randomChoice = garyPokemon[rnd.Next(garyPokemon.Count)];

            // now we'll randomly select a Pokemon from our list to fight
            var myChoice = myPokemon[rnd.Next(myPokemon.Count)];


            Console.WriteLine("");
            Console.WriteLine("Gary: Hehe this is gonna be too easy! I choose you, " + randomChoice.Name + "!");
            Console.WriteLine("");
            Console.WriteLine("Thats what you think! Lets go, " + myChoice.Name + "!");
            Console.WriteLine("");


            //Console.WriteLine("Please choose your Pokemon");

            // using a foreach loop here to print out each element of the list individually
            //foreach (var pokemon in myPokemon)
            //{
            //    Console.WriteLine(pokemon.Name);
            //}            

            //string myChoice = Console.ReadLine();

            //if (myChoice == "Blastoise")
            //    text = "Blastoise, the water type. Lets Blast'em away!";
            //else if (myChoice == "Charizard")
            //    text = "Charizard, the fiery dragon! Lets see if they can handle the heat!";
            //else if (myChoice == "Venasaur")
            //    text = "Venasaur, the plant type. They won't know what hit them!";
            //else if (myChoice == "Arcanine")
            //    text = "Arcanine, the fiery canine Pokemon!";
            //else if (myChoice == "Mewtwo")
            //    text = "Mewtwo, the most powerful Pokemon of them all!";
            //else 
            //    text = "Articuno, the legendary bird of ice!";

            //Console.WriteLine(message);
            //Console.ReadLine();

            // the above code is commented out as I realised I wouldnt be able to use a comparison operator to determine a winner when 
            // randomChoice was an int and myChoice would be a string


            Console.WriteLine("Type Go to Attack!");
            input = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("The ground trembles as these two titans engage in a fierce battle. However, there can be only one winner!");
            Console.WriteLine("");

            if (randomChoice.Attack > myChoice.Health)
                text = "Oh no! He got us this time! We'll be back though, stronger than ever!";
            else if (myChoice.Attack > randomChoice.Health)
                text = "We won! That was too easy. Looks like you need to do some training!";
            else
                text = "It's a draw! Lucky we went easy on ya";

            Console.WriteLine(text);
            Console.ReadLine();

        }
    }
}