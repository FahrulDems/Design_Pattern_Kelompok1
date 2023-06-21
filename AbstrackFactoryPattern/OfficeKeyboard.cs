namespace Abstract_Factory_Method_Pattern
{
    public class OfficeKeyboard : ILaptopKeyboard
    {
        public string GetKeyboard()
        {
            return "Standard";
        }
    }
}
