void hinh1(int n)
{
    for(int i = 0; i <= n-1; i++)
    {
        for (int j = 0; j <= n-1; j++)
        {
            if (j == 0 || j ==n -1||i==j)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void hinh2(int n)
{
    for (int i = 0; i <= n - 1; i++)
    {
        for (int j = 0; j <= n - 1; j++)
        {
            if (j == 0 || j == n - 1 || i == j)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
hinh2(5);