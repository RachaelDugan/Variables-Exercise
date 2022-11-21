namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string myStreet = "Hollyhock Lane";
            int streetNum = 5263;
            char myUnit = 'Z';
            double yearsOwned = 2.7;
            decimal monthsOwned = 11.29877m;
            bool address = false;
            Console.WriteLine($"This my address {myStreet} {streetNum} {myUnit}: {address}");              
            Console.WriteLine($"The owner has lived here for {yearsOwned} years and {monthsOwned} months");
        }
    }
}
