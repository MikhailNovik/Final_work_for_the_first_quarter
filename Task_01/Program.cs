/*
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*/

string[] array = { "hello", "2", "world", ":-)" };
//string[] array = { "1234", "1567", "-2", "computer science" };
//string[] array = { "Russia", "Denmark", "Kazan" };

int maxLengthOfElem = 3;

string[] CreateArray(int count)
{
    return new string[count];
}

bool FilterElem(string elem, int length)
{
    if (elem.Count() <= length)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetNumberOfElemInArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (FilterElem(array[i], maxLengthOfElem))
        {
            count += 1;
        }
    }

    return count;
}

void СopyRequiredElemToNewArray(string[] oldArray, string[] newArray)
{
    int index = 0;

    for (int i = 0; i < oldArray.GetLength(0); i++)
    {
        if (FilterElem(oldArray[i], maxLengthOfElem))
        {
            newArray[index] = oldArray[i];
            index++;
        }
    }
}

string PrintArray(string[] array)
{
    string outputSrt = String.Empty;
    outputSrt = "[" + string.Join(", ", array) + "]";

    return outputSrt;
}


Console.Write("Исходный массив: ");
Console.WriteLine(PrintArray(array));

int lengthNewArray = GetNumberOfElemInArray(array);
string[] newArray = CreateArray(lengthNewArray);
СopyRequiredElemToNewArray(array, newArray);

Console.Write("Результирующий массив: ");
Console.WriteLine(PrintArray(newArray));
