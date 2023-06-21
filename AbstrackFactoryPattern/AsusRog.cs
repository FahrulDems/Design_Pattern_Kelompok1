using Abstract_Factory_Method_Pattern;

namespace Design_Pattern_Code
{
    public class AsusRog : AbstractLaptop
    {
        public AsusRog(ILaptopProperty property) : base(property)
        {

        }

        public override string getLaptopName()
        {
            return "Asus ROG Zephyrus";
        }

        public override string getKeyboardType()
        {
            return property.GetLaptopKeyboard().GetKeyboard();
        }

        public override string getGraphicType()
        {
            return property.GetLaptopGraphicCard().GetGraphic();
        }
    }
}
