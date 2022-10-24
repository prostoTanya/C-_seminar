Console.Write("Введите число: ");
int numberUser = Convert.ToInt32(Console.ReadLine());
int count = -numberUser;

while(count <= numberUser)
{
    Console.Write($"{count}, ");
    count++;    
} 