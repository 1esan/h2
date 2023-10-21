Console.WriteLine("Введите размерность матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] pup = new int[n * n];
int[] pop = new int[n * n];
int[] res = new int[n * n];

filling(pup, n);
filling(pop, n);

for (int i = 0; i < n * n; i++)
{
    Console.Write(pup[i] + " ");
}
print();

for (int i = 0; i < n * n; i++)
{
    Console.Write(pop[i] + " ");
}
print();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        for (int k = 0; k < n; k++)
        {
            res[i * n + j] += pup[i * n + k] * pop[k * n + j];
        }
    }
}

for (int i = 0; i < n*n; i++)
{
    Console.Write(res[i] + " ");
}

static int[] filling(int[] array, int n)
{
    Random random = new Random();

    for(int i = 0; i < n * n; i++)
    {
        array[i] = random.Next(10);
    }
    return array;
}
static void print_s()
{
    Console.WriteLine("-------------------------------------------");
}
static void print()
{
    Console.WriteLine("\n");
}