using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace TODO.Benchmarks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchy>();
        }
    }
    
    [MemoryDiagnoser(false)]
    public class Benchy
    {
        [Benchmark]
        public void TestBenchmark()
        {
            Add(1, 2);
        }
        
        private static int Add(int a, int b)
        {
            return a + b;
        }
    }
}