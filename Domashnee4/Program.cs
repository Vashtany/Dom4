int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[] array, int minValue, int maxValue)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0;i < array.Length; i++)
    {
       array[i] = rnd.Next(minValue,maxValue);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0;  i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//void Task25()
//{
    // Используя определение степени числа, напишите цикл, который принимает 
    // на вход два натуральных числа (А и В) и возводит А в степень В.

//   int numA = Input("Введите число: А ");
//   int numB = Input("Введите число: В ");

//    double x = Math.Pow(numA, numB);
//    Console.WriteLine($"Число {numA} ^ {numB} = {x}");

//}

//void Task27()
//{
    //.., принимает на вход число и выдает сумму цифр в числе.

    //int number = Input("Введите число:  ");

    //int sum = 0;

    //Console.Write($"Сумма цифр числа {number} равна ");
    //while (number > 0)
    //{
    //    sum+= number%10;
    //    number /=10;
    //}
    //Console.WriteLine(sum);

//}

void Task29()
{
    //.., которая создает массив из 8 случайных чисел и
    // выводит отсортированный по модулю массив.
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);

    int lastIndex = numbers.Length -1;
    for (int i = 0; i < lastIndex;  i++)
    {
        for (int k = 0; k < lastIndex - i; k++)
        {
            if (Math.Abs(numbers[k]) > Math.Abs(numbers[k + 1]))
            {
                int temp = numbers[k];
                numbers[k] = numbers[k+1];
                numbers[k+1] = temp;
            }
        }
    }
    Console.WriteLine();
    PrintArray(numbers);
}


Console.Clear();
Task29();
