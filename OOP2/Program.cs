using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

FullTimeEmployee Akira = new FullTimeEmployee();
{
    Akira.Id = 1;
    Akira.IdCard = "123";
    Akira.Name = "Akira";
    Akira.Birthday = new DateTime(1996, 11, 24);

}
Console.WriteLine($"Thông tin nhân viên {Akira.Name}:");
Console.WriteLine($"Lương của nhân viên {Akira.Name} là: " +
    $"{Akira.calSalary()},Id là: {Akira.Id},Id card là: " +
    $"{Akira.IdCard}, năm sinh là {Akira.Birthday}");

Employee trump = new Employee
{
    Id = 1,
    Birthday = new DateTime(1996, 11, 24),
    Name = "obama",
    IdCard = "1234"
};
Console.WriteLine($"Thông tin nhân viên {trump.Name}:");
Console.WriteLine($"Lương của nhân viên {trump.Name} là: " +
    $"{trump.calSalary()},Id là: {trump.Id},Id card là: " +
    $"{trump.IdCard}, năm sinh là {trump.Birthday}");

Console.WriteLine(trump.ToString());