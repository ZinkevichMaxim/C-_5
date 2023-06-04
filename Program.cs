// Универсальный метод заполнения массива в тч и Random
// Универсальный метод распечатки массива
// foreach
// Поиск сумм двумя способами - void и returne



Console.Clear();

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Универссальный метод генерации массива

int[] GetArray(int size, int minValue, int maxValue) //size = lenght; поскольку будем использоваь Random() maxValue +1
{
    int[] res = new int[size];                       // инициализируем новый массив внутри метода
    for(int i = 0; i < size; i++)
    {
    res[i] = new Random().Next(minValue, maxValue + 1); // Если числа вещественные, вероятно NextDouble
   // Console.Write($"{res[i]} /");                       Проверка работает
    }
    return res;
}

//int[] array = GetArray(12, -9, 9);

void PrintArray(int[] arr)             //Таким образои распечатать массив можно ТОЛЬКО через простой цикл While/For 
{
    for(int i = 0; i < arr.Length; i++)               // где после каждой итерации печатается новый элемент массива
    {
        Console.Write($"{arr[i]} ,");      
    }
}


// PrintArray(array);
// FindSum(array);

// Первый вариант метода

// void FindSum(int[] arr)
// {
// int positiveSum = 0;
// int negativeSum = 0;
// foreach(int el in arr)               //el - переменная, можно назвать как угодно  - это элемент цикла, число в нашем случае
// {
//     if (el > 0)
//     {
//         positiveSum = positiveSum + el; /// positiveSum += el
//     }
//     else
//     {
//         negativeSum += el;
//     }

// }

// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел равна {positiveSum} Cумма отрицательных чисел равна {negativeSum}");
// }

//int[] array = GetArray(12, -9, 9);   Ниже другая сборка со вторым методои поиска сумм
//PrintArray(array);
//FindSum(array);

// Второй вариант метода. В случае если нужно вернуть суммы положительных и отриуательных чисел и жальше с ними что-то делать

int[] FindSum(int[] arr)
{
int positiveSum = 0;
int negativeSum = 0;
int[] ress = new int[2];              // через создание нового массива
foreach(int el in arr)               //el - переменная, можно назвать как угодно  - это элемент цикла, число в нашем случае
{
    if (el > 0)
    {
        positiveSum = positiveSum + el; /// positiveSum += el
    }
    else
    {
        negativeSum += el;
    }

}
ress[0] = positiveSum;       //формируем массив В return НЕЛЬЗЯ ЗАПИСАТЬ НЕСКОЛЬКО ЧИСЕЛ
ress[1] = negativeSum;
return ress;                  // Вернуть можно только масив из нескольких чисел

}
int[] array = GetArray(12, -9, 9);
PrintArray(array);
int[] ress = FindSum(array);
Console.WriteLine();
PrintArray(ress);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел равна {ress[0]} Cумма отрицательных чисел равна {ress[1]}");


