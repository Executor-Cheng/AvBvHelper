B站Av号和Bv号互转

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.17763.678 (1809/October2018Update/Redstone5)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
```

| Method |        av |           bv |     Mean |    Error |   StdDev |
|------- |---------- |------------- |---------:|---------:|---------:|
|  **Av2Bv** | **582921863** |            **?** | **24.71 ns** | **0.547 ns** | **0.608 ns** |
|  **Bv2Av** |         **?** | **BV1L64y1M7Dp** | **28.96 ns** | **0.595 ns** | **0.685 ns** |
