public class CountedItem
{
    public Item TheItem;
    public int Quantity;

    public CountedItem(Item item, int count)
    {
        this.TheItem = item;
        this.Quantity = count;
    }
}

public class CountedItemList
{
    public List<CountedItem> TheCountedItemList = new List<CountedItem>();

    public CountedItemList()
    {
        this.TheCountedItemList = new List<CountedItem>();
    }

    public void AddItem(Item item)
    {
        if (TheCountedItemList.Any(h => item == h.TheItem))
        {
            TheCountedItemList.First(h => item == h.TheItem).Quantity += 1;
        }
        else
        {
            TheCountedItemList.Add(new CountedItem(item, 1));
        }
    }

    public void AddCountedItem(CountedItem item)
    {
        this.TheCountedItemList.Add(item);
    }
}



public class Item //MC
{
    public int ID;
    public string Name;
    public string NamePlural;
    public Item(int ID, string Name, string NamePlural)
    {
        this.ID = ID;
        this.Name = Name;
        this.NamePlural = NamePlural;
    }
}

public class Weapon //MC
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MinimumDamage;
    public int MaximumDamage;

    public Weapon(int ID, string Name, string NamePlural, int MinimumDamage, int MaximumDamage)
    {
        this.ID = ID;
        this.Name = Name;
        this.NamePlural = NamePlural;
        this.MinimumDamage = MinimumDamage;
        this.MaximumDamage = MaximumDamage;
    }
}

public class Monster //Maria
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MaximumDamage;
    public int MinimumDamage;
    public int MaximumHitPoints;
    public int RewardExperience;
    public int Gold;
    public CountedItemList Loot;
    public int CurrentHitPoints;

    public Monster(int ID, string Name, string NamePlural, int MaximumDamage, int MinimumDamage, int RewardExperience, int Gold, int CurrentHitPoints)
    {
        this.ID = ID;
        this.Name = Name;
        this.NamePlural = NamePlural;
        this.MaximumDamage = MaximumDamage;
        this.MinimumDamage = MinimumDamage;
        this.RewardExperience = RewardExperience;
        this.Gold = Gold;
        this.CurrentHitPoints = CurrentHitPoints;
        this.Loot = new CountedItemList();
    }
}

public class Quest // Jiajun
{
    public int ID;
    public string Name;
    public string Description;
    public int RewardExperiencePoints;
    public int RewardGold;
    public Item RewardItem;
    public Weapon RewardWeapon;
    public CountedItemList QuestCompletionItems;

    public Quest(int ID, string Name, string Description, int RewardExperience, int RewardGold, Item Rewarditem, Weapon RewardWeapon)
    {
        this.ID = ID;
        this.Name = Name;
        this.Description = Description;
        this.RewardExperiencePoints = RewardExperience;
        this.RewardGold = RewardGold;
        this.RewardItem = RewardItem;
        this.RewardWeapon = RewardWeapon;
        this.QuestCompletionItems = new CountedItemList();
    }
}

public class Location //Soufiane
{
    public int ID;
    public string Name;
    public string Description;
    public Item ItemRequiredToEnter;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location LocationToNorth;
    public Location LocationToEast;
    public Location LocationToSouth;
    public Location LocationToWest;

    public Location(int ID, string name, string description, Item ItemRequiredToEnter, Quest QuestAvailableHere, Monster MonsterLivingHere)
    {
        this.ID = ID;
        this.Name = name;
        this.Description = description;
        if (ItemRequiredToEnter != null) this.ItemRequiredToEnter = ItemRequiredToEnter;
        if (QuestAvailableHere != null) this.QuestAvailableHere = QuestAvailableHere;
        if (MonsterLivingHere != null) this.MonsterLivingHere = MonsterLivingHere;

    }
}

public class Player //
{
    public string Name;
    public int CurrentHitPoints;
    public int MaximumHitPoints;
    public int Gold;
    public int ExperiencePoints;
    public int Level;
    public Weapon CurrentWeapon;
    public Location CurrentLocation;
    public CountedItemList Inventory;


    public Player(string Name, int CurrentHitPoints, int MaximumHitPoints, int Gold, int ExperiencePoints, int Level, Weapon CurrentWeapon, Location CurrentLocation)
    {
        this.Name = Name;
        this.CurrentHitPoints = CurrentHitPoints;
        this.MaximumHitPoints = MaximumHitPoints;
        this.Gold = Gold;
        this.ExperiencePoints = ExperiencePoints;
        this.Level = Level;
        this.CurrentWeapon = CurrentWeapon;
        this.CurrentLocation = CurrentLocation;
        this.Inventory = new CountedItemList();

    }
}

public class Rat
{
    int RatID;
    int HP;
    int Damage;
    List<string> PotionList;

    public Rat(int RatID, int HP, int Damage)
    {
        this.RatID = RatID;
        this.HP = HP;
        this.Damage = Damage;
        this.PotionList = new List<string>()
                    {
                        "Snail Potion",
                        "Potion of Shrinking",
                        "Potion of Sun Light"
                    };
    }

    public void Fight()
    {
        if (this.RatID == 1)
        {
            Unenchant("looks insanely big", 1, "shrunk the rat to it's original size");
        }
        else if (this.RatID == 2)
        {
            Unenchant("is insanely quick", 0, "turned to it's originally speed");
        }
        else if (this.RatID == 3)
        {
            Unenchant("is invisible", 2, "turned the rat visible");
        }
        /* Hier moet nog een daadwerkelijk gevecht komen (item 7, 13 en 14 vd product backlog). 
        Dat doe ik in de volgende sprint. Voor nu doe ik iets tijdelijks */

        Console.WriteLine("Press ENTER to kill the rat");
        string killButton = Console.ReadLine()!;
        /* void omzetten in bool en dan:
        bool defeatRat = true;
        return defeatRat;
        */
        RatReward();

    }

    public void Unenchant(string description, int potionIndex, string result)
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
        Console.WriteLine($"Press ENTER to throw the {this.PotionList[1]}");
        string continueButton = Console.ReadLine()!;
        Console.WriteLine($"You have succesfully {result}.");
    }
    public void RatReward()
    {
        Console.WriteLine("You killed a rat and received a rat tail!");
        
    }

}
