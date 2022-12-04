// Написать программу, которая 
// из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

//пользователь задает нужное количество строк в массиве через консоль
Console.Write("Введите нужное количество строк в массиве: ");
int size = Convert.ToInt32(Console.ReadLine()); 

//пользователь задает строки для массива через консоль
string[] CreatArray(int number) 
{
    string[] array = new string[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ю строку: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

// формируется новый массив из слов, длина которых 3 и менее символа
string[] ResultArray(string[] arr) 
{
    int pos = 0;
    int len = 3;
    string[] newArray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= len)
        {
            newArray[pos] = arr[i];
            pos++;
        }
    }      // исключение элементов с пустыми строками из массива
    return newArray.Where(pos => !string.IsNullOrWhiteSpace(pos)).ToArray(); 
}

void PrintArray(string[] arr) // вывод пользовательского массива в консоль
{
    Console.WriteLine("Результат:");
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i < arr.Length - 1 ? $"{arr[i]}, " : $"{arr[i]}");
    }
    Console.Write("]");
}

void PrintResultArray(string[] newArr) // вывод результирующего массива в консоль
{
    Console.Write(" -> ");
    Console.Write("[");
    for (int i = 0; i < newArr.Length; i++)
    {
        Console.Write(i < newArr.Length - 1 ? $"{newArr[i]}, " : $"{newArr[i]}");
    }
    Console.Write("]");
}

// проверка корректности ввода пользователем размера массива
if (size > 0)
{
    string[] initialArray = CreatArray(size);
    Console.WriteLine();
    PrintArray(initialArray);
    string[] resultArray = ResultArray(initialArray);
    PrintResultArray(resultArray);
    Console.WriteLine();
}
else Console.WriteLine("Ошибка. Неверное значение количества строк массива!");