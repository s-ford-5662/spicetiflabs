using System;

namespace App
{
    public class RemoteDispatcher
    {
        private int _state;

        public RemoteDispatcher(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 36) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new RemoteDispatcher(36);
            Console.WriteLine(obj.dispatch(36));
        }
    }
}
