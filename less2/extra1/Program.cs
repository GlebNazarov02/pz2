int[] mass = new int[1000];

int main(int n)
{
    int i, j;
    for (i = 2; i <= n; i++) mass[i] = i;

    for (j = 2; 2 * j <= n; j++)
        for (i = j + j; i <= n; i += j) mass[i] = 0;

    for (i = 2; 2 * i <= n; i++)
        if ((mass[i] != 0) && (mass[n - i] != 0))
        {
            // вывод результата     
            Console.WriteLine($"{mass[i]} and {mass[n-i]}");
            break;
        }
    return 0;
}
int chislo = int.Parse(Console.ReadLine());
main(chislo);