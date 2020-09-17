using System;

namespace DataStructures
{
    class List
    {
        int[] backingStore = new int[0];
        public int Length { get; private set; } = 0;
        public void InsertAtEnd(int newValue)
        {
            throw new NotImplementedException();
        }

        public void InsertAt(int newValue, int index)
        {
            throw new NotImplementedException();
        }

        public int GetValueAtIndex(int index)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
