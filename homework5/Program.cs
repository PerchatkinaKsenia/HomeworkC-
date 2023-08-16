//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] create_random_array (int size) 
{
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100,1000);
    return array;
}
void write_array (int[] array) 
{
    for (int i =0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(); 
}
int number_of_even_digits (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count ++;
    return count;
}

Console.Write("Inpun a length of array ");
int length = Convert.ToInt32(Console.ReadLine());

int[] my_array = create_random_array(length);
write_array(my_array);
Console.WriteLine(number_of_even_digits(my_array));
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] create_random_array (int size, int min_value, int max_value)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min_value,max_value + 1);
    return array;
}
void write_array (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int sum_of_negatives (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}
Console.Write("Input the length of an array ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the left border of array ");
int min_value = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the right border of array ");
int max_value = Convert.ToInt32(Console.ReadLine());

int [] my_array = create_random_array(length, min_value, max_value);
write_array(my_array);
Console.Write(sum_of_negatives(my_array));
*/
//Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateRandomArray(int size ) 
{ 
 double[] array = new double[size]; 
 
 for(int i = 0; i < size; i++) 
 { 
 Console.Write("Input the number in the array: "); 
 array[i] = Convert.ToDouble(Console.ReadLine()); 
 } 
 return array; 
} 
 
void WriteArray(double[] array) 
{ 
 for(int i = 0; i < array.Length; i++) 
 Console.Write(array[i] + " "); 
 
 Console.WriteLine(); 
} 
 
double minMax(double[] array) 
{ 
 double res = 0; 
 double max = array[0]; 
 double min = array[0]; 
 for(int i = 1; i < array.Length; i++) 
 { 
 if(max < array[i]) max = array[i]; 
 else if(min > array[i]) min = array[i]; 
 } 
 res = max - min; 
 return res; 
} 
 
Console.Write("Inpun a length of array "); 
int length = Convert.ToInt32(Console.ReadLine()); 
 
double[] myArray = CreateRandomArray(length); 
WriteArray(myArray); 
 
 
Console.WriteLine(minMax(myArray));
*/