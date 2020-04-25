B站Av号和Bv号互转

跑分结果:  
BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363  
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores  
.NET Core SDK=3.1.201  
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT  
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT  


| Method |        av |           bv |      Mean |    Error |   StdDev |
|------- |---------- |------------- |----------:|---------:|---------:|
|  **Av2Bv** | **582921863** |            **?** | **114.96 ns** | **0.474 ns** | **0.444 ns** |
|  **Bv2Av** |         **?** | **BV1L64y1M7Dp** |  **57.64 ns** | **0.198 ns** | **0.176 ns** |
