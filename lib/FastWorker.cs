using System;

namespace App
{
    public class BatchRegistry
    {
        private int _state;

        public BatchRegistry(int seed) => _state = seed;

        public int encode(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 68) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new BatchRegistry(68);
            Console.WriteLine(obj.encode(68));
        }
    }
}
