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
Console.WriteLine("đppỏ tên , vậy s1 có tên là gì");
Console.WriteLine(s1.Name); //nguyễn thị lung linh
                            //(2) ô nhớ lúc trước s1 đang quản lý gườ k còn đối tượng nào quản lý
                            //thif này HĐH tự đọng thu hồi ô nhớ : Autimatic Garbage Collection
                            //tức là ta k thể truy suất để lấy lại giá trị s1 có d =1 , name tèo