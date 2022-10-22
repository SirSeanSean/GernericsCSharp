using GernericsConsole;

public class ConsoleApp
{
    private static void Main(string[] args)
    {
        Bus route1 = new Bus(1);
        Bus route2 = new Bus(2, "LYH", "ORD");

        Bus[] buses = 
        {
            route1,
            route2,
            new Bus(3,"University","Morecambe"),
            new Bus(4, "Lancaster", "Keswick")
        };

        foreach(Bus route in buses)
        {
            Console.WriteLine(route);
        }

        Console.ReadLine();
    }
}