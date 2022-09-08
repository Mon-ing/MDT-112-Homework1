public class Program
{
    public static void Main(string[] args)
    {
        Shop myMoney = new Shop();
        Console.WriteLine("Please input NameMarket :");
        myMoney.NameMarket = Console.ReadLine();
        Console.WriteLine("Please input Number : ");
        myMoney.Number = Console.ReadLine();
        Console.WriteLine("Please input Name : ");
        myMoney.Name = Console.ReadLine();
        Console.WriteLine("Please input OwnerName : ");
        myMoney.OwnerName = Console.ReadLine();
        PrintInformationInput(myMoney);
        Console.WriteLine("Please input money : ");

        Money MMoney = new Money();
        MMoney.baChange();

    }

    public class Shop
    {
        public string NameMarket;
        public string Number;
        public string Name;
        public string OwnerName;
    }

    static void PrintInformationInput(Shop Information)
    {
        Console.WriteLine("-------- Shop Information --------");
        Console.WriteLine("Shop NameMarket : {0}",Information.NameMarket);
        Console.WriteLine("Number : {0}", Information.Number);
        Console.WriteLine("Name : {0}",Information.Name);
        Console.WriteLine("Owner Name : {0}",Information.OwnerName);
        Console.WriteLine("----------------------------------");
    } 
}

