namespace AdventOfCode2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDay d = new Day6();

            Console.WriteLine(d.Run(false));
        }
    }
}
