void PrintNumber(int n)
{
    //int n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) return;
    Console.Write(n + " ");
    PrintNumber(n - 1);
}
Console.WriteLine("Введите число ");
PrintNumber(Convert.ToInt32(Console.ReadLine()));