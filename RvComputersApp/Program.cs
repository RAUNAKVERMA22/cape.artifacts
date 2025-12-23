public class Program
{
    public static void Main()
    {
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Laptop");
        Console.WriteLine("\n\tChoose the option: ");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Desktop d = new Desktop();

            Console.WriteLine("Enter the processor");
            d.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            d.RamSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            d.HardDiskSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            d.GraphicCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the monitor size");
            d.MonitorSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power supply volt");
            d.PowerSupplyVolt = int.Parse(Console.ReadLine());

            Console.WriteLine("Desktop price is ₹" + d.DesktopPriceCalculation());
        }
        else if (choice == 2)
        {
            Laptop l = new Laptop();

            Console.WriteLine("Enter the processor");
            l.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            l.RamSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            l.HardDiskSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            l.GraphicCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the display size");
            l.DisplaySize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the battery volt");
            l.BatteryVolt = int.Parse(Console.ReadLine());

            Console.WriteLine("Laptop price is ₹" + l.LaptopPriceCalculation());
        }
    }
}
