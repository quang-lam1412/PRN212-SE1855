Console.OutputEncoding = System.Text.Encoding.UTF8;
/*
 nhập vào 1 số>= 0 nếu nhập sai qiu tắc
thì yêu cầu nhập lạo khi nào đúng mới dừng 
nếu nhập đúng thì tính giai thừa của số này
 */
int n = -1;//giả sử nhập sai
while (n < 0)//nắt nhập lại cho khi nào n>0
{
    Console.WriteLine("nhập n >= 0");
    String input = Console.ReadLine();
    if(int.TryParse(input, out n) ==true)
    {//khi vài đây thù n là số nhưng có thể < 0
        if (n >= 0)//nhập đng
        {
            break;//k bắt nhập nx
        }
        else
            Console.WriteLine("nhập lớn hơn >= 0 ");
    }
    else
    {
        Console.WriteLine("bảo nhập số mà");
    }    
}
int gt = 1;
for (int i = 1; i <= n; i++)
{
    gt = gt * i;
}
Console.WriteLine($"{n} != {gt}");