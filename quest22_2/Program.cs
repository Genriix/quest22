namespace quest22_2
{
    public class Program
    {
        public static void Main()
        {
            Console.SetWindowSize(Matrix.Width, Matrix.Height);

            var task = Task.Run(Matrix.Start);

            Console.ReadKey();
        }
    }
}