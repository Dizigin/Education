using static System.Console;

// Мое решение
Console.WriteLine(new string('-', 122));
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "Type", "Bytes(s) of memory".PadLeft(0), "Min", "Max");
Console.WriteLine(new string('-', 122));
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "sbyte",	sizeof(sbyte),		sbyte.MinValue,		sbyte.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "byte",		sizeof(byte),		byte.MinValue,		byte.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "short",	sizeof(short),		short.MinValue,		short.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "ushort",	sizeof(ushort),		ushort.MinValue,	ushort.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "int",		sizeof(int),		int.MinValue,		int.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "uint",		sizeof(uint),		uint.MinValue,		uint.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "long",		sizeof(long),		ulong.MinValue,		long.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "ulong",	sizeof(ulong),		ulong.MinValue,		ulong.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "float",	sizeof(float),		float.MinValue,		float.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "double",	sizeof(double),		double.MinValue,	double.MaxValue);
Console.WriteLine("| {0,-15} | {1,20} | {2,35} | {3,40} |", "decimal",	sizeof(decimal),	decimal.MinValue,	decimal.MaxValue);

// Решение из книги
WriteLine("--------------------------------------------------------------------------");
WriteLine("Type    Byte(s) of memory               Min                            Max");
WriteLine("--------------------------------------------------------------------------");
WriteLine($"sbyte   {sizeof(sbyte),-4} {sbyte.MinValue,30} {sbyte.MaxValue,30}");
WriteLine($"byte    {sizeof(byte),-4} {byte.MinValue,30} {byte.MaxValue,30}");
WriteLine($"short   {sizeof(short),-4} {short.MinValue,30} {short.MaxValue,30}");
WriteLine($"ushort  {sizeof(ushort),-4} {ushort.MinValue,30} {ushort.MaxValue,30}");
WriteLine($"int     {sizeof(int),-4} {int.MinValue,30} {int.MaxValue,30}");
WriteLine($"uint    {sizeof(uint),-4} {uint.MinValue,30} {uint.MaxValue,30}");
WriteLine($"long    {sizeof(long),-4} {long.MinValue,30} {long.MaxValue,30}");
WriteLine($"ulong   {sizeof(ulong),-4} {ulong.MinValue,30} {ulong.MaxValue,30}");
WriteLine($"float   {sizeof(float),-4} {float.MinValue,30} {float.MaxValue,30}");
WriteLine($"double  {sizeof(double),-4} {double.MinValue,30} {double.MaxValue,30}");
WriteLine($"decimal {sizeof(decimal),-4} {decimal.MinValue,30} {decimal.MaxValue,30}");
WriteLine("--------------------------------------------------------------------------");

