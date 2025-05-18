using System.Security.Principal;

namespace BloomFilter
{
    public class BloomFilter<T>
    {
        bool[] booleans;
        HashSet<Func<T, int>> hashSet;
        public BloomFilter(int cap)
        {
            booleans = new bool[cap];
            hashSet = new HashSet<Func<T, int>>();
            hashSet.Add(HashFuncOne);
            hashSet.Add(HashFuncTwo);
            hashSet.Add(HashFuncThree);
        }

        public void LoadHashFunc(Func<T, int> hashFunc)
        {
            hashSet.Add(hashFunc);
        }

        public void Insert(T item)
        {
            int index = 0;
            foreach(var func in hashSet)
            {
                index = func(item);
            }
            booleans[index] = true;
        }

        public bool ProbablyContains(T item)
        {
            int index = 0;
            foreach (var func in hashSet)
            {
                index = func(item);
            }
            if (booleans[index] == false) return false;
            return true;
        }

        private int HashFuncOne(T item)
        {
            return item.GetHashCode();
        }

        private int HashFuncTwo(T item)
        {
            string dummyString = "dummystring";
            return (dummyString, item).GetHashCode();
        }

        private int HashFuncThree(T item)
        {
            int hash = 17;

            hash *= (HashFuncOne(item), HashFuncTwo(item)).GetHashCode();

            return hash;

        }
    }
}
