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
            double myGPA = 2.7;
            decimal myIQ = 85.29877m;
            bool notMyAddress = false;
            Console.WriteLine($"The address entered was: {myStreet} {streetNum} {myUnit}");              
            Console.WriteLine(notMyAddress);
            Console.WriteLine($"My GPA and IQ are: {myGPA} {myIQ}");
        }
    }
}
