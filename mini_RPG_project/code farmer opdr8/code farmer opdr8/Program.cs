using System;

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
    else if (countedItem.TheItem.Name == "Snake fang" && countedItem.Quantity < 3)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Hello there Human, you're back quick... did you get scared?");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("You haven't removed all the snakes. So are you gonna kill all the snakes?");
        Thread.Sleep(2000);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("<1> Yes, I'm going back to your field and kill them snakes\n<2> No, I'm scared. I'm wan't to go back to the Town");
        Console.Write("> ");
        int backAns = Convert.ToInt32(Console.ReadLine());
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
        else
        {
            // verkeerde input
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Didn't catch that, pleas type: <1> or <2>");
            Console.Write("> ");
            backAns = Convert.ToInt32(Console.ReadLine());
            if (backAns == 2)
            {
                Console.WriteLine("The farmer got dissapointed in you, but let you go back.");
                Thread.Sleep(2000);
                p1.CurrentLocation = World.LocationByID(2);
                Console.WriteLine($"You walked back to {p1.CurrentLocation.Name}");
                Thread.Sleep(3000);
                Town(p1);
                Console.Clear();
            }
            else
            {
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
                Console.WriteLine($"You have {p1.CurrentHitPoints} energy");
                Thread.Sleep(2000);
                Console.WriteLine("You are max energized, you don't need the bread");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Here's some bread to give you the energy");
                p1.CurrentHitPoints = (p1.CurrentHitPoints + 2);
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"You now have {p1.CurrentHitPoints} energy");
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