//1-ое задание

using System;

Console.WriteLine("Введите размерность основного массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] pup = new int[N];
int i;

Console.WriteLine("Заполните массив: ");
for (i = 0;i < pup.Length; i++)
{
    pup[i] = Convert.ToInt32(Console.ReadLine());
}
print();

for (i = 0;i < N; i++)
{
    Console.Write($"{pup[i]} ");
}
print();

Console.WriteLine("Введите кол-во элементов, которые хотели бы добавить в массив: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] pop = new int[M];

Console.WriteLine("Введите элементы, которые хотели бы добавить в массив");
for (i = 0; i < pop.Length; i++)
{
    pop[i] = Convert.ToInt32(Console.ReadLine());
}
print();

Console.WriteLine($"Введите позицию, начиная с которой вы бы хотели вставить введённые элементы(от 0 до {N-1}):");
int K = Convert.ToInt32(Console.ReadLine());
print();

Array.Resize(ref pup, pup.Length + M); 
Array.Copy(pup, K, pup, K + M, pup.Length - K - M); 
Array.Copy(pop, 0, pup, K, M);

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