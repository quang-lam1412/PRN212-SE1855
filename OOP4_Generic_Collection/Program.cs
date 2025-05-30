using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;
/*sử dụng generiic list để quản lý nhân sự
 thực hiện đầy đủ tính năng crud
c tạo thêm mới nhân sự
r reas/retrueve đọc truy vấn tìm kiếm sắp xếp
u update-> chỉnh sửa dữ liễu
d delete ->xóa dữ liệu*/

/*
 câu 1 c tạo
dùng list để tạo 5 employee trong đo 4 employee là chính thức 
và 1 e1 employee là thời vụ*/
List<Employee> employees = new List<Employee>();
FullTimeEmployee e1 = new FullTimeEmployee
{
    Id = 1,
    IdCard = "123456789",
    Name = "Nguyễn Văn A",
    Birthday = new DateTime(1990, 1, 1)

};
employees.Add(e1);
FullTimeEmployee e2 = new FullTimeEmployee();
e2.Id = 2;
e2.IdCard = "123456789";
e2.Name = "Nguyễn Văn B";
e2.Birthday = new DateTime(1991, 2, 2);
employees.Add(e2);
FullTimeEmployee e3 = new FullTimeEmployee
    {
        Id = 3,
        IdCard = "123456789",
        Name = "Nguyễn Văn C",
        Birthday = new DateTime(1992, 3, 3)
    };
employees.Add(e3);
FullTimeEmployee e4 = new FullTimeEmployee();
e4.Id = 4;
e4.IdCard = "123456789";
e4.Name = "Nguyễn Văn D";
e4.Birthday = new DateTime(1993, 4, 4);
    employees.Add(e4);
ParttimeEmployee e5 = new ParttimeEmployee
{
    Id = 5,
    IdCard = "123456789",
    Name = "Nguyễn Văn E",
    Birthday = new DateTime(1994, 5, 5)
};
employees.Add(e5);
//câu 2 R->xuất toàn bộ nhận sự
Console.WriteLine("Danh sách nhân sự ===> cách 1");
employees.ForEach(e =>
{
    Console.WriteLine(e);
});
Console.WriteLine("Danh sách nhân sự ===> cách 2");
foreach (var employee in employees)
{
    Console.WriteLine(employee);
}
//câu 3 lọc ra nhân sự chính thức và tính tổng lương
//cách 1: dùng các extension method của hệ thống 
List<FullTimeEmployee> fe_list = employees.OfType<FullTimeEmployee>().ToList();
Console.WriteLine("Danh sách nhân sự chính thức ===> cách 1");
fe_list.ForEach(e =>
{
    Console.WriteLine(e);
}); 
//cách 2 dùng cách thông thường
List<FullTimeEmployee> fe_list2 = new List<FullTimeEmployee>();
foreach (var e in employees)
{
    if (e is FullTimeEmployee)
    {
        fe_list2.Add((FullTimeEmployee)e);
    }
}
Console.WriteLine("Danh sách nhân sự chính thức ===> cách 2");
fe_list2.ForEach(e =>
{
    Console.WriteLine(e);
});
//tổng lương:
double sum_salary = fe_list2.Sum(e=> e.calSalary());
Console.WriteLine($"Tổng lương của nhân sự chính thức là: {sum_salary}");
//câu 4 : sắp xéo danh sách nhan sự theo ngày tháng năm sinh
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Birthday>ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }
    }
}
Console.WriteLine("Danh sách nhân sự sau khi sắp xếp theo ngày tháng năm sinh:");
employees.ForEach(e =>
{
    Console.WriteLine(e);
});
//sửa và xóa
Console.OutputEncoding = Encoding.UTF8;
//Câu 4 : R-> sấp xếp danh sách nhân sự theo ngày tháng năm sinh
#region Sort employees by birth date
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i + 1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Birthday > ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
             
        }
    }
}
Console.WriteLine("Danh sách nhân sự sắp xếp theo ngày tháng năm sinh:");
employees.ForEach(e => Console.WriteLine(e));
#endregion
// bổ sung sửa và xóa
Console.OutputEncoding = Encoding.UTF8;
// Câu 5: U - Update -> chỉnh sửa thông tin nhân sự
#region Update employee
int id;
Employee? emp = null;  
do
{
    Console.WriteLine("Nhập Id nhân sự cần chỉnh sửa:");
    if (!int.TryParse(Console.ReadLine(), out id) || id < 1 || id > employees.Count)
    {
        Console.WriteLine("Id không hợp lệ, vui lòng nhập lại!");
        continue;
    }



} while (id < 1 || id > employees.Count);

foreach (var e in employees)
{
    if (e.Id == id)  
    {
        emp = e;  
        break;    
    }
}

if (emp != null)
{
    Console.WriteLine("Nhập tên mới cho nhân sự: ");
    emp.Name = Console.ReadLine();
    Console.WriteLine("Nhập IdCard mới cho nhân sự: ");
    emp.IdCard = Console.ReadLine();
    Console.WriteLine("Nhập ngày tháng năm sinh mới cho nhân sự (dd/MM/yyyy): ");
    emp.Birthday = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", null);
    Console.WriteLine("Thông tin của Nhân sự sau khi được chỉnh sửa: ");
    Console.WriteLine(emp);
}
else
{
    Console.WriteLine($"Không tìm thấy nhân sự với Id {id} đã nhập.");
}
Console.WriteLine("Danh sách nhân sự sau khi chỉnh sửa:");
employees.ForEach(e => Console.WriteLine(e));
#endregion
// Câu 6: D - Delete -> Xóa nhân sự
#region Delete employee


do
{
    Console.WriteLine("Nhập Id nhân sự cần xóa:");
    if (!int.TryParse(Console.ReadLine(), out id) || id < 1 || id > employees.Count)
    {
        Console.WriteLine("Id không hợp lệ, vui lòng nhập lại!");
        continue;
    }



} while (id < 1 || id > employees.Count);

emp = null;
foreach (var e in employees)
{
    if (e.Id == id)
    {
        emp = e;
        break;
    }
}
if (emp != null)
{
    employees.Remove(emp);
    Console.WriteLine($"Đã xóa nhân sự với Id {id}.");
}
else
{
    Console.WriteLine($"Không tìm thấy nhân sự với Id {id} đã nhập.");
}
Console.WriteLine("Danh sách nhân sự sau khi xóa:");
employees.ForEach(e => Console.WriteLine(e));
#endregion
