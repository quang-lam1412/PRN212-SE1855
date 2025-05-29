Console.OutputEncoding = System.Text.Encoding.UTF8;
(int, double) SumAndAverage(params int[]arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];

    }
    double average = (double)sum / arr.Length;
    return (sum, average);  
}
int[] arr = { 1, 2, 3, 4, 5, 100, 30, 17 };
(int sum, double average) = SumAndAverage(arr);
Console.WriteLine($"Tổng là: {sum}");
Console.WriteLine($"Trung bình là: {average}");