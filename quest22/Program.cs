namespace quest22_1
{
    class Program
    {
        static void Go(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new(Go);
            t.Name = "Thread " + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }
        private static void Main()
        {
            Go(10);
            Console.ReadKey();
        }
    }
}