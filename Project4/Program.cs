Console.Write("Введите число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int numberA = numberUser - numberUser * 2;
int number = numberA;
int count = 0;

Console.WriteLine(numberA);

while(number < numberUser)
{
    number = number + 1;
    count = count + 1;
    Console.WriteLine(number);
} 