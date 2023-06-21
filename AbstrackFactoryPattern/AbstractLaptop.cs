using Design_Pattern_Code;

namespace Abstract_Factory_Method_Pattern
{
    public abstract class AbstractLaptop : ILaptop
    {
        protected ILaptopProperty property;

        protected AbstractLaptop(ILaptopProperty property)
        {
            this.property = property;
        }

        public abstract string getLaptopName();
        public abstract string getKeyboardType();
        public abstract string getGraphicType();

    }
}
