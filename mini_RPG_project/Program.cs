
public class Program
{

    public static void Main()
    {
        Random random = new Random();
        Player p1 = new Player("Speler1", 10, 10, 100, 100, 1, World.WeaponByID(1), World.LocationByID(2));
        Town(p1);
    }

    public static void Map(Player p1)
    {
        string mapletter;
        switch (p1.CurrentLocation.ID)
        {
            case 1:
                mapletter = "H";
                break;
            case 2:
                mapletter = "T";
                break;
            case 3:
                mapletter = "G";
                break;
            case 4:
                mapletter = "A";
                break;
            case 5:
                mapletter = "P";
                break;
            case 6:
                mapletter = "F";
                break;
            case 7:
                mapletter = "V";
                break;
            case 8:
                mapletter = "B";
                break;
            case 9:
                mapletter = "S";
                break;
            default:
                mapletter = "X";
                break;
        }
        string map0 = "\n                           P\n                           |\n                           A\n                           |\n                   V - F - T - G - B\n                           |\n                           H\n";
        foreach (char letter in map0)
        {

            if (Convert.ToString(letter) == mapletter)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{letter}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write($"{letter}");
            }
        }
    }

    public static void CompassPrint(Player p1)
    {
        string north = (p1.CurrentLocation.LocationToNorth == null) ? "" : p1.CurrentLocation.LocationToNorth.Name;
        string east = (p1.CurrentLocation.LocationToEast == null) ? "" : p1.CurrentLocation.LocationToEast.Name;
        string south = (p1.CurrentLocation.LocationToSouth == null) ? "" : p1.CurrentLocation.LocationToSouth.Name;
        string west = (p1.CurrentLocation.LocationToWest == null) ? "" : p1.CurrentLocation.LocationToWest.Name;
        int mid = north.Length / 2;
        string c1 = "";
        for (int i = 0; i < 27 - mid; i++)
        {
            c1 = c1 + " ";
        }
        c1 = c1 + north;
        string c2 = "                           ▲";
        string c3 = "                           N";
        string c4 = "                           |";
        string c5 = $"{west}";
        for (int i = 0; i < 19 - west.Length; i++)
        {
            c5 = c5 + " ";
        }

        string c6 = "◄ W ──";
        string c7 = " [Y] ";
        string c8 = "── E ►";
        string c9 = $"   {east}";
        string c10 = c4;
        string c11 = "                           S";
        string c12 = "                           ▼";
        string c13 = "";
        mid = south.Length / 2;
        for (int i = 0; i < 27 - mid; i++)
        {
            c13 = c13 + " ";
        }
        c13 = c13 + south;
        Console.WriteLine($"\n{c1}");
        Console.ForegroundColor = (north == "") ? ConsoleColor.Red : ConsoleColor.Green;
        Console.WriteLine($"{c2}");
        Console.WriteLine($"{c3}");
        Console.WriteLine($"{c4}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{c5}");
        Console.ForegroundColor = (west == "") ? ConsoleColor.Red : ConsoleColor.Green;
        Console.Write($"{c6}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{c7}");
        Console.ForegroundColor = (east == "") ? ConsoleColor.Red : ConsoleColor.Green;
        Console.Write($"{c8}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{c9}\n");
        Console.ForegroundColor = (south == "") ? ConsoleColor.Red : ConsoleColor.Green;
        Console.WriteLine($"{c10}");
        Console.WriteLine($"{c11}");
        Console.WriteLine($"{c12}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{c13}\n");
    }

    public static void StartGame(Player p1)
    { //JiaJun

        Start scherm
        Console.WriteLine("\r\n██████╗░██████╗░░██████╗░  ███╗░░░███╗██╗███╗░░██╗██╗  ░██████╗░░█████╗░███╗░░░███╗███████╗\r\n██╔══██╗██╔══██╗██╔════╝░  ████╗░████║██║████╗░██║██║  ██╔════╝░██╔══██╗████╗░████║██╔════╝\r\n██████╔╝██████╔╝██║░░██╗░  ██╔████╔██║██║██╔██╗██║██║  ██║░░██╗░███████║██╔████╔██║█████╗░░\r\n██╔══██╗██╔═══╝░██║░░╚██╗  ██║╚██╔╝██║██║██║╚████║██║  ██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░\r\n██║░░██║██║░░░░░╚██████╔╝  ██║░╚═╝░██║██║██║░╚███║██║  ╚██████╔╝██║░░██║██║░╚═╝░██║███████╗\r\n╚═╝░░╚═╝╚═╝░░░░░░╚═════╝░  ╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═╝  ░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝");
        Console.WriteLine("\n\nWelcome to the mini game!");
        Console.WriteLine("Press ENTER to start GAME!");
        Thread.Sleep(1000);

        ConsoleKeyInfo keyInfo;
        bool key;

        do
        {
            keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    key = true;
                    Console.Clear();
                    Console.WriteLine("Loading...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Game started!");
                    Thread.Sleep(1000);
                    break;
                default:
                    key = false;
                    Console.WriteLine("\nInvalid input, please choose again.");
                    break;
            }
        } while (!key);

        // Een kleine verhaal met een introductie.
        Thread.Sleep(500);
        Console.Clear();
        Console.Write("Please enter your desired name for the main character: ");
        string name = Console.ReadLine() ?? "Unknown";
        Thread.Sleep(1000);
        Console.WriteLine("\nLoading scenerio...");
        Thread.Sleep(2000);

        p1.Name = name;

        Console.Clear();
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Mom: {p1.Name}, wake up it's morning already!");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{p1.Name}: Just 10 more minutes please!");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nMom: No now, breakfast is already made!");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{p1.Name}: sigh...");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{p1.Name}: Alright give me 3 minutes to change my clothes!");
        Thread.Sleep(2000);
        Console.ResetColor();
        Console.WriteLine("\nChanging clothes...");
        Thread.Sleep(3000);
        Console.WriteLine("Walking down stairs...");
        Thread.Sleep(2000);
        Console.WriteLine("Taking a seat at the table...");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nMom: When will you headout {p1.Name}");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{p1.Name}: eating...");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{p1.Name}: What do you mean headout?");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nMom: don't tell me you forgot already, you accepted three quests from guild remember?");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{p1.Name}: Ooooh shoot, I totally forgot!!");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{p1.Name}: Mom, whats the time right now?!?!");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nMom: It's almost sunrise, you should hurry.");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Mom: And If you are looking for your backpack It's at the front door.");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{p1.Name}: Thanks, mom!");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nMom: Check everything before you head out!");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{p1.Name}: Yeah, I know!");
        Thread.Sleep(2000);

        Console.ResetColor();
        Console.Write($"\npress 1: to check your backpack: ");

        string input;
        bool a;
        do
        {
            input = Console.ReadLine() ?? "Unknown";
            switch (input)
            {
                case "1":
                    a = true;
                    Console.WriteLine($"\nSearching...");
                    Thread.Sleep(3000);
                    Console.WriteLine($"\nItems:");
                    Console.WriteLine("\n- Food, water");
                    Thread.Sleep(1000);
                    Console.WriteLine($"- {p1.CurrentWeapon.Name}");
                    Thread.Sleep(1000);
                    Console.WriteLine("- Golden coins with some silver coins");
                    Thread.Sleep(1000);
                    Console.WriteLine("- A map");
                    Thread.Sleep(1000);
                    Console.WriteLine("- A compass");
                    Thread.Sleep(1000);
                    break;
                default:
                    a = false;
                    Console.WriteLine("Wrong input!");
                    break;
            }
        } while (!a);

        Console.Write("\nPress 2: to equip backpack: ");

        string input1;
        bool b;
        do
        {
            input1 = Console.ReadLine() ?? "Unknown";
            switch (input1)
            {
                case "2":
                    b = true;
                    Console.WriteLine($"\nEquiping...");
                    Thread.Sleep(3000);
                    break;

                default:
                    b = false;
                    Console.WriteLine("\nWrong input!");
                    break;
            }
        } while (!b);

        // Verhaal
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{p1.Name}: Alright mom, Im heading out!");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"\nMom: Be carefull and have a safe trip!");
        Thread.Sleep(2000);

        Console.ResetColor();
        Console.WriteLine("\nOpens door...");
        Thread.Sleep(1000);
        Console.WriteLine("Closes door...");
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n{p1.Name}: I have to hurry before I get to late.");
        Thread.Sleep(2000);

        Console.ResetColor();
        Console.Clear();

        // Menu
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("What would you like to do (Enter a number)?");
        Console.WriteLine("1: << Move location >>");
        Console.WriteLine("2: << Quit >>");
        Console.ResetColor();

        Console.WriteLine($"\nYour current position is: {p1.CurrentLocation.Name}");

        bool c;
        string input2;
        do
        {
            Console.Write("\nChoose your input: ");
            input2 = Console.ReadLine() ?? "Unknown";
            switch (input2)
            {
                case "1":
                    c = true;
                    Console.WriteLine("Which direction would you like to go?");
                    break;

                case "2":
                    c = true;
                    Console.WriteLine("\nQuitting...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;

                default:
                    c = false;
                    Console.WriteLine("Wrong input!");
                    break;
            }
        } while (!c);

        // Ricthing kiezen.
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("What would you like to do (Enter a number)?");
        Console.WriteLine("N: << Move North >>");
        Console.WriteLine("E: << Move East >>");
        Console.WriteLine("S: << Move South >>");
        Console.WriteLine("W: << Move West >>");
        Console.ResetColor();

        CompassPrint(p1);
        Map(p1);

        bool d;
        string input3;
        do
        {
            Console.Write("\nChoose your input: ");
            input3 = Console.ReadLine().ToLower();
            switch (input3)
            {
                case "n":
                    d = true;
                    p1.CurrentLocation = World.LocationByID(2);
                    Console.WriteLine($"Traveling to {p1.CurrentLocation.Name}...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Town(p1);
                    break;

                default:
                    d = false;
                    Console.WriteLine("Can't move to that location or a invalid location!");
                    break;
            }
        } while (!d);

        // Naar het volgende level gaan (Town) ID = 2
    }

    public static void Town(Player p1)
    { //JiaJun

        // Menu
        Console.WriteLine($"You have reached the location: {p1.CurrentLocation.Name}.");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nWhat would you like to do (Enter a number)?");
        Console.WriteLine("1: << Move location >>");
        Console.WriteLine("2: << View Quests >>");
        Console.WriteLine("3: << Quit >>");
        Console.ResetColor();

        string input;
        bool a;
        do
        {
            a = false;
            Console.Write("\nChoose your input: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    a = true;
                    break;

                // Beschrijving van de quest moet nog worden toegevoegd.
                case "2":
                    Console.WriteLine($"\nA: {World.QuestByID(1).Description}");
                    Thread.Sleep(1000);
                    Console.WriteLine($"B: {World.QuestByID(2).Description}");
                    Thread.Sleep(1000);
                    Console.WriteLine($"C: {World.QuestByID(3).Description}");
                    Thread.Sleep(1000);
                    break;

                case "3":
                    Console.WriteLine("\nQuitting...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        } while (!a);

        // Richting kiezen.
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("What would you like to do (Enter a number)?");
        Console.WriteLine("N: << Move North >>");
        Console.WriteLine("E: << Move East >>");
        Console.WriteLine("S: << Move South >>");
        Console.WriteLine("W: << Move West >>");
        Console.ResetColor();

        Map(p1);
        CompassPrint(p1);

        string input1;
        bool b;
        do
        {
            b = false;
            Console.Write("\nChoose your input: ");
            input1 = Console.ReadLine();
            Random random = new Random();
            switch (input1.ToLower())
            {
                case "n":
                    b = true;
                    p1.CurrentLocation = World.LocationByID(4);
                    Console.WriteLine($"Traveling to: {p1.CurrentLocation.Name}...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    // Object passen
                    AlchemistHut(p1);
                    break;

                case "e":
                    b = true;
                    p1.CurrentLocation = World.LocationByID(3);
                    Console.WriteLine($"Traveling to: {p1.CurrentLocation.Name}...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    // Object passen
                    GuardPost(p1, random);
                    break;

                case "s":
                    p1.CurrentLocation = World.LocationByID(1);
                    Console.WriteLine($"Can't go back to: {p1.CurrentLocation.Name}...");
                    Thread.Sleep(3000);
                    break;

                case "w":
                    b = true;
                    p1.CurrentLocation = World.LocationByID(6);
                    Console.WriteLine($"Traveling to: {p1.CurrentLocation.Name}...");
                    Thread.Sleep(3000);
                    Console.Clear();
                    // Object passen
                    Farmhouse(p1, random);

                    break;

                default:
                    Console.WriteLine("Can't move to that location or a invalid location!");
                    break;
            }

        } while (!b);
    }
    public static void AlchemistsGarden(Player p1)
    {
        //Arrival
        Console.WriteLine($"You have arrived at the {p1.CurrentLocation.Name} where the Alchemist leaves his last footprint.");


        //Menu
        string answer = "1";
        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(1) Fight the rats\n(2) Return to the Alchemist Hut\n(3) Quit the Game");
            CompassPrint(p1);
            Map(p1);
            answer = Console.ReadLine()!;
            Console.Clear();
        }
        while (new[] { "1", "2", "3" }.Contains(answer) == false);
        if (answer == "2")
        {
            p1.CurrentLocation = World.LocationByID(4);
            AlchemistHut(p1);
        }
        else if (answer == "3")
        {
            Console.WriteLine("Game Over");
            Environment.Exit(0);
        }
        else if (answer == "1")
        {
            // Start Quest
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You: I accept the quest. Now tell me... where are those innocent little creatures hiding?");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alchemist: About that... there is one thing I forgot to mention. The rats are under influence of my potions. They are out of control!");
            Thread.Sleep(2000);
            Console.WriteLine("Use the potions scattered around the garden to unenchant them before you fight them. Fare thee well, I must away!");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press ENTER to start");
            string startQuestInput = Console.ReadLine()!;
            Console.Clear();

            //Side Quest
            List<string> PotionList = new List<string>()
                    {
                        "Snail Potion",
                        "Potion of Shrinking",
                        "Potion of Sun Light"
                    };
            Thread.Sleep(2000);

            //Main Quest
            var attackList = new List<string> { "The rat jumped on you and bit you.\n", "the rat jumped on you and scratched you.\n" };
            bool fightover = false;
            int i = 1;
            while (fightover == false && i < 4)
            {
                if (i == 1)
                {
                    Unenchant("looks insanely big", 1, "shrunk the rat to it's original size", PotionList);
                }
                else if (i == 2)
                {
                    Unenchant("is insanely quick", 0, "turned to it's originally speed", PotionList);
                }
                else
                {
                    Unenchant("is invisible", 2, "turned the rat visible", PotionList);
                }

                if (Fight(p1, World.MonsterByID(1), attackList) == false)
                {
                    Console.WriteLine("GAME OVER");
                    Environment.Exit(0);
                    fightover = true;
                }
                else
                {
                    p1.Inventory.AddItem(World.ItemByID(1));
                    Console.WriteLine($"You have succesfully killed the rat and received a {World.ItemByID(1).Name}\n{World.ItemByID(1).Name}s: {i}");
                    Thread.Sleep(4000);
                    Console.WriteLine("Do you want to fight again or go back to the Alchemist hut");
                    Console.WriteLine("(1) Go back\n(2) Fight");
                    CompassPrint(p1);
                    Map(p1);
                    string fightagain = Console.ReadLine()!;
                    while (new[] { "1", "2" }.Contains(fightagain) == false)
                    {
                        Console.WriteLine("(1) Go back\n(2) Fight");
                        fightagain = Console.ReadLine()!;
                    }
                    if (fightagain == "1")
                    {
                        fightover = true;
                        Console.WriteLine($"You will go to the Alchemist hut");
                        Thread.Sleep(2000);
                        p1.CurrentLocation = World.LocationByID(4);
                        Console.Clear();
                        AlchemistHut(p1);
                    }
                }
                i++;
            }
            if (p1.CurrentHitPoints <= 0)
            {
                Console.WriteLine($"You have killed all {World.MonsterByID(1).NamePlural} and gained 3 {World.MonsterByID(1).Loot}!");
                Thread.Sleep(2000);

            }

            p1.CurrentLocation = World.LocationByID(4);
            Console.WriteLine("You return back to the alchemist hut.");
            Thread.Sleep(2000);
            AlchemistHut(p1);
            Console.Clear();
        }
    }

    public static void Unenchant(string description, int potionIndex, string result, List<string> PotionList)
    {
        Console.WriteLine($"The rat {description}. What potion do you need?");
        string answer = "1";
        int i = 0;
        foreach (string potion in PotionList)
        {
            i++;
            Console.WriteLine($"({i}) {potion}");
        }
        answer = Console.ReadLine()!;

        while (answer != Convert.ToString(potionIndex + 1))
        {
            if (new[] { "1", "2", "3" }.Contains(answer) == false)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                Console.WriteLine("That is the wrong potion. Try again.");
            }
            i = 0;
            foreach (string potion in PotionList)
            {
                i++;
                Console.WriteLine($"({i}) {potion}");
            }
            answer = Console.ReadLine()!;
        }
        Console.WriteLine($"Press ENTER to throw the {PotionList[1]}");
        string continueButton = Console.ReadLine()!;
        Console.WriteLine($"You have succesfully {result}.");
    }

    public static void AlchemistHut(Player p1)
    { //Marissa


        foreach (CountedItem countedItem in p1.Inventory.TheCountedItemList)
        {
            if (countedItem.TheItem.Name == "Rat tail" && countedItem.Quantity >= 3)
            {
                p1.CurrentLocation = World.LocationByID(2);
                p1.CurrentWeapon = World.WeaponByID(2);
                Console.WriteLine($"You give the alchemist the 3 rat tails and in exchange you receive a {p1.CurrentWeapon.Name}.\nThe {p1.CurrentWeapon.Name} gives a maximum damage of {p1.CurrentWeapon.MaximumDamage}.");
                Thread.Sleep(2000);
                Console.WriteLine($"You head back to the {p1.CurrentLocation.Name}");
                Thread.Sleep(3000);
                Console.Clear();
                List<CountedItem> filteredList = p1.Inventory.TheCountedItemList
                    .Where(item => item.TheItem.Name != "Rat tail")
                    .ToList();
                p1.Inventory.TheCountedItemList = filteredList;
                Town(p1);
            }
            else if (countedItem.TheItem.Name == "Rat tail" && countedItem.Quantity >= 1 && countedItem.Quantity < 3)
            {
                Console.WriteLine("You have not yet obtained enough rat tails or haven't fought the rats in the alchemist's garden at all. Check out the alchemist's garden!");
                Thread.Sleep(2000);
                p1.CurrentLocation = World.LocationByID(5);
                AlchemistsGarden(p1);
                break;
            }
        }
        Console.WriteLine($"You arrived at the {p1.CurrentLocation.Name}.");
        Thread.Sleep(2000);
        Console.WriteLine($"You knock... A mighty alchemist opens the door and asks you to come inside.");
        Thread.Sleep(2000);
        Console.WriteLine($"{p1.CurrentLocation.Description}");
        Thread.Sleep(2000);
        Console.WriteLine($"Once you turn your attention to the alchemist,they ask you for a favor:");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"'Please help! My garden is filled with rats.");
        Thread.Sleep(2000);
        Console.WriteLine("If you are able to kill them all and bring me back 3 rat tails,");
        Console.WriteLine("'I will reward you!'");
        Thread.Sleep(2000);
        bool x = true;
        while (x)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"'This is a line I shall not cross I am afraid.' He says. Will you accept this quest?\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Will you help the alchemist?(Y/N)");
            CompassPrint(p1);
            Map(p1);
            string userInput = Console.ReadLine().ToUpper();
            Console.Clear();

            if (userInput == "N")
            {
                p1.CurrentLocation = World.LocationByID(2);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"'Understandable..they can be quite scary if I say so myself.' nods the alchemist.");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"You leave the alchemist's hut and return to {p1.CurrentLocation.Name}");
                Thread.Sleep(3000);
                Console.Clear();
                x = false;
                Town(p1);
            }
            else if (userInput == "Y")
            {
                p1.CurrentLocation = World.LocationByID(5);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"The Alchemist shows you the way to the {p1.CurrentLocation.Name}.");
                Thread.Sleep(3000);
                Console.Clear();
                x = false;
                AlchemistsGarden(p1);
            }
            else
            {
                continue;
            }
        }

    }

    public static void Farmhouse(Player p1, Random random)
    { //Maria
        bool x = true;
        Console.WriteLine($"You have arrived at the {p1.CurrentLocation.Name}");
        Thread.Sleep(3000);
        Console.Clear();

        // quest gedaan?
        foreach (CountedItem countedItem in p1.Inventory.TheCountedItemList)
        {
            // ja, je hebt het gedaan.
            //Hier nog uit snake fang verwijderen & pass toevoegen
            if (countedItem.TheItem.Name == "Snake fang" && countedItem.Quantity >= 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Hello there Human, Thank you for removing the snakes.");
                Console.WriteLine("As a reward I will give you an Adventure Pass.");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                //  remove snake fangs etc in exchange for the pass
                // Filter the list to exclude the countedItem with the snake fang name
                List<CountedItem> filteredList = p1.Inventory.TheCountedItemList
                    .Where(item => item.TheItem.Name != "Snake fang")
                    .ToList();

                // Assign the filtered list back to the inventory
                p1.Inventory.TheCountedItemList = filteredList;

                // add the pass
                p1.Inventory.AddItem(World.ItemByID(7));

                foreach (CountedItem item in p1.Inventory.TheCountedItemList)
                {
                    Console.WriteLine($"You now have {item.TheItem.Name} x {item.Quantity} in your inventory");
                }

                p1.CurrentLocation = World.LocationByID(2);
                Console.WriteLine($"You have completed this quest, so you're now sent back to {p1.CurrentLocation.Name}");
                Thread.Sleep(3000);
                Console.Clear();
                Town(p1);
            }
            // niet af, wilt de user verder of niet?
            else if (countedItem.TheItem.Name == "Snake fang" && countedItem.Quantity >= 1 && countedItem.Quantity < 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Hello there Human, you're back quick... did you get scared?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You haven't removed all the snakes. So are you gonna kill all the snakes?");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Cyan;

                int backAns = 0;
                while (backAns != 2 && backAns != 1)
                {
                    Console.WriteLine("<1> Yes, I'm going back to your field and kill them snakes\n<2> No, I'm scared. I want to go back to the Town");
                    Console.Write("> ");
                    CompassPrint(p1);
                    Map(p1);
                    backAns = Convert.ToInt32(Console.ReadLine());
                    Thread.Sleep(3000);
                    if (backAns == 1)
                    {
                        // ja user wilt verder
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Make sure you kill all the snakes");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.White;
                        p1.CurrentLocation = World.LocationByID(7);
                        Console.WriteLine($"You'll now be sent back to {p1.CurrentLocation.Name}");
                        Thread.Sleep(3000);
                        FarmersField(p1, random);
                        Console.Clear();
                    }
                    else if (backAns == 2)
                    {
                        // nee user wilt niet verder
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The farmer got dissapointed in you, but let you go back.");
                        Thread.Sleep(2000);
                        p1.CurrentLocation = World.LocationByID(2);
                        Console.WriteLine($"You walked back to {p1.CurrentLocation.Name}");
                        Thread.Sleep(3000);
                        Town(p1);
                        Console.Clear();
                    }
                }
            }
        }

        // begin story als de user de quest helemaal niet heeft gedaan.
        Console.WriteLine($"{p1.CurrentLocation.Description}");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("“Well hello there little human”, says the farmer.");
        Thread.Sleep(2000);
        Console.WriteLine("I can't work mine own landeth with those pesky snakes slith'ring 'round! Shall thee holp me?”");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("<1> Yes, I'm gonna help the farmer\n<2> No. I'm not your slave...\n<3> I need to heal myself first");
        CompassPrint(p1);
        Map(p1);

        Console.Write("> ");
        int answer = Convert.ToInt32(Console.ReadLine());

        while (x)
        {
            if (answer == 1)
            {
                Console.Clear();
                p1.CurrentLocation = World.LocationByID(7);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("“Goodluck with that little human, try not to cry.” says the farmer.");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"You will now enter the {p1.CurrentLocation.Name}");
                Thread.Sleep(3000);
                Console.Clear();
                x = false;
                FarmersField(p1, random);
            }
            else if (answer == 2)
            {
                Console.Clear();
                p1.CurrentLocation = World.LocationByID(2);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("I knew you wouldn't do it... if you won't help me just go back from where you came");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"The farmer kicked you out of his farm so you have arrived back at {p1.CurrentLocation.Name}");
                Thread.Sleep(3000);
                Console.Clear();
                x = false;
                Town(p1);
            }
            // healing part
            else if (answer == 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The farmer will offer you some bread in exchange for you to get rid of the snakes");
                Thread.Sleep(2000);
                Console.WriteLine("Will you take up this offer? (Y/N)");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("> ");
                string offerAns = Console.ReadLine().ToLower();
                if (offerAns == "yes" || offerAns == "y")
                {
                    p1.CurrentLocation = World.LocationByID(7);
                    if (p1.CurrentHitPoints == p1.MaximumHitPoints)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You are max energized, you don't need the bread");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Here's some bread to give you the energy");
                        p1.CurrentHitPoints = (p1.CurrentHitPoints + 4);
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"You got +4 health\nYou now have {p1.CurrentHitPoints} health");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("“Goodluck with the battle little human, try not to cry.” says the farmer.");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"You will now enter the {p1.CurrentLocation.Name}");
                    Thread.Sleep(3000);
                    Console.Clear();
                    x = false;
                    FarmersField(p1, random);
                }
                else if (offerAns == "no" || offerAns == "n")
                {
                    p1.CurrentLocation = World.LocationByID(2);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("I knew you wouldn't do it... if you won't help me just go back from where you came");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"The farmer kicked you out of his farm so you have arrived back at {p1.CurrentLocation.Name}");
                    Thread.Sleep(3000);
                    Console.Clear();
                    x = false;
                    Town(p1);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("The farmer is a little deaf, please type <yes> or <no>");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Didn't catch that\n Will you help the farmer?\ntype <yes> or <no>");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("> ");
                answer = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    public static void FarmersField(Player p1, Random random)
    { //Marie-Claire
        var attackList = new List<string> { "The snake suddenly sinks it's fangs into your flesh.\n", "The snake goes for your arm and squezes it tightly.\n" };
        Console.WriteLine($"You have arrived at the {p1.CurrentLocation.Name}.\nThere are a lot of snakes around you...");
        int ans = 0;
        bool x = true;
        while (x == true)
        {
            while (ans != 1 && ans != 2 && ans != 3)
            {
                Console.WriteLine("What do you want to do?\n(1) Kill snake, \n(2) Move back, \n(3) quit game");
                CompassPrint(p1);
                Map(p1);
                ans = Convert.ToInt32(Console.ReadLine());
            }
            if (ans == 1)
            {
                int rand = random.Next(1, 3);
                if (rand == 1)
                {

                    if (Fight(p1, World.MonsterByID(2), attackList))
                    {
                        Console.WriteLine("You killed a snake and recieved a Snake Fang!");
                        p1.Inventory.AddItem(World.ItemByID(3));
                    }

                }
                else
                {
                    if (Fight(p1, World.MonsterByID(2), attackList))
                    {
                        Console.WriteLine("You killed a snake and recieved Snake Skin!");
                        p1.Inventory.AddItem(World.ItemByID(4));
                    }

                }
                ans = 0;
            }
            else if (ans == 2)
            {
                x = false;
                foreach (CountedItem item in p1.Inventory.TheCountedItemList)
                {
                    Console.WriteLine($"{item.TheItem.Name} {item.Quantity}");
                }

                Console.WriteLine("You went back to the farmer.");
                p1.CurrentLocation = World.LocationByID(6);
                Farmhouse(p1, random);
            }
            else
            {
                Console.WriteLine("Game Over");
                Environment.Exit(0);
                x = false;
            }
        }

    }

    public static void SpiderForest(Player p1, Random random)
    {
        Console.WriteLine($"You have arrived at the {p1.CurrentLocation.Name}");
        Thread.Sleep(2000);
        Console.WriteLine($"{p1.CurrentLocation.Description}");
        Thread.Sleep(2000);
        string ans = "";
        while (ans != "y" && ans != "n")
        {
            Console.WriteLine("Are you ready to start the quest? (y/n)");
            CompassPrint(p1);
            Map(p1);
            ans = Console.ReadLine().ToLower();
            Console.Clear();
        }
        if (ans == "y")
        {
            bool quest = true;
            int spider = 1;
            while (quest)
            {
                if (spider == 1)
                {
                    Console.WriteLine("You've only taken 3 steps into the forest when you see a big fat black spider coming down...");
                }
                else if (spider == 2)
                {
                    Console.WriteLine("When you continue the path, you hear something behind you.\nWhen you look behind you see a brown hairy spider coming your way...");
                }
                else if (spider == 3)
                {
                    Console.WriteLine("You can see the end of the forest!\nWhen you're walking to the end, you see the biggest spider you have ever seen.\nThis spider is the boss of the forest!");
                }

                int ans2 = 0;

                while (ans2 != 1 && ans2 != 2 && ans2 != 3)
                {
                    Console.WriteLine("What do you want to do?\n(1) Fight\n(2) Run away\n(3) Quit game");
                    CompassPrint(p1);
                    Map(p1);
                    ans2 = Convert.ToInt32(Console.ReadLine());
                }

                if (ans2 == 1) //Fight
                {
                    //output van attacklist moet aangepast worden
                    var attackList = new List<string> { "The spider smashed you with his legs\n", "The spider catched you with his spiderweb!\n", "The spider spit on you!\n" };
                    if (Fight(p1, World.MonsterByID(3), attackList))
                    {
                        if (spider == 3)
                        {
                            p1.Inventory.AddItem(World.ItemByID(6));
                            p1.Inventory.AddItem(World.ItemByID(6));
                            Console.WriteLine($"You've killed the boss! good job.\nYou've recieved 2 {World.ItemByID(6).Name}'s\n");
                        }
                        else
                        {
                            p1.Inventory.AddItem(World.ItemByID(6));
                            Console.WriteLine($"You've killed the spider! good job.\nYou've recieved a {World.ItemByID(6).Name}\n");
                        }
                        spider++;
                    }
                    else
                    {
                        Console.WriteLine("Sadly you died fighting the spider... \nGAME OVER");
                        quest = false;
                    }
                }

                else if (ans2 == 2) //Run away
                {
                    int x = random.Next(1, 11);
                    if (x <= 3)
                    {
                        Console.WriteLine("Somehow, you managed to get away!");
                        spider++;
                    }
                    else if (x <= 9)
                    {
                        Console.WriteLine("Did you really think this would work? \nThe spider followed you, so you still need to fight him...\n");
                        var attackList = new List<string> { "The snake suddenly sinks it's fangs into your flesh", "The snake goes for your arm and squezes it tightly" };
                        if (Fight(p1, World.MonsterByID(3), attackList))
                        {
                            if (spider == 3)
                            {
                                p1.Inventory.AddItem(World.ItemByID(6));
                                p1.Inventory.AddItem(World.ItemByID(6));
                                Console.WriteLine($"You've killed the boss! good job.\nYou've recieved 2 {World.ItemByID(6).Name}'s\n");
                            }
                            else
                            {
                                p1.Inventory.AddItem(World.ItemByID(6));
                                Console.WriteLine($"You've killed the spider! good job.\nYou've recieved a {World.ItemByID(6).Name}\n");
                            }
                            spider++;

                        }
                        else
                        {
                            Console.WriteLine("Sadly you died fighting the spider... \nGAME OVER");
                            quest = false;
                        }
                    }
                    else
                    {
                        p1.CurrentHitPoints = 0;
                        Console.WriteLine("You ran into a bunch of other spiders.\nSadly you couldn't kill them all and died.\nGAME OVER");
                        quest = false;
                    }
                }

                else  //Quit game
                {
                    Console.WriteLine("GAME OVER");
                    Environment.Exit(0);
                    quest = false;
                }

                if (spider == 4) //Einde van de quest
                {
                    Console.WriteLine("You have finished the quest!");
                    Thread.Sleep(2000);
                    quest = false;
                    Console.WriteLine("You went over the bridge and passed the guard.");
                    Thread.Sleep(2000);
                    p1.CurrentLocation = (World.LocationByID(2));
                    Console.Clear();
                    WinGame(p1, random);
                }
            }
        }
        else if (ans == "n")
        {
            p1.CurrentLocation = World.LocationByID(8);
            Console.WriteLine($"You are such a failure...\nYou go back to the {p1.CurrentLocation.Name}");
        }
    }

    public static void GuardPost(Player p1, Random random)
    {//Marissa
        p1.CurrentLocation = World.LocationByID(3);
        Console.WriteLine($"From town square you head towards the {p1.CurrentLocation.Name}.");
        Thread.Sleep(2000);
        Console.WriteLine("Before you stands a tough-looking guard in front of a large gate leading outside into a forest.");
        Thread.Sleep(2000);
        Console.WriteLine($"As you walk up towards the guard he stops you by blocking your way.");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("'No one shall pass without a good reason. There are spiders invading this forest... It is not safe' says the guard man.");
        Thread.Sleep(3000);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"<1> Show the guard your adventurer pass.\n<2> Try and sneak past the guard.\n<3> Head back to town square.");
        CompassPrint(p1);
        Map(p1);
        CompassPrint(p1);
        Map(p1);
        int answer = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        bool x = true;

        while (x)
        {
            if (answer == 1)
            {
                foreach (CountedItem countedItem in p1.Inventory.TheCountedItemList)
                {
                    if (countedItem.TheItem.Name == "Adventurer pass" && countedItem.Quantity >= 1)
                    {
                        p1.CurrentLocation = World.LocationByID(8);
                        Console.WriteLine($"You grab your adventurer pass that you received back at the town square.");
                        Thread.Sleep(2000);
                        Console.WriteLine("The guard grabs you pass and looks at you in surprise.");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("'Are you here to kill the spiders within our forest?'");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"You nod reasurring. The guard looks up and from the top of his lungs he screams ");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("'Open up the bloody gate!'");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The rusty gate opens up and the guard steps aside.");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("'Good luck out there young one'.");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"You step through the gate and head towards the {p1.CurrentLocation.Name}");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Bridge(p1, random);
                        break;
                    }
                }
                p1.CurrentLocation = World.LocationByID(2);
                Console.WriteLine($"You do not have an adventurer's pass yet.\nThe guard is not pleased with your lie and sends you back to {p1.CurrentLocation.Name}.");
                Town(p1);
            }
            else if (answer == 2)
            {
                p1.CurrentLocation = World.LocationByID(2);
                Console.WriteLine($"You turn around and pretend to head back to town square. Once you pass some bushes, you jump in quickly!");
                Thread.Sleep(2000);
                Console.WriteLine("On hands and knees you crawl past the bushes back towards the gate.");
                Thread.Sleep(2000);
                Console.WriteLine($"Suddenly the bushes in front of you move. You hold your breath and wait...");
                Thread.Sleep(2000);
                Console.WriteLine($"Out jumps the biggest and fatest squirrel you have ever seen. You scream, which blows your cover. What a bummer...");
                Thread.Sleep(2000);
                Console.WriteLine($"You head back to {p1.CurrentLocation.Name}");
                Thread.Sleep(3000);
                Console.Clear();
                Town(p1);
                x = false;
            }
            else if (answer == 3)
            {
                p1.CurrentLocation = World.LocationByID(2);
                Console.WriteLine($"You decide to head back to {p1.CurrentLocation.Name}");
                Thread.Sleep(3000);
                Console.Clear();
                Town(p1);
                x = false;
            }
            else
            {
                Console.WriteLine("Invalid input.");
                Console.WriteLine($"<1> Show the guard your adventurer pass.\n<2> Try and sneak past the guard.\n<3> Head back to town square.");
                answer = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
    }

    public static void Bridge(Player p1, Random random)
    {// Marissa
        //p1.CurrentLocation = World.LocationByID(8);
        if (p1.CurrentLocation.ID == 8)
        {
            Console.WriteLine($"You walk over the large stone bridge that connects the town and forest seperated by a broad river.");
            Thread.Sleep(2000);
            Console.WriteLine("Far ahead you see the dark and omnimous forest. You swipe away a droplet of sweat from your forhead and increase your walking speed.");
            Thread.Sleep(2000);
            Console.WriteLine($"Once you finished the long walk over the bridge you stand in front of large trees blocking your from looking inside the forest.");
            Thread.Sleep(3000);

            bool x = true;

            while (x)
            {
                Console.WriteLine($"Do you:\n<1> Head back to the guards post.\n<2> Head into the forest.\n<3> Want to heal first");
                CompassPrint(p1);
                Map(p1);
                int answer = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (answer == 1)
                {
                    p1.CurrentLocation = World.LocationByID(2);
                    Console.WriteLine($"You reconsider your decision while staring into the forest.");
                    Thread.Sleep(2000);
                    Console.WriteLine($"You don't take the risk and head back to {p1.CurrentLocation.Name}");
                    Thread.Sleep(3000);
                    Town(p1);
                    Console.Clear();
                    x = false;
                }
                else if (answer == 2)
                {
                    p1.CurrentLocation = World.LocationByID(9);
                    Console.WriteLine($"You cautiously make your way through the dense {p1.CurrentLocation.Name}");
                    Thread.Sleep(2000);
                    Console.WriteLine("Looking up you see spider webs covering the upper part of the forest. You take a last deep breath before continueing your walk.");
                    Thread.Sleep(3000);
                    x = false;
                    SpiderForest(p1, random);
                    Console.Clear();
                }
                else if (answer == 3)
                {
                    Console.WriteLine("You found some berries and ate them\nYou are fully healed now");
                    Thread.Sleep(2000);
                    p1.CurrentHitPoints = p1.MaximumHitPoints;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.WriteLine($"Do you:\n<1> Head back to the guards gate.\n<2> Head into the forest.");
                    answer = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }
            }
        }
    }

    public static void WinGame(Player p1, Random random)
    {
        p1.CurrentLocation = World.LocationByID(2);
        Console.WriteLine($"You returned to {p1.CurrentLocation.Name}.");
        Thread.Sleep(2000);
        Console.WriteLine("The square is filled with people. In the large crowd you see both the farmer and the alchemist.");
        Thread.Sleep(2000);
        Console.WriteLine($"You walk up to them and a man standing next to the 2 opens up his arms.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("'almighty adventurer, I heard you took it upon you to kill the spiders terrorising the forest. As the major of this town I am pleased'");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"'Did you manage to kill the spiders?\n<1> Yes I did (show the spider silk).\n<2> No, I did not manage to kill those pesky spiders.");
        int answer = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        bool x = true;

        while (x)
        {
            if (answer == 1)
            {
                foreach (CountedItem countedItem in p1.Inventory.TheCountedItemList)
                {
                    if (countedItem.TheItem.Name == "Spider silk" && countedItem.Quantity >= 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"'Amazing!' The major claps in his hands and the whole crowd surrounding you quits down.");
                        Thread.Sleep(2000);
                        Console.WriteLine("'Everyone, this amazing adventurer saved us all and cleared the forest of spiders'");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"The whole crowd starts celebrating your victory.\nYou saved your town and helped the people in need!");
                        Thread.Sleep(2000);
                        Console.WriteLine($"YOU WIN");
                        Environment.Exit(0);
                        x = false;
                    }
                }
                Console.WriteLine("You don't have enough spider silks yet");
                bool z = true;
                while (z)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Head back to the spider forest?\n<1> Yes\n<2> No");
                    int tryAgain = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (tryAgain == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        p1.CurrentLocation = World.LocationByID(9);
                        Console.WriteLine($"You head back to the {p1.CurrentLocation.Name}. You are not scared of those spiders! Go get them.");
                        Console.Clear();
                        SpiderForest(p1, random);
                        z = false;
                    }
                    else if (tryAgain == 2)
                    {
                        Town(p1);
                        z = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
            }

            else if (answer == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"'Too bad...I hope you will try again mighty adventurer' The major nods.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(3000);
                Console.Clear();
                bool y = true;

                while (y)
                {
                    Console.WriteLine("Head back to the spider forest?\n<1> Yes\n<2> No");
                    int tryAgain = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (tryAgain == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        p1.CurrentLocation = World.LocationByID(9);
                        Console.WriteLine($"You head back to the {p1.CurrentLocation.Name}. You are not scared of those spiders! Go get them.");
                        Console.Clear();
                        SpiderForest(p1, random);
                        y = false;
                    }
                    else if (tryAgain == 2)
                    {
                        Town(p1);
                        y = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                break;
            }
        }
    }


    public static bool Fight(Player player, Monster monster, List<string> attackList)
    {
        Console.WriteLine("The fight will begin");
        Thread.Sleep(1000);
        int maximumHitPoints = monster.CurrentHitPoints;
        var rand = new Random();
        bool playerTurn = true;
        bool monsterTurn = false;
        bool fightover = false;
        bool victory = false;
        PrintHealth(player, monster, maximumHitPoints);
        while (fightover == false)
        {
            while (playerTurn == true)
            {
                //Player attack
                Console.WriteLine($"Press ENTER to attack the {monster.Name}");
                string attackButton = Console.ReadLine()!;
                int damage = rand.Next(player.CurrentWeapon.MinimumDamage, player.CurrentWeapon.MaximumDamage + 1);
                monster.CurrentHitPoints = monster.CurrentHitPoints - damage;
                Console.WriteLine($"You caused {damage} damage to the {monster.Name}.");
                Thread.Sleep(1000);
                PrintHealth(player, monster, maximumHitPoints);
                playerTurn = false;
                monsterTurn = (monster.CurrentHitPoints > 0) ? true : false;
            }
            while (monsterTurn == true)
            {
                //Monster attack
                Console.WriteLine($"It is the {monster.Name}'s turn. Press ENTER");
                string attackButton = Console.ReadLine()!;
                Thread.Sleep(1000);
                int damage = rand.Next(monster.MinimumDamage, monster.MaximumDamage + 1);
                player.CurrentHitPoints = player.CurrentHitPoints - damage;
                int index = rand.Next(attackList.Count);
                Console.Write($"{attackList[index]}");
                Console.WriteLine($"The {monster.Name} did {damage} damage to you.");
                PrintHealth(player, monster, maximumHitPoints);
                monsterTurn = false;
                playerTurn = (player.CurrentHitPoints > 0) ? true : false;
            }
            if (monster.CurrentHitPoints <= 0 || player.CurrentHitPoints <= 0)
            {
                fightover = true;
                Thread.Sleep(1000);

            }
        }
        if (monster.CurrentHitPoints <= 0)
        {
            monster.CurrentHitPoints = maximumHitPoints;
            victory = true;
        }
        else
        {
            victory = false;
            Console.WriteLine("GAME OVER!");
            Environment.Exit(0);
        }
        return victory;

    }

    public static void PrintHealth(Player player, Monster monster, int maxHp)
    {
        // Print Monster Health
        Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=");
        string name = "";
        int l = 0;
        foreach (char letter in monster.Name)
        {
            if (l == 0)
            {
                name = name + Convert.ToString(letter).ToUpper();
            }
            else
            {
                name = name + letter;
            }
            l++;
        }
        Console.Write($"{name}: ");
        for (int i = 1; i <= maxHp; i++)
        {
            if (i <= monster.CurrentHitPoints)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("♥");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.Write("\n");
        // Print Player Health
        name = "";
        l = 0;
        foreach (char letter in player.Name)
        {
            if (l == 0)
            {
                name = name + Convert.ToString(letter).ToUpper();
            }
            else
            {
                name = name + letter;
            }
            l++;
        }
        Console.Write($"{name}: ");
        for (int i = 1; i <= player.MaximumHitPoints; i++)
        {
            if (i <= player.CurrentHitPoints)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("♥");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.Write("\n");
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=\n");

    }
}

