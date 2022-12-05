int[] FillingArray(int n){
    Random rnd = new Random();
    int[] arr = new int[n];
    for(int i = 0; i < n; i++){
        arr[i] = rnd.Next(-1000,1000);
    }
    return arr;
}

int FindingSumm(int[] arr){
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2){
        sum += arr[i];
    }
    return sum;
}

Console.WriteLine("Введите число - размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = FillingArray(n);
Console.WriteLine(String.Join(" ", arr));
int sum = FindingSumm(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");