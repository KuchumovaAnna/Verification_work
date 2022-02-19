// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// **Примеры**:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []
using static System.Console;

void PrintStringArray (string[] stringArray)
{
    Write("[ ");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Write($"\"{stringArray[i]}\"");
        if (i!=stringArray.Length-1)
        {
            Write(", ");
        }
    }
Write("]");
}
int SearchStringWithSizeLessOrEqual3(string[] stringArray)
{
    int numberOfStrings = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length<4)
        {
            numberOfStrings++;
        }
    }
    return numberOfStrings;
}


string[] stringArray = {"hello", "world", "2", ":-)"};
PrintStringArray(stringArray);
WriteLine(SearchStringWithSizeLessOrEqual3(stringArray));
