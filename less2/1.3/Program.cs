string crat(int num)
{
    if ((num % 7 == 0) && (num % 23 == 0))
        return "кратно";
    else
        return "некратно";
}

Console.WriteLine("1 chislo");
int first = int.Parse(Console.ReadLine());
Console.WriteLine(crat(first));