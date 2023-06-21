using Abstract_Factory_Method_Pattern;

namespace Design_Pattern_Code
{
    public class DellAlienware : AbstractLaptop
    {
        public DellAlienware(ILaptopProperty property) : base(property)
        {

        }

        public override string getLaptopName()
        {
            return "Dell Alienware";
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
