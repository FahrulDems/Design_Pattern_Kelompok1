namespace Design_Pattern_Code
{
    internal class OfficeLaptopFactory : LaptopFactory
    {
        public Laptop buildLaptop(String laptop)
        {
            switch (laptop)
            {
                case "asus":
                    return new AsusVivoBook();
                case "dell":
                    return new DellLatitude();
                default:
                    return null;
            }
        }
    }
}
