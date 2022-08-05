/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

void NewArray(string[] array) // Метод заполнения массива с длиной строк <= 3
{
    string[] newarr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarr[i] = array[i]; ;
            Console.Write(newarr[i]+ "; ");
        }
    }
    Console.WriteLine();
}

void Print(string[] Array)  //метод вывода массива
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + "; ");
    }
    Console.WriteLine();
}

string[] array = { "hello", "2", "world", ":-)" }; //исходный массив, можно ввести другие значения элементов

Console.WriteLine("Исходный массив:");
Print(array);
Console.WriteLine();
Console.WriteLine("Сформированный по условию массив:");
NewArray(array);