// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

void PrintStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write(array[i]);
        }

    }
}

int CounterElemLessThree(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void CreateArrayElemLessThree(string[] array)
{
    int count = CounterElemLessThree(array);

    string[] result = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    PrintStringArray(result);
}

string[] array = new string[] { "Hello", "2", "world", ":-)" };

Console.WriteLine($"Original array string: ");
PrintStringArray(array);

Console.WriteLine($"\nArray string with elements 3 and less: ");
CreateArrayElemLessThree(array);


