namespace BloomFilter
{
    public class BloomFilter<T>
    {
        bool[] booleans;
        public BloomFilter(int cap)
        {

        }

        public void LoadHashFunc(Func<T, int> hashFunc)
        {

        }

        public void Insert(T item)
        {

        }

        public bool ProbablyContains(T item)
        {
            return false;
        }

        private int HashFuncOne(T item)
        {
            return 0;
        }

        private int HashFuncTwo(T item)
        {
            return 0;
        }

        private int HashFuncThree(T item)
        {
            return 0;
        }
    }
}
