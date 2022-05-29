// функция вывода массива на экран
void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write($"{element}");
    Console.WriteLine();
}
//создание массива случайными числами
int[] CreateArray(int size, int minimum, int maximum) //размер массива,от мин.,до мак.
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i< size; i++)
        array[i] = random.Next(minimum, maximum);
    return array;
}
//для определения, входит ли элемет в массив
bool Contains(int[] array, int value)
{
    foreach (var element in array)
        if (element == value)
            return true;
    return false;
}

int[] firstArray = CreateArray(5, -10, 10);
Console.Write("Your array: ");
PrintArray(firstArray);
Console.Write("Enter value to find in array: ");
int value = int.Parse(Console.ReadLine() ?? "0");
if (Contains(firstArray, value))
    Console.WriteLine("Contains");
else
    Console.WriteLine("Does not contains");
// if/else можно записать иначе
// через тернарный оператор- это оператор присваивания
// Console.WriteLine(Contains(firstArray,value)?"Contains":"Does not contains");
//                   условие как в if         
//                после ? пишем значение, которое будет после выполнения условия
//                после : значение, если условие не выполнено 