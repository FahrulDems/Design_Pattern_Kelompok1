using Abstract_Factory_Method_Pattern;

namespace Design_Pattern_Code
{
    public class OfficeLaptopFactory : ILaptopFactory
    {
        public ILaptop buildLaptop(string laptop)
        {
            ILaptopProperty property = new OfficeLaptopProperty();
            switch (laptop)
            {
                case "asus":
                    return new AsusVivoBook(property);
                case "dell":
                    return new DellLatitude(property);
                default:
                    return null;
            }
        }
    }
}
