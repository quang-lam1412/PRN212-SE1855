static int sum(int a, int b)
{
    return a + b;
}

void callsum()
{
    int s = sum(5, 8);
}


double average(int a, int b)
{
    return (a + b) / 2;
}

static void callaverage()
{
    //double d = average(3, 6);sai
    //có chữ static là khởi tạo trc r ms tới k có 
    //nên cái average k thể gọi đc vì nó chưa khởi tạo
}