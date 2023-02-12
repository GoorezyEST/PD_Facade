namespace Facade_PD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Facade class
            Facade facade = new Facade();
            // Call Operation1 and Operation2 through the Facade instance
            facade.Operation1();
            facade.Operation2();
        }
    }
}