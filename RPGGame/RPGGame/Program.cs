using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    class Program
    {
        static StartGame main = new StartGame();
        // Program entry.
        static void Main(string[] args)
        {
            while (main.Update != main.Exit)
            {

                main.Update();
            }
            
        }
    }

    class StartGame
    {
        public delegate void pointer();
        public pointer Update;
        string choice = String.Empty;
        bool bIncorrectChoice = true;

        private string[] menus = new string[]
        {
            ("\t 1. Start Game | 2. Exit Game"),
            ("\t b. Battle | c. Character Info"),
            ("\t a. Attack | r. Run"),
            ("\t s. Shield | sw. Sword"),
            ("\t b. Battle | e. Exit")
        };

        public StartGame()
        {
            // Pointer will change.
            this.Update = main_menu;
        }

        /// <summary>
        /// 
        /// </summary>
        public void main_menu()
        {
            Console.WriteLine("\t    * * * * Welcome to Katie's RPG! * * * *");
            Console.WriteLine(menus[0]); // Main Menu
            Console.WriteLine();
            choice = Ask();
            bIncorrectChoice = true;

            while (bIncorrectChoice)
            {
                // Menu choices
                if (choice == "1")
                {
                    this.Update = Start;
                    bIncorrectChoice = false;
                }
                else if (choice == "2")
                {
                    this.Update = Exit;
                    bIncorrectChoice = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid option. Please select 1 or 2");
                    choice = Ask();
                }
            }
            
                            
        }

        public string Ask()
        {
            Console.Write("Choice|");
            return Console.ReadLine();
        }

        public void Start()
        {
            Console.WriteLine(menus[1]);
            choice = Ask();
            bIncorrectChoice = true;

            while (bIncorrectChoice)
            {
                // Menu choices
                if (choice == "b")
                {
                    this.Update = Battle;
                    bIncorrectChoice = false;
                }
                else if (choice == "c")
                {
                    this.Update = CharacterInfo;
                    bIncorrectChoice = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid option. Please select b or c");
                    choice = Ask();
                }
            }
        }

        public void Exit()
        {
            Console.WriteLine("Thanks for playing!");
            Environment.Exit(0);
        }

        public void Battle()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 2);

            if(random == 1)
            {
                Console.WriteLine("You have come across an evil dragon");
            }
            else
            {
                Console.WriteLine("You have come across an evil troll");
            }
            Console.WriteLine(menus[2]);
            choice = Ask();
            bIncorrectChoice = true;

            while (bIncorrectChoice)
            {
                // Menu choices
                if (choice == "a")
                {
                    this.Update = Attack;
                    bIncorrectChoice = false;
                }
                else if (choice == "r")
                {
                    this.Update = Exit;
                    bIncorrectChoice = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid option. Please select a or r");
                    choice = Ask();
                }
            }

        }

        public void Attack()
        {
            Console.WriteLine("Which weapon would you like to use?");
            Console.WriteLine(menus[3]);
            choice = Ask();
            bIncorrectChoice = true;

            while (bIncorrectChoice)
            {
                // Menu choices
                if (choice == "s")
                {
                    Console.WriteLine("Congratulations you hit the evil monster with your shield and killed him!");
                    bIncorrectChoice = false;
                }
                else if (choice == "sw")
                {
                    Console.WriteLine("Congratulations you stabbed the evil monster with your sword and killed him!");
                    bIncorrectChoice = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid option. Please select s or sw");
                    choice = Ask();
                }
            }

            Console.WriteLine("Would you like to battle another monster or exit the game?");
            Console.WriteLine(menus[4]);
            choice = Ask();
            bIncorrectChoice = true;

            while (bIncorrectChoice)
            {
                // Menu choices
                if (choice == "b")
                {
                    this.Update = Battle;
                    bIncorrectChoice = false;
                }
                else if (choice == "e")
                {
                    this.Update = Exit;
                    bIncorrectChoice = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid option. Please select b or e");
                    choice = Ask();
                }
            }
        }

        public void CharacterInfo()
        {
            Console.WriteLine("You are a knight traveling around a distant land battling monsters in hopes to find your Princess.");
            Console.WriteLine("The weapons you have are a shield that can protect you and be used to hit monsters and a sword.");
            Console.WriteLine(menus[4]);
            choice = Ask();
            bIncorrectChoice = true;

            while (bIncorrectChoice)
            {
                // Menu choices
                if (choice == "b")
                {
                    this.Update = Battle;
                    bIncorrectChoice = false;
                }
                else if (choice == "e")
                {
                    this.Update = Exit;
                    bIncorrectChoice = false;
                }
                else
                {
                    Console.WriteLine("Sorry that is not a valid option. Please select b or e");
                    choice = Ask();
                }
            }


        }
    }

}
