namespace Abstract_Factory_Method_Pattern
{
    public class OfficeLaptopProperty : ILaptopProperty
    {
        public ILaptopGraphicCard GetLaptopGraphicCard()
        {
            return new OfficeGraphicCard();
        }

        public ILaptopKeyboard GetLaptopKeyboard()
        {
            return new OfficeKeyboard();
        }
    }
}
