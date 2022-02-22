``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19041.1 (2004/May2020Update/20H1)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4420.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4420.0), X86 LegacyJIT


```
|        Method |      Mean |     Error |    StdDev |    Median | Allocated |
|-------------- |----------:|----------:|----------:|----------:|----------:|
| TestBenchmark | 0.0050 ns | 0.0072 ns | 0.0067 ns | 0.0029 ns |         - |
