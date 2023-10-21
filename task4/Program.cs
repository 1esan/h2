

Console.Write("Введите кол-во рядов: ");
int n=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во мест в каждом ряду: ");
int m=Convert.ToInt32(Console.ReadLine());
int[,] places = new int[n,m];
pup(places);

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(places[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите кол-во свободных мест, идущих подряд: ");    
int k = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    int freePlaces = 0;
    for (int j = 0; j < m; j++)
    {
        if (places[i,j] == 0)
        {
            freePlaces++;
            if (freePlaces == k)
            {
                Console.WriteLine($"Подходящий ряд: {pop(places,k)}");
                return;
            }
        }
        else
        {
            freePlaces = 0;
        }
    }
}

static int[,] pup(int[,] array)
{
    Random random = new Random();

    int n = array.GetLength(0);
    int m = array.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(0,2);
        }
    }
    return array;
}
static int pop(int[,] array, int target)
{
    int mostsuit = 0;
    int closestDiff = int.MaxValue;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int freePlaces = 0;
        for (int j = 0; j < cols; j++)
        {
            if (array[i, j] == 0)
            {
                freePlaces++;
                if (freePlaces == target)
                {
                    return i + 1;
                }
            }
            else
            {
                freePlaces = 0;
            }
        }

        int diff = Math.Abs(freePlaces - target);
        if (diff < closestDiff)
        {
            mostsuit = i;
            closestDiff = diff;
        }
    }

    return mostsuit;
}
static void print_s()

{
    Console.WriteLine("-------------------------------------------");
}
static void print()
{
    Console.WriteLine("\n");
}