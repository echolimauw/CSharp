using System;
using System.Collections.Generic;

namespace Escape_Room_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
        }
        public class Game
        {
            public List<string> KeyList;
            public List<string> BasementItems;
            public List<string> GameRoomItems;
            public List<string> AtriumItems;
            public List<string> RoofItems;
            public Game()
            {
                KeyList = new List<string>();
                BasementItems = new List<string>()
                {
                    "Fire extinguisher",
                    "Wrench",
                    "Blow torch",
                    "Screwdriver"
                };
                GameRoomItems = new List<string>()
                {
                    "Dart",
                    "Controller",
                    "Putter",
                    "Stuffed badger"
                };
                
                AtriumItems = new List<string>()
                {
                    "Ladder",
                    "Rake",
                    "Shovel",
                    "Hose"
                };
                RoofItems = new List<string>()
                {
                    "Cable",
                    "Kite",
                    "Hammock",
                    "Branch"
                };
                // System.Console.WriteLine($"KeyList of 0 = {KeyList[0]})");
                KeyGen();
                // System.Console.WriteLine($"KeyList of 0 = {KeyList[0]})");
                Basement();
                GameRoom();
                Atrium();
                Roof();
            }
            public void KeyGen()
            {
                Random rand = new Random();
                string BasementKey = BasementItems[rand.Next(0,4)];
                KeyList.Add(BasementKey);
                // System.Console.WriteLine($"KeyList of 0 = {KeyList[0]})");
                string GameRoomKey = GameRoomItems[rand.Next(0,4)];
                KeyList.Add(GameRoomKey);
                string AtriumKey = AtriumItems[rand.Next(0,4)];
                KeyList.Add(AtriumKey);
                string RoofKey = RoofItems[rand.Next(0,4)];
                KeyList.Add(RoofKey);
                }
            public void Basement()
            {            
                Console.WriteLine("You find yourself in a dimly lit basement. In the corner is a furnace with a wide chimney running up to the next floor. You can also see a fire extinguisher next to the furnace, a pipe wrench on the floor, a blow torch by the basement door and a screwdriver sitting on a work bench. You try to open the door but it is locked. You have to escape!");
                Console.WriteLine("Options:");
                Console.WriteLine("Fire extinguisher");
                Console.WriteLine("Wrench");
                Console.WriteLine("Blow torch");
                Console.WriteLine("Screwdriver");
                Console.WriteLine("What would you like to use?");
                // System.Console.WriteLine($"Key = {KeyList[0]}");
                string pick = Console.ReadLine();
                if (pick == KeyList[0] && pick == "Fire extinguisher")
                {
                    System.Console.WriteLine("It worked! You smashed the door open with the Fire extinguisher and escaped to the next room!");
                }
                else if (pick == KeyList[0] && pick == "Wrench")
                {
                    System.Console.WriteLine("It worked! You bashed the doorknob off and broke out! On to the next room!");
                }
                else if (pick == KeyList[0] && pick == "Blow torch")
                {
                    System.Console.WriteLine("Hurray! You melted the lock and kicked the door open! On to the next room!");
                }
                else if (pick == KeyList[0] && pick == "Screwdriver")
                {
                    System.Console.WriteLine("Well done! You picked the lock with the screwdriver and can move on to the next room!");
                }
                else if (pick == "Furnace")
                {
                    System.Console.WriteLine("Ever the rebel, you just climb in the furnace and go up the chimney to the Game Room! See you there!");
                }
                else
                {
                    System.Console.WriteLine("Oh, no. That didn't work at all. Try something else.");
                    Basement();
                }
            }
            public void GameRoom()
            {            
                Console.WriteLine("You emerge into a game room with various games and trophies scattered throughout. You see a dartboard on the wall, a PlayStation with a Guitar Gyro controller plugged into it, a putter next to the putting green and stuffed taxidermy badger sitting on the mantle over the fireplace. This is better than a dark basement, but you're still not free.");
                Console.WriteLine("Options:");
                Console.WriteLine("Dart");
                Console.WriteLine("Controller");
                Console.WriteLine("Putter");
                Console.WriteLine("Stuffed badger");
                Console.WriteLine("What would you like to use?");
                // System.Console.WriteLine($"Key = {KeyList[1]}");
                string pick = Console.ReadLine();
                if (pick == KeyList[1] && pick == "Dart")
                {
                    System.Console.WriteLine("Great! You picked the door's lock with the dart and can move on to the next room!");
                }
                else if (pick == KeyList[1] && pick == "Controller")
                {
                    System.Console.WriteLine("Well done! You bashed the door open with the controller and can go to the next room!");
                }
                else if (pick == KeyList[1] && pick == "Putter")
                {
                    System.Console.WriteLine("Hurray! You smashed out the window in the door with the putter and unlocked it from the other side. On to the next room!");
                }
                else if (pick == KeyList[1] && pick == "Stuffed badger")
                {
                    System.Console.WriteLine("That's one way to do it. You hurled the stuffed badger through the door and escape to the next room.");
                }
                else if (pick == "PlayStation")
                {
                    System.Console.WriteLine("Using your exceptional hacking skills, you use the Playstation to gain access to the electronic lock in the door, open it and escape.");
                }
                else
                {
                    System.Console.WriteLine("Oh, no. That didn't work at all. Try something else.");
                    GameRoom();
                }
            }
            public void Atrium()
            {            
                Console.WriteLine("You pass through the door into a brightly lit atrium. Walls surround the space filled with small trees and shrubs. Looking up, you can see the sky through a hole in the walls and a loose cable from the roof hanging down into the atrium. In the atrium, you see a ladder set along the wall with a rake propped up over it. Next to the rake is a dirty shovel. Finally, there is a garden hose loosely coiled around a bearded garden gnome.");
                Console.WriteLine("Options:");
                Console.WriteLine("Ladder");
                Console.WriteLine("Rake");
                Console.WriteLine("Shovel");
                Console.WriteLine("Hose");
                Console.WriteLine("What would you like to use?");
                // System.Console.WriteLine($"Key = {KeyList[2]}");
                string pick = Console.ReadLine();
                if (pick == KeyList[2] && pick == "Ladder")
                {
                    System.Console.WriteLine("Perfect! You prop the ladder up against a wall and climb up to the roof!");
                }
                else if (pick == KeyList[2] && pick == "Rake")
                {
                    System.Console.WriteLine("Good thinking! You reach up to the hanging cable with the rake and climb up to the roof!");
                }
                else if (pick == KeyList[2] && pick == "Shovel")
                {
                    System.Console.WriteLine("It worked! You swing the shovel up, catch the hanging cable and climb up to the roof!");
                }
                else if (pick == KeyList[2] && pick == "Hose")
                {
                    System.Console.WriteLine("Good arm! You throw the end of the hose up to the roof. It hooks onto something and you climb up!");
                }
                else if (pick == "Gnome")
                {
                    System.Console.WriteLine("You walk over to the garden gnome and stroke its beard. It springs to life and says 'Oh, thank you! You've broken the curse and given me my life back! To thank you, let me help you on your way!' You are teleported to the roof!");
                }
                else
                {
                    System.Console.WriteLine("Oh, no. That didn't work at all. Try something else.");
                    Atrium();
                }
            }
            public void Roof()
            {    
                Random rand = new Random();
                Console.WriteLine("You're finally to the roof and you have nearly escaped! All you have to do is figure out a safe way down. Looking around, you see the loose cable attached to the roof and a kite that must have come free from its string. There is a hammock next to the pool that might be able to catch you and break your fall. There is also a branch from a tree that you might be able to reach and then climb down.");
                Console.WriteLine("Options:");
                Console.WriteLine("Cable");
                Console.WriteLine("Kite");
                Console.WriteLine("Hammock");
                Console.WriteLine("Branch");
                Console.WriteLine("What would you like to use?");
                // System.Console.WriteLine($"Key = {KeyList[3]}");
                string pick = Console.ReadLine();
                if (pick == KeyList[3] && pick == "Cable")
                {
                    System.Console.WriteLine("Nice work! You climb down the loose cable to safety! You escaped! Congratulations! Play again? (Y/N)");
                    string again = Console.ReadLine();
                    if (again == "Y")
                    {
                        KeyGen();
                        Basement();
                    }
                    else if (again == "N")
                    {
                        Console.WriteLine("Thanks for playing.");
                    }
                    else
                        System.Console.WriteLine("Please either select 'Y' for Yes or 'N' for no.");
                }
                else if (pick == KeyList[3] && pick == "Kite")
                {
                    System.Console.WriteLine("Good thinking! You hang on to the kite, jump off the roof and float down to safety! You escaped! Congratulations! Play again? (Y/N)");
                    string again = Console.ReadLine();
                    if (again == "Y")
                    {
                        KeyGen();
                        Basement();
                    }
                    else if (again == "N")
                    {
                        Console.WriteLine("Thanks for playing.");
                    }
                    else
                        System.Console.WriteLine("Please either select 'Y' for Yes or 'N' for no.");
                }
                else if (pick == KeyList[3] && pick == "Hammock")
                {
                    System.Console.WriteLine("Wow! You bravely leap down to the hammock, landing safely. You escaped! Congratulations! Play again? (Y/N)");
                    string again = Console.ReadLine();
                    if (again == "Y")
                    {
                        KeyGen();
                        Basement();
                    }
                    else if (again == "N")
                    {
                        Console.WriteLine("Thanks for playing.");
                    }
                    else
                        System.Console.WriteLine("Please either select 'Y' for Yes or 'N' for no.");
                }
                else if (pick == KeyList[3] && pick == "Branch")
                {
                    System.Console.WriteLine("You reach out to the branch, barely grabbing on. You climb down the tree to safety.  You escaped! Congratulations! Play again? (Y/N)");
                    string again = Console.ReadLine();
                    if (again == "Y")
                    {
                        KeyGen();
                        Basement();
                    }
                    else if (again == "N")
                    {
                        Console.WriteLine("Thanks for playing.");
                    }
                    else
                        System.Console.WriteLine("Please either select 'Y' for Yes or 'N' for no.");
                }
                else if (pick == "Pool")
                {
                    int i = rand.Next(0,2);
                    if(i == 0)
                    {
                        System.Console.WriteLine("Amazing! You take a running jump off the roof and land in the swimming pool! You've escaped! Congratulations! Play again? (Y/N)");
                        string again = Console.ReadLine();
                    if (again == "Y")
                    {
                        KeyGen();
                        Basement();
                    }
                    else if (again == "N")
                    {
                        Console.WriteLine("Thanks for playing.");
                    }
                    else
                        System.Console.WriteLine("Please either select 'Y' for Yes or 'N' for no.");
                    }
                    else if(i == 1)
                    {
                        System.Console.WriteLine("Truly amazing! You choose to jump off the roof, trying to hit the swimming pool! You get pretty close, too. Sadly, you miss. This is the end of your decision tree. Play again? (Y/N)");
                        string again = Console.ReadLine();
                    if (again == "Y")
                    {
                        KeyGen();
                        Basement();
                    }
                    else if (again == "N")
                    {
                        Console.WriteLine("Thanks for playing.");
                    }
                    else
                        System.Console.WriteLine("Please either select 'Y' for Yes or 'N' for no.");
                    }
                }
                else
                {                    
                    System.Console.WriteLine("Oh, no. That didn't work at all. Try something else.");
                    Roof();
                }
            }
        }
    }
} 