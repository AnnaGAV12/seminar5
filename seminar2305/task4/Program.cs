// Показать числа Фибоначчи меньше заданного числа N
// первый вариант
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine() ?? "");

int firstValue = 0;
int secondValue = 1;
int result = 0;
Console.Write($"{firstValue} {secondValue}");

while (firstValue + secondValue < N)
{
    result = firstValue + secondValue;
    Console.Write(result + " ");
    firstValue = secondValue;
    secondValue = result;
}


