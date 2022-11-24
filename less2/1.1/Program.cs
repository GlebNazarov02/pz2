int MaxNumber(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

Console.WriteLine(MaxNumber(new Random().Next(100, 1000)));
