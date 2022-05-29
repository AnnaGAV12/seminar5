// Выяснить, являютя ли три числа сторонами треугольника
Console.Write("Введите 1 сторону треугольника: ");
int Side1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2 сторону треугольника: ");
int Side2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 3 сторону треугольника: ");
int Side3 = int.Parse(Console.ReadLine() ?? "0");
if ((Side1 + Side2) > Side3 && (Side1 + Side3) > Side2 && (Side3 + Side2) > Side1)
    Console.WriteLine("Является сторонами треугольника ");
else 
    Console.WriteLine("Не является сторонами треугольника ");