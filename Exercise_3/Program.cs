Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int [] array = new int [n];
double d = 0;
for (int i = 0; i < n; i++)
{
    array [i] = i + 1;
    d = Math.Pow(array[i], 3);
    Console.WriteLine(d);
} 