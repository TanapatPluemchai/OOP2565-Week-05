sbyte b1 = 0;
byte b2 = 0;
short sh1 = 0;
ushort sh2 = 0;
int i1 = 0;
uint i2 = 0;
Console.WriteLine("Type\tminValue\tmaxValue");
Console.WriteLine($"{b1.GetTypeCode()}\t{sbyte.MinValue}\t\t{sbyte.MaxValue}");
Console.WriteLine($"{b2.GetTypeCode()}\t{byte.MinValue}\t\t{byte.MaxValue}");
Console.WriteLine($"{sh1.GetTypeCode()}\t{short.MinValue}\t\t{short.MaxValue}");
Console.WriteLine($"{sh2.GetTypeCode()}\t{ushort.MinValue}\t\t{ushort.MaxValue}");
Console.WriteLine($"{i1.GetTypeCode()}\t{int.MinValue}\t{int.MaxValue}");
Console.WriteLine($"{i2.GetTypeCode()}\t{uint.MinValue}\t\t{uint.MaxValue}");


