// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int n = 3;
int size = 7;
string[] arrayOne = new string[size];
FillArrayRandom(arrayOne);
Console.Clear();
PrintArray(arrayOne);

if (GetSizeSecondArray(arrayOne) == 0) Console.WriteLine("В введенном наборе строк массива отсутствуют необходимые значения, для формирования нового массива");
else
{
    string[] arrayTwo = TransferElement(arrayOne);
    Console.WriteLine($" -> [\"{String.Join("\",\" ", arrayTwo)}\"]");
}

void FillArrayRandom(string[] arr)
{
    Random rand = new();
    string Symbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890[;'/.,-=])(!@#$%^&*";
    for (int i = 0; i < size; i++)
    {
        int sizeRandomElement = rand.Next(1, 10);
        for (int j = 0; j < sizeRandomElement; j++)
        {
            arr[i] += Symbols[rand.Next(0, Symbols.Length)];
        }
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"\"{arr[i]}\", ");
    }
    Console.Write("]");
}

int GetSizeSecondArray(string[] arr)
{
    int secondSize = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            secondSize++;
        }
    }
    return secondSize;
}

string[] TransferElement(string[] arr)
{
    string[] arrayTwo = new string[GetSizeSecondArray(arrayOne)];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}



