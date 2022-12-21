namespace OopsConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            string name =car.Engine("Tushar");
            int result = car.Engine(9);
            Console.WriteLine(name);
            Console.WriteLine(result);

        }
    }
}