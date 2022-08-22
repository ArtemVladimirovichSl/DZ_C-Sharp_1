Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2 && num1 > num3)
{
    Console.Write("max = ");
    Console.WriteLine(num1);
}
if(num2 > num1 && num2 > num3)
{
    Console.Write("max = ");
    Console.WriteLine(num2);
}
if(num3 > num1 && num3 > num2)
{
    Console.Write("max = ");
    Console.WriteLine(num3);
}
else
Console.Write("Одинаковые числа");