using System;

namespace App
{
    public class FastManager
    {
        private int _state;

        public FastManager(int seed) => _state = seed;

        public int flush(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 77) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new FastManager(77);
            Console.WriteLine(obj.flush(77));
        }
    }
}
