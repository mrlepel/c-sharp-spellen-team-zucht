/*
 * Adventure!
 * by Ramin Schooleman, 9-10-2020
 * 
 * This work is a derivative of
 * "C# Adventure Game" by
 http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
*/
using System;
namespace adventure
{
    public static class Game
    {
        //character name
        static String CharacterName = "";
        static int Scenarios = 3;

        //print out game title and overview
        public static void StartGame()
        {

            Console.WriteLine("Adventure!");
            Console.WriteLine("Welcome to Adventure"!);
            NameCharacter();
            Choice();

        }

        //ask player for a name, and save it
        static string[] PartOne =
        {
            "Description of story ... and the choice Wallet or Flashlight",
            "... what happens if wallet is chosen...",
            "....more story....",
            "... more about what happens if wallet is chosen...",
            "... more about what happens if flashlight is chosen...",
            "Transition to next part of story...."
        };


        static void NameCharacter()
        {
            Console.WriteLine("What is the name of your character?");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Great! Your character is now named: " + CharacterName);
        }



        static void Choice()
        {
            for (int scenario = 3; scenario <= Scenarios; scenario++)
            {
                string input = "";

                switch (scenario)
                {
                    case 1:
                        //if scenario equals 1, statements here run
                        break;
                    case 2:
                        //if scenario equals 2, statements here run
                        break;
                    case 3:
                        //if scenario equals 3, statements here run    
                        break;
                    default:
                        //if scenario does not match any above
                        break;
                }

                Console.WriteLine("In front of you there is a tower. You see 2 items on the ground but you can only take one with you, the items are: A= wallet and a B= flashlight. Wich one do you choose a or b?");
                input = Console.ReadLine();


                if (input == "b")
                {
                    Console.WriteLine("Now see a tower. You choose the flashlight so you cant get lost and you found your way trough, you survived.");
                    input = Console.ReadLine();
                    Console.WriteLine("You see a vending machine but you dont have any money. A little bit further away you see a homeless man he has 2 dollars in his pocket. Do you want to steal the money or not. Type: steal if you want to steal. Type dont steal if you dont want to steal the money steal the money to keep going. ");
                    input = Console.ReadLine();

                    if (input == "steal")
                    {
                        Console.WriteLine("You have stolen the money, but the homeless man dies.");
                        input = Console.ReadLine();
                        Console.WriteLine("You see a vending machine. You have 5 dollars from the wallet you picked up from the homeless man. Choose between a candy and a apple.");
                        input = Console.ReadLine();

                        if (input == "candy")
                        {
                            Console.WriteLine("You ate the candy");
                            input = Console.ReadLine();
                            Console.WriteLine("Oh no there are wasp going after you, probely because of the candy. Do you want to hit them or run away?");
                            input = Console.ReadLine();

                            if (input == "run")
                            {
                                Console.WriteLine("You hav run away from the wasp and won!!!");
                            }

                            else
                            {
                                Console.WriteLine("You kill 3 wasp but there are to much you die and lost. Try again");
                            }
                        }

                        else
                        {
                            Console.WriteLine("You ate the apple and you die because the apple was poisend");
                        }

                    }

                    else
                    {
                        Console.WriteLine("You have not stolen the money and you DIE because of hunger.");
                    }
                }
                else
                {
                    Console.WriteLine("You now see a tower but you dont hav any light. So you need to find a way out. Go left or right");
                   
                    input = Console.ReadLine();

                    if (input == "left")
                    {
                        Console.WriteLine("You went left. You are out of the tower.");
                        input = Console.ReadLine();
                        Console.WriteLine("You see a vending machine. Because you choose for the wallet at the start you have 5 dollars you can buy a candy or a apple. Choose one.");
                        input = Console.ReadLine();

                        if (input == "candy")
                        {
                            Console.WriteLine("You ate the candy and you survived");
                            input = Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("You ate the apple and you die because the apple was poisend");
                        }

                    }

                    else
                    {
                        Console.WriteLine("You went right. You have died because you fell in lava. TRY AGAIN");
                    }
                }

            }


        }
        class Item { }
        class Program
        {
            static void Main()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Title = "ASCII Art";
                string title = @"
                /\      | |               | |                 
    /  \   __| |_   _____ _ __ | |_ _   _ _ __ ___ 
   / /\ \ / _` \ \ / / _ \ '_ \| __| | | | '__/ _ \
  / ____ \ (_| |\ V /  __/ | | | |_| |_| | | |  __/
 /_/    \_\__,_| \_/ \___|_| |_|\__|\__,_|_|  \___| ";


                Console.WriteLine(title);
                Console.WriteLine("Press Enter to continue...");
                Console.ReadKey();
                Console.Clear();

                Game.StartGame();
                Console.ReadKey();


            }
        }
    }
}
