// //Второй вариант: показывает первые N чисел Фибоначчи
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "");
int a = 1;
int b = 0;
int result;
for (int i = 0; i < n; i++)
{
    result = a + b;
    Console.Write(result + " ");
    a = b;
    b = result;
}