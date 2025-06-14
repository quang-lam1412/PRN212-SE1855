using System.Text;
using Lucy_SalesManagament;


Console.OutputEncoding = Encoding.UTF8;

string connectionString = @"server=LAPTOP-BM436BGS\PIEDTEAM;database=Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
//câu 1: lấy chi tiết thông tin khách hàng khi biết mã
int customerid = 1;
Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == customerid);
if (cust != null)
{
    Console.WriteLine($"Customer ID: {cust.CustomerID}");
}
else
{
    Console.WriteLine($"Customer with ID {customerid} not found.");
}
//cau 2: lọc râ danh sách các hóa đơn của khách hàng 
if (cust != null)
{
    Console.WriteLine("Hóa đơn của khách hàng :");
    foreach (var order in cust.Orders)
    {
        Console.WriteLine($"Order ID: {order.OrderID}, Order Date: {order.OrderDate.ToString("d/M/yyyy")}");
    }
}
//câu 3: bổ sung thêm một cột trị giá của hóa đơn
if (cust != null)

{

    Console.WriteLine("Danh sách hóa đơn của khách hàng:");

    foreach (Order od in cust.Orders)

    {

        decimal money = od.Order_Details.Sum(odd => odd.Quantity * odd.UnitPrice - (decimal)odd.Discount * odd.Quantity * odd.UnitPrice);

        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy") + "\t" + money);

    }

}
