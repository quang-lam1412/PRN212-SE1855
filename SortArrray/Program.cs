using System.Text;

void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
void sort_arr(int[] arr)
{
    for(int i = 0;i < arr.Length; i++)
    {
        for(int j = i+1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
                //ref là tham chiếu, truyền vào địa chỉ của biến, phải có tha số trc khai báo trc và có đầu ra cx đc
                //out là tham chiếu, truyền vào địa chỉ của biến này thì k cân khai báo trc nhưng phải có đầu ra
            }
        }
    }
}


void sort_while(int[] arr)
{
    while (true)
    {
        bool swapped = false;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                swap(ref arr[i], ref arr[i + 1]);
                swapped = true;
            }
        }
        if (!swapped) break;
    }
}
void create_array(int[] arr)
{
    Random rd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rd.Next(1, 100);
    }
}
void print_array(int[] arr)
{
    foreach (int x in arr)
    {
        Console.Write($"{x}\t");
    }
}
int[] arr = new int[10];
create_array(arr);
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Mảng trước khi sắp xếp");
print_array(arr);
Console.WriteLine("Mảng sau khi sắp xếp");
sort_arr(arr);
print_array(arr);
