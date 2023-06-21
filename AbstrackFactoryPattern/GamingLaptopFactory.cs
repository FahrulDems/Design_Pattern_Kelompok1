using Abstract_Factory_Method_Pattern;

namespace Design_Pattern_Code
{
    public class GamingLaptopFactory : ILaptopFactory
    {
        public ILaptop buildLaptop(string laptop)
        {
            ILaptopProperty property = new GamingLaptopProperty();
            switch (laptop)
            {
                case "asus":
                    return new AsusRog(property);
                case "dell":
                    return new DellAlienware(property);
                default:
                    return null;
            }
        }
    }
}
