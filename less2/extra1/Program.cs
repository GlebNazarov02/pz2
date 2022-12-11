
void Teorema()
{
    List<int> chisla = new List<int>();
    int a = 86;
    if (a % 2 != 0)
    {
       for (int i = 4;i < a;i++)
       {
            for (int j = 2; j < i;j ++)
            {
                if ((i % j != 0) && (i == j +1))
                {
                    chisla.Append(i);
                    Console.WriteLine($"{i}");
                }
                else
                {
                    continue;
                }
            }
       }
    }
}

Teorema();