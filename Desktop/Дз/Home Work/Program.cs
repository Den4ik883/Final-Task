// ; Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам.
//   Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//    При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// ; Примеры:
// ; [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// ; [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// ; [“Russia”, “Denmark”, “Kazan”] → []

string[] GetArray(int size)  //Задаем массив в ручную
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите Слово >>>");
        string word = Convert.ToString(Console.ReadLine()!);
        array[i] = word;
    }
    return array;
}

void PrintArray(string[] array) //Вывод массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortingArray(string[] array, string[] array2) // Сортировка массива по заданым параметрам
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}
Console.WriteLine($"Введите длину массива >>>");
int size = Convert.ToInt32(Console.ReadLine()!);
string[] Array = GetArray(size);
string[] Array2 = new string[Array.Length];
PrintArray(Array);
SortingArray(Array, Array2);
PrintArray(Array2);