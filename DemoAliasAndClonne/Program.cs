using System.Text;
using DemoAliasAndClone;
using DemoAliasAndClonne;

Console.OutputEncoding = Encoding.UTF8;
Student s1 = new Student();
s1.Id = 1;
s1.Name = "Trần Trọng Tiến";

Student s2 = new Student();
s1.Id = 2;
s1.Name = "Trần Trọng Tủn";


// lúc này trên thanh Ram sẽ cấp phát 2 ô nhớ
//cho s1 và s2 quản lý
//==> s1 đổi giá trị thì s2 không đổi
//vì s1 và s2 là 2 ô nhớ khác nhau
s1 = s2;
//ta viết lệnh : s1 = s2;
//truy nhieenn về bản chất nó hoạt động như SAU ;
//s1 trỏ tới vùng nhớ mà s2 đang quản lý
//chứ không phải là s1 = s2;
//có 2 tình huông xảy ra 
//(1) ô nhớ bên s2 giờ có thêm s1 quản lý ==> alias (>=2 đối tượng quản lý)
//chỉ cần 1 đối tượng đổi thì các đối tượng khác đều bị đổi
s2.Name = "nguyễn thị lung linh";
Console.WriteLine("đỏ tên , vậy s1 có tên là gì");
Console.WriteLine(s1.Name); //nguyễn thị lung linh
                            //(2) ô nhớ lúc trước s1 đang quản lý gườ k còn đối tượng nào quản lý
                            //thif này HĐH tự đọng thu hồi ô nhớ : Autimatic Garbage Collection

//tức là ta k thể truy suất để lấy lại giá trị s1 có d =1 , name tè

Product p1 = new Product()
{
    Id = 1,
    Name = "Laptop",
    Quantity = 10,
    Price = 1500
};
Product p2 = new Product()
{
    Id = 2,
    Name = "Smartphone",
    Quantity = 15,
    Price = 3000
};
p1 = p2;

p2.Name = "Thuốc trị hôi nách";
p2.Price = 80;


Console.WriteLine("Thong tin của p1: ");
Console.WriteLine(p1);

Product p3 = new Product()
{
    Id = 3,

    Name = "Bánh mì",

    Quantity = 100,

    Price = 5.5
};
Product p4 = new Product()
{
    Id = 4,
    Name = "Nước ngọt",
    Quantity = 50,
    Price = 1.5
};
Product p5 = p3; //p5 là alias của p3
p3 = p4; //p3 trỏ tới vùng nhớ mà p4 đang quản lý
//hỏi ô nhớ cấp phat cho p3 có bị thu hồi không vì sao

Product p6 = p4.clone();
//sao chép toàn bộ dữ liệu tring ô nhớ mà p4 đang quản lý 
//sang ô nhớ mới cà giao cho p6 quản lý
//lúc này không phải là alias vì p4 và p6 quản;ú 2 ô nhớ khác nhau
Console.WriteLine("dữ liệu của product 6:");
Console.WriteLine(p6);
Console.WriteLine("dữ lieu của Product 4:");
Console.WriteLine(p4);
p4.Name = "thuốc trị xàm";
Console.WriteLine("dữ liệu của product 6:");
Console.WriteLine(p6);
Console.WriteLine("dữ lieu của Product 4:");
Console.WriteLine(p4);