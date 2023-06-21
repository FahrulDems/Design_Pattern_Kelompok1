namespace Design_Pattern_Code
{
    internal class GamingLaptopFactory : LaptopFactory
    {
        public Laptop buildLaptop(String laptop)
        {
            switch (laptop)
            {
                case "asus":
                    return new AsusRog();
                case "dell":
                    return new DellAlienware();
                default:
                    return null;
            }
        }
    }
}
