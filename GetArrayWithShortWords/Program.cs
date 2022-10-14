// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

//Получение массива из строк, длина которых меньше либо равна 3 символа
string[] GetArrayWithShortWords(string[] array)
{
    int count = 0;
    var tmpArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        { 
            tmpArray[count] = array[i];
            count++;
        }
    }

    var newArray = new string[count];
    for (int i = 0; i < count; i++)
    {
        newArray[i] = tmpArray[i];
    }
    return newArray;
}

//Вывод массива в строку
string ShowArray(string[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) result = $"{result}{array[i]}";
        else result = $"{result}, {array[i]}";
    }
    result = $"{result}]";
    return result;
}

//Тестовый пример 1
var arrayTest1 = new string[] {"hello","2","world",":-)"};
Console.WriteLine("Заданный массив 1:");
Console.WriteLine(ShowArray(arrayTest1));

var shortArrayTest1 = GetArrayWithShortWords(arrayTest1);
Console.WriteLine("Массив из строк длиной 3 символа и меньше:");
Console.WriteLine(ShowArray(shortArrayTest1));

Console.WriteLine();

//Тестовый пример 2
var arrayTest2 = new string[] {"Russia","Denmark","Kazan"};
Console.WriteLine("Заданный массив 2:");
Console.WriteLine(ShowArray(arrayTest2));

var shortArrayTest2 = GetArrayWithShortWords(arrayTest2);
Console.WriteLine("Массив из строк длиной 3 символа и меньше:");
Console.WriteLine(ShowArray(shortArrayTest2));


