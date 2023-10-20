// Напишите программу, которая принимает навход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else Console.WriteLine("Будний день");

