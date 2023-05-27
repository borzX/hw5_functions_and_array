Console.WriteLine("Введите номер задачи:");
int taskNumber = Convert.ToInt32(Console.ReadLine());

switch (taskNumber)
{
    case 34:
        TaskNumber34();
        break;
    
    case 36:
        TaskNumber36();
        break;
    
    case 38:
        TaskNumber38();
        break;
    
    default:
        Console.WriteLine("Вы ввели неверный номер");
        break;

}



void TaskNumber34()
{
    Console.WriteLine();
    Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными "+
                    "трёхзначными числами. Напишите программу, которая покажет количество "+ 
                    "чётных чисел в массиве. "+ "[345, 897, 568, 234] -> 2");
    Console.WriteLine();
 
    Console.Write("Введите длину массива: ");
    int arrayLenght = Convert.ToInt32(Console.ReadLine());
    int[] array34 = ArrayThreeDigitRandom(arrayLenght);
    Console.Write("Полученный массив: ");
    Console.WriteLine(String.Join(", ", array34));
    int countEven = 0;
    int countNoEven = 0;
    int arrayTemp = 0;
    int count = 0;
    while (count<arrayLenght)
    {
        arrayTemp = array34[count]%2;
        if (arrayTemp != 0) countNoEven++;
        else countEven++;
        count++;
    }
    Console.WriteLine($"Количество четных чисел: {countEven}");
}


void TaskNumber36()
{
    Console.WriteLine();
    Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. " + 
                    "Найдите сумму элементов, стоящих на нечётных позициях. " + "[3, 7, 23, 12] -> 19," + 
                    "[-4, -6, 89, 6] -> 0");
    Console.WriteLine();

    Console.Write("Введите длину массива: ");
    int arrayLenght = Convert.ToInt32(Console.ReadLine());
    int[] array36 = ArrayTwoDigitRandom(arrayLenght);
    Console.Write("Полученный массив: ");
    Console.WriteLine(String.Join(", ", array36));

    int sumNumber = 0;
    
    for (int i = 1; i < arrayLenght; i=i+2)
    {
        sumNumber += array36[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumNumber}");
}



void TaskNumber38()
{
    Console.WriteLine();
    Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между " + 
                    "максимальным и минимальным элементов массива. " + "Диапазон [-10, 10]. " + 
                    "Обратите внимание на *вещественных* чисел " + "Для примера возьмём диапазон побольше. " +
                    "[3 7 22 2 78] -> 76");
    Console.WriteLine();

    Console.Write("Введите длину массива: ");
    int arrayLenght = Convert.ToInt32(Console.ReadLine());
    double[] array38 = ArrayTwoDigitDoubleRandom(arrayLenght);
    Console.Write("Полученный массив: ");
    Console.WriteLine(String.Join(", ", array38));

    double numMin = 0;
    double numMax = 0;
    int count = 0;
    while (count<arrayLenght)
    {
        if (numMin<=array38[count]) numMin=array38[count];
        else if (numMax>= array38[count]) numMax=array38[count];
        count++;
    }
    double numDifference = numMin-numMax;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {numDifference}");
}


//Генерация Массива с 3-х значными числами
int[] ArrayThreeDigitRandom(int arrayLenght)
{
    int[] array = new int[arrayLenght];
    Random numRandom = new Random();
    for (int i =0; i < array.Length; i++)
    {
        array[i] =  numRandom.Next(100, 999);
    }
    return array;
}

//Генерация Массива с 2-х значными числами
int[] ArrayTwoDigitRandom(int arrayLenght)
{
    int[] array = new int[arrayLenght];
    Random numRandom = new Random();
    for (int i =0; i < array.Length; i++)
    {
        array[i] =  numRandom.Next(-10, 11);
    }
    return array;
}

//Генерация Массива с 2-х значными ВЕЩЕСТВЕННЫМИ числами
double[] ArrayTwoDigitDoubleRandom(int arrayLenght)
{
    double[] array = new double[arrayLenght];
    Random numRandom = new Random();
    for (int i =0; i < array.Length; i++)
    {
        array[i] =  numRandom.NextDouble()*numRandom.Next(-10, 10);
    }
    return array;
}