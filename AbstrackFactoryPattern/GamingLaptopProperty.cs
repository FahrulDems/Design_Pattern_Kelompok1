namespace Abstract_Factory_Method_Pattern
{
    public class GamingLaptopProperty : ILaptopProperty
    {
        public ILaptopGraphicCard GetLaptopGraphicCard()
        {
            return new GamingGraphicCard();
        }

        public ILaptopKeyboard GetLaptopKeyboard()
        {
            return new GamingKeyboard();
        }
    }
}
