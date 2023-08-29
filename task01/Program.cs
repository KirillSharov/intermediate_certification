// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

void PrintArray(int i, string[] array, string symbol)
{
    if (i == 0)
    {
        Console.Write("[]");
    }
    else
    {
        Console.Write("[");
        for (int m = 0; m < i - 1; m++)
        {
            Console.Write($"\"{array[m]}\", ");
        }
        Console.Write($"\"{array[i - 1]}\"] {symbol}");
    }
}

string[] CreateNewArray(int i, string[] array)
{
    string[] newArray = new string[i];
    int k = 0;
    for (int l = 0; l < i; l++)
    {
        if (array[l].Length <= 3)
        {
            newArray[k++] = array[l];
        }
    }
    return newArray;
}

int CountRequiredElement(int i, string[] array)
{
    int count = 0;
    for (int j = 0; j < i; j++)
    {
        if (array[j].Length <= 3) count++;
    }
    return count;
}

int FillArray(string message, string[] array)
{
    string userElement;
    int i = 0;
    Console.WriteLine(message);
    while ((userElement = Console.ReadLine()) != "end")
    {
        array[i++] = userElement;
    }
    return i;
}

string[] userArray = new string[100];
int arrayElementCount = FillArray("Введите последовательность строк для заполнения массива, когда закончите - введите 'end'", userArray);
int count = CountRequiredElement(arrayElementCount, userArray);
string[] newUserArray = CreateNewArray(arrayElementCount, userArray);
PrintArray(arrayElementCount, userArray, " -> ");
PrintArray(count, newUserArray, "");