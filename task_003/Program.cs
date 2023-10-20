// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99) // если больше 99 то
{
   while (num > 999)
   {
    num /= 10;
   }
   Console.WriteLine(num%10);

}
else Console.WriteLine("Нет третьей цифры");

