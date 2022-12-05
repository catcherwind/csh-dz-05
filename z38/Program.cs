double[] FillingArray(int n)
{
    Random rnd = new Random();
    double[] arr = new double[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-1000, 1000) / 100.0;
    }
    return arr;
}

double FindingDifferenceBetweenMaxMin(double[] arr)
{
    return arr.Max() - arr.Min();
}

Console.WriteLine("Введите число - размер массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] arr = FillingArray(n);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(Math.Round(FindingDifferenceBetweenMaxMin(arr), 2));