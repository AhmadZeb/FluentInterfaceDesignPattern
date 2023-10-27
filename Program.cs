using FluentInterfaceDesignPattern.FluentEmp;

namespace FluentInterfaceDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The Fluent Interface Design Pattern’s main objective is to apply
            //multiple properties (or methods) to an object by connecting
            //them with dots (.) without re-specifying the object name each time

            //Create an Instance of Wrapper class i.e. FluentEmployee
            FluentEmployee obj = new FluentEmployee();
                //Call Methods one by one using dot Operator whose Return Type is FluentEmployee
                obj.NameOfTheEmployee("Ahmad Zeb")
                        .Born("10/10/1992")
                        .WorkingOn("IT")
                        .StaysAt("Mardan");
                //To See the Details call the ShowDetails Method
                obj.ShowDetails();
                Console.Read();
            
        }
    }
}