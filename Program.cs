Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());


int SumRec (int n)
{
    if (n == m) return m;
    else return n = n + SumRec(n-1);
}
Console.WriteLine(SumRec(n));