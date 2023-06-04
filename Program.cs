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


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] Massiv(int size, int minValue, int maxValue)
{
int[] res = new int[size]; // создаем массив
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
Console.Write($"{res[i]} ");

}
return res;
}
// void ChangeNum(int[] array)
// {

// foreach (int el in array)
// {
// Console.Write($"{el*(-1)} ");

// }

// }
void ChangeNum2(int[] array)
{
int i = 0;
foreach (int el in array)
{

array[i]=el*(-1);
Console.Write($"{array[i]} ");
i++;

}

}
void ShowResult(int [] num){
Console.WriteLine($"Сумма положительных чисел = {num[0]}, сумма отрицательных чисел = {num[1]}");
}

int[] xyz = Massiv(12, -9, 9);
Console.WriteLine(" ");
ChangeNum2(xyz);

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int[] massiv = { 6, 7, 19, 345, 3 };
void FindNum(int[] array, int x)
{
int i = 0;
int length = array.Length;
bool flag = false;
while (i < length)
{

if (x == array[i])
{
flag = true;
}
i++;
}
if (flag) {
Console.WriteLine($"Цифра {x} имеется в массиве");

}
else {
Console.WriteLine($"Цифра {x} нет в массиве");
}
}
Console.WriteLine(string.Join(", ", massiv));
FindNum(massiv, 345);