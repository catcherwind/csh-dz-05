int[] FillingArray(int n){
    Random rnd = new Random();
    int[] arr = new int[n];
    for(int i = 0; i < n; i++){
        arr[i] = rnd.Next(100,999);
    }
    return arr;
}

int SearchEven(int[] arr){
    int col = 0;
    for (int i = 0; i < arr.Length; i++){
        col = arr[i] % 2 == 0 ? col + 1 : col;
    }
    return col;
}

Console.WriteLine("Введите число - размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = FillingArray(n);
Console.WriteLine(String.Join(" ", arr));
int col = SearchEven(arr);
Console.WriteLine($"Чётных элементов в массиве: {col}");