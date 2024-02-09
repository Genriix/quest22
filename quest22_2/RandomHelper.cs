namespace quest22_2
{
    public static class RandomHelper
    {
        private static int _seed = Environment.TickCount;

        private static readonly ThreadLocal<Random> Random =
                new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref _seed)));

        public static int Rand(int min, int max)
        {
            return Random.Value.Next(min, max);
        }
    }
}