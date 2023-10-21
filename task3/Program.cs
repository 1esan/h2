using task3;
using System;

int i;
Random random = new Random();
Console.WriteLine("Введите размерность первого массива: ");
int P = Convert.ToInt32(Console.ReadLine());
int[] pop = Array(P);
print();
foreach (int num in pop) { Console.Write($"{num} "); }
print();
Console.WriteLine("Введите размерность второго массива: ");
int L = Convert.ToInt32(Console.ReadLine());
int[] pup = Array(L);
print();
foreach (int num in pup) { Console.Write($"{num} "); }
print();
print_s();
//Сложение массивов
if (P == L)
{
    int[] popup = sumArray(pop, pup, P);
    foreach (int num in popup)
    {
        Console.Write($"{num} ");
    }
}
else
{
    Console.WriteLine("Размерность массива разная, сложить не получилось");
}
print();
print_s();

//Умножение массивов
Console.WriteLine($"Введите число, на которое поэлементно будет умножен каждый из массивов");
int l = Convert.ToInt32(Console.ReadLine());
print();

Console.WriteLine($"Первый массив:  ");
int[] pop1 = multArray(pop, pop.Length, l);
foreach (int num in pop1)
{
    Console.Write($"{num} ");
}
print();

Console.WriteLine($"Второй массив:  ");
int[] pup1 = multArray(pup, pup.Length, l);
foreach (int num in pup1)
{
    Console.Write($"{num} ");
}
print();
print_s();

//Сравение массивов
int[] colbas = compArray(pop, pup);
Console.WriteLine("Значения массивов, которые совпали: ");
print();
foreach (int num in colbas) { Console.Write($"{num} "); }
print();
print_s();

//Сортировка массивов
Console.WriteLine("Сортировка массивов по убыванию: ");
Console.WriteLine("First: ");
int[] a = sortArray(pop);
foreach (int num in a) { Console.Write($"{num} "); }
print();

Console.WriteLine("Second: ");
int[] b = sortArray(pup);
foreach (int num in b) { Console.Write($"{num} "); }
print();
print_s();
Console.WriteLine("1-ый массив: ");
print();

//Поиск минимальных, максимальных и средних значений
int pop_min = Class1.min(pop);
Console.WriteLine($"Минимальное значение:\n {pop_min}");
print();

double pop_mean = Class1.mean(pop);
Console.WriteLine($"Среднее значение:\n {pop_mean}");
print();

int pop_max = Class1.max(pop);
Console.WriteLine($"Максимальное значение:\n {pop_max}");
print();
print_s();

Console.WriteLine("2-ой массив: ");
print();

int pup_min = Class1.min(pup);
Console.WriteLine($"Минимальное значение:\n {pup_min}");
print();

double pup_mean = Class1.mean(pup);
Console.WriteLine($"Среднее значение:\n {pup_mean}");
Class1.mean(pup);
print();

int pup_max = Class1.max(pup);
Console.WriteLine($"Максимальное значение: {pup_max}");
Class1.max(pup);
print();
static int[] sortArray(int[] array)
{
    int count = 0;
    while (count < array.Length - 1)
    {
        count = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            else
            {
                count++;
            }
        }
    }
    return array;
}
static int[] compArray(int[] a, int[] b)
{
    List<int> colbasa = new List<int>();
    int i = 0;
    int j = 0;
    while (i < a.Length && j < b.Length)
    {
        if (a[i] == b[j])
        {
            colbasa.Add(a[i]);
            i++;
            j++;
        }
        else if (a[i] < b[j])
        {
            i++;
        }
        else
        {
            j++;
        }

    }
    return colbasa.ToArray();
}
static int[] multArray(int[] u, int lenght, int num)
{
    int[] r = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        r[i] = u[i] * num;
    }
    return r;
}
static int[] sumArray(int[] u, int[] o, int lenght)
{
    int[] r = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        r[i] = u[i] + o[i];
    }

    return r;
}
static int[] Array(int i)
{
    int[] pop = new int[i];
    Random random = new Random();
    for (int k = 0; k < i; k++)
    {
        pop[k] = random.Next(10);
    }
    return pop;
}
static void print_s()

{
    Console.WriteLine("-------------------------------------------");
}
static void print()
{
    Console.WriteLine("\n");
}
static void print_s()
{
    Console.WriteLine("-------------------------------------------");
}
static void print()
{
    Console.WriteLine("\n");
}