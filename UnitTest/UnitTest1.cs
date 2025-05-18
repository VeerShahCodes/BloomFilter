using BloomFilter;
namespace UnitTest
{
    
    public class UnitTest1
    {

        [Fact]
        public void ProbablyContainsTest()
        {
            BloomFilter<int> blomFilter = new BloomFilter<int>(10);
            blomFilter.Insert(10);
            blomFilter.Insert(5);
            blomFilter.Insert(1);
            blomFilter.Insert(3);
            blomFilter.Insert(4);
            Assert.True(blomFilter.ProbablyContains(10));
            Assert.True(blomFilter.ProbablyContains(3));
            Assert.False(blomFilter.ProbablyContains(2));
        }

        [Fact]
        public void LoadFuncTest()
        {
            BloomFilter<int> blomFilter = new BloomFilter<int>(10);
            blomFilter.hashSet.Clear();

            blomFilter.LoadHashFunc((x) => x);
            blomFilter.Insert(4);
            Assert.True(blomFilter.ProbablyContains(14));
        }

        
    }
}