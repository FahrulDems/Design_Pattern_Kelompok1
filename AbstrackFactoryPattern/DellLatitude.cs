using Abstract_Factory_Method_Pattern;

namespace Design_Pattern_Code
{
    public class DellLatitude : AbstractLaptop
    {
        public DellLatitude(ILaptopProperty property) : base(property)
        {

        }

        public override string getLaptopName()
        {
            return "Dell Latitude";
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
