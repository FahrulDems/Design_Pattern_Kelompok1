namespace Design_Pattern_Code
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Laptop laptop1 = buildLaptop("dell");
            Console.WriteLine("laptop.getLaptopName() = " + laptop1.getLaptopName());

            LaptopFactory laptopFactory = new GamingLaptopFactory();         
            Laptop laptop2 = laptopFactory.buildLaptop("asus");
            Console.WriteLine("laptop.getLaptopName() = " + laptop2.getLaptopName());

            LaptopFactory laptopFactory2 = new OfficeLaptopFactory();
            Laptop laptop3 = laptopFactory2.buildLaptop("dell");
            Console.WriteLine("laptop.getLaptopName() = " + laptop3.getLaptopName());

            LaptopFactory laptopFactory3 = new GamingLaptopFactory();
            Laptop laptop4 = laptopFactory3.buildLaptop("dell");
            Console.WriteLine("laptop.getLaptopName() = " + laptop4.getLaptopName());
        }

        public static Laptop buildLaptop(string laptop)
        {
            if (laptop == "asus")
            {
                return new AsusRog();
            }
            if (laptop == "dell")
            {
                return new DellAlienware();
            }
            return null;
        }
    }
}