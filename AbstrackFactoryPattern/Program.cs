using Design_Pattern_Code;

namespace Abstract_Factory_Method_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILaptopFactory laptopFactory = new OfficeLaptopFactory();
            ILaptop laptop = laptopFactory.buildLaptop("dell");
            Console.WriteLine($"Laptop Name = {laptop.getLaptopName()}");
            Console.WriteLine($"Graphic Type = {laptop.getGraphicType()}");
            Console.WriteLine($"Keyboard Type = {laptop.getKeyboardType()}");
        }
    }
}