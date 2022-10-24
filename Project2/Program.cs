Console.Write("Введите первое число: ");
int numberUser1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberUser2 = Convert.ToInt32(Console.ReadLine());
int square = numberUser2 * numberUser2;

if (square == numberUser1)
{
    Console.WriteLine($"Число {numberUser1} является квадратом числа {numberUser2}");
} 
else
{
  Console.WriteLine($"Число {numberUser1} не является квадратом числа {numberUser2}");  
}