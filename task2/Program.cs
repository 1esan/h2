Console.WriteLine("Введите размерность основного массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] pup = new int[N];
int i;

Console.WriteLine("Заполните массив: ");
for (i = 0; i < pup.Length; i++)
{
    pup[i] = Convert.ToInt32(Console.ReadLine());
}
print();
Console.WriteLine("Массив до: ");
for (i = 0; i < N; i++)
{
    Console.Write($"{pup[i]} ");
}
print();


if (N % 2 == 0)
{
    int cent = pup.Length / 2;
    for (i = 0; i < cent; i++)
    {
        (pup[i], pup[i + cent]) = (pup[i + cent], pup[i]);
    }
}
else
{
    int cent = pup.Length / 2;
    for (i = 0; i < cent; i++)
    {
        int num = pup[i];
        pup[i] = pup[i + cent + 1];
        pup[i + cent + 1] = num;
    }
}
print();
Console.WriteLine("Массив после:");
for (i = 0; i < pup.Length; i++)
{
    Console.Write($"{pup[i]} ");
}
print();

static void print_s()
{
    Console.WriteLine("-------------------------------------------");
}
static void print()
{
    Console.WriteLine("\n");
}