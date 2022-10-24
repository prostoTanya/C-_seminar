Console.Write("Введите число от 1 до 7: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber == 1)
{
    Console.WriteLine("День 1 - Понедельник");
}

else if(userNumber == 2)
{
    Console.WriteLine("День 2 - Вторник");
}

else if(userNumber == 3)
{
    Console.WriteLine("День 3 - Среда");
}

else if(userNumber == 4)
{
    Console.WriteLine("День 4 - Четверг");
}

else if(userNumber == 5)
{
    Console.WriteLine("День 5 - Пятница");
}

else if(userNumber == 6)
{
    Console.WriteLine("День 6 - Суббота");
}

else if(userNumber == 7)
{
    Console.WriteLine("День 7 - Воскресенье");
}