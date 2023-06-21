namespace Abstract_Factory_Method_Pattern
{
    public interface ILaptopProperty
    {
        ILaptopGraphicCard GetLaptopGraphicCard();
        ILaptopKeyboard GetLaptopKeyboard();
    }
}
