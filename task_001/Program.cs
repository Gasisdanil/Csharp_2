/ Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа


Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 100 && num < 1000)
{
    num = num / 10;
    num = num % 10;
    Console.WriteLine(num);
}
else Console.WriteLine("Вы ввели не трехзначное число");
