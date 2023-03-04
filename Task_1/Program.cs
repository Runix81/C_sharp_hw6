//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Функция создания массива

int[] AddArray(string msg)
{
    System.Console.Write($"{msg} -> ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    return array;
}

// Функция заполнения массива числами с клавиатуры

int[] EnterArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} элемент массива -> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

// Функция вывода массива в консоль

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

// Функция подсчета чисел больше 0 

int MoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

// Функция вывода результата в консоль

void PrintRes(int number)
{
    System.Console.Write($"-> {number}");
}

int[] array = AddArray("Введите размер массива");
EnterArray(array);
PrintArray(array);
int res = MoreZero(array);
PrintRes(res);

