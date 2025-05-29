using System.Text;
using OOP1;

Console.OutputEncoding = Encoding.UTF8;
//tạo đối tượng danh mục
Category c1 = new Category();
//new là xin cấp phát ô nhớ, c1 là quản lý ô nhớ vừa đc cấp phát
//gán giá trị cho các thuộc tính:
c1.Id = 1;
c1.Name = "Nước Mắm";

//gọi hàm xuất dữ liệu
c1.PrintInfo();

// khởi tạo đối tượng nhân viên
Employee e1 = new Employee();
e1.Id = 1;//gọi sêtter Property Id
e1.id_card = "123456789";//goi setter Property id_card
e1.name = "Nguyễn Văn A";//gọi setter Property name
e1.email = "a@gmail.com";//gọi setter Property email
e1.phone = "0123456789";//gọi setter Property phone
                        //gọi hàm xuất dữ liệu
                        e1.PrintInfo();
//ta có thể truy suất theo theo từng Property để lấy giá trị của thuộc tính:
Console.WriteLine("==================================");
Console.WriteLine($"Id: {e1.Id}");//gọi getter Property Id
Console.WriteLine($"Name: {e1.name}");//gọi getter Property name

//ta cũng co thể khởi tạo đối tương và các giá trị của thuốc tính như sau
Employee e2 = new Employee()
{
    Id = 2,
    id_card = "987654321",
    name = "Nguyễn Văn B",
    email="b@gmail.com",
    phone = "0987654321"
};
Console.WriteLine("--------E2----------");
e2.PrintInfo();


Console.WriteLine("--------E3----------");
Employee e3 = new Employee(3, "1412", "hihi", "hihi@gmail.com", "0246182764238");
//gọi hàm xuất thông tin
Console.WriteLine(e3);
//hoặc tự động gọi toString khi đói tượng đc xuât ra

//thử thử contructor không đối số
Employee e4 = new Employee();
Console.WriteLine("--------E4----------");
//tạo đối tượng khách hàng
Customer c2 = new Customer()
{
    Id = 3,
    Name = "Nguyễn Văn C",
    Email = "C@gmail.com",
    Phone = "0123456789",
    Address = "Hồ Chí Minh"
};
c2.PrintInfo();
c2.Address = "Hà Nội";
c2.Phone = "0987654321";
Console.WriteLine("thay đổi địa chỉ và số điện thoại");
c2.PrintInfo();