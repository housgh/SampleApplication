``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19041.1 (2004/May2020Update/20H1)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.104
  [Host]     : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT
  DefaultJob : .NET 5.0.14 (5.0.1422.5710), X64 RyuJIT


```
|       Method |     Mean |    Error |   StdDev | Allocated |
|------------- |---------:|---------:|---------:|----------:|
| GetBenchmark | 15.57 μs | 0.576 μs | 1.681 μs |         - |
