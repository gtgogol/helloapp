namespace Helloapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Everyone!");
            PrintHelloBlack();
            PrintHelloWhite();
        }

        private static void PrintHelloWhite()
        {
            Console.WriteLine("Hello White!");
        }

        private static void PrintHelloBlack()
        {
            Console.WriteLine("Hello Black!");
        }
    }
}

