int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));