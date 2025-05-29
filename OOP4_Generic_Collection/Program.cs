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
foreach (var emp in employees)
{
    Console.WriteLine(emp);
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