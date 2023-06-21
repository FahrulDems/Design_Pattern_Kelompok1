using Abstract_Factory_Method_Pattern;

namespace Design_Pattern_Code
{
    public class AsusVivoBook : AbstractLaptop
    {
        public AsusVivoBook(ILaptopProperty property) : base(property)
        {

        }

        public override string getLaptopName()
        {
            return "Asus Vivobook";
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
