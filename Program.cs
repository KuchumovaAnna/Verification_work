// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// **Примеры**:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []


string[] stringArray = { "program", "cat", "2", ":-)", "news", "mail" };

void PrintStringArray(string[] stringArray)
{
    Console.Write("[ ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"\"{stringArray[i]}\"");
        if (i != stringArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
int StringOf3OrLess(string[] stringArray)
{
    int numberOfStrings = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            numberOfStrings++;
        }
    }
    return numberOfStrings;
}

string[] CreateArrayOf3OrLess(string[] stringArrey, int sizeNewArray)
{
    string[] newStringArray = new string[sizeNewArray];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length < 4)
        {
            newStringArray[j] = stringArrey[i];
            j++;
        }
    }
    return newStringArray;
}

//string[] stringArray = { "hello", "world", "2", ":-)" };
PrintStringArray(stringArray);
//WriteLine(SearchStringWithSizeLessOrEqual3(stringArray));
int sizeNewArray = StringOf3OrLess(stringArray);
string[] newStringArray = CreateArrayOf3OrLess(stringArray, sizeNewArray);
Console.Write(" => ");
PrintStringArray(newStringArray);
Console.WriteLine();
