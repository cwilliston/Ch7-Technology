namespace Ch7_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer testComputer = new Computer(true, 32, 4);
            Console.WriteLine(testComputer.Id);
            Computer testComputer2 = new Computer(true, 16, 5);
            Console.WriteLine(testComputer2.Id);
        }
    }
}