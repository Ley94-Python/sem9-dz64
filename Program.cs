// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void Numbers(int num)
{
if (num == 0)
{
return;// для того чтобы наша рекурсия остановилась, иначе память в программе переполниться и работать не будет
}
Console.Write($"{num} ");
Numbers(num - 1);

}
Console.Write("Введите число: ");
int nums = int.Parse(Console.ReadLine());
Numbers(nums);