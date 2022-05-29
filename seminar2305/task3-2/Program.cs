// Написать программу преобразования десятичного чсила в двоичное
// 2 вариант
//Console.WriteLine("Введите число ");
//int a = int.Parse(Console.ReadLine());
//int b = 0;
//string result = ""; //в result вставили пустое значение для вывода в строку
//while (a > 0)
//{
//    b = a % 2;
//    result = b + result;
//    a = a / 2;
//}
//Console.WriteLine(result);

// третий вариант
Console.WriteLine("Введите число ");
int Number = int.Parse(Console.ReadLine());
int Bit = Number%2;
int NewNumber= Bit;
Number=Number/2;
int i=10;
while (Number > 0)
{
    Bit = Number % 2;
    Number=Number/2;
    NewNumber = NewNumber+Bit*i;
    i=i*10;
}
Console.WriteLine(NewNumber);