using System.Text;
using OOP2;
using OOP2_Reuse_As_Library;

Console.OutputEncoding = Encoding.UTF8;
FullTimeEmployee e1 = new FullTimeEmployee
{
    Id = 1,
    IdCard = "123456789",
    Name = "Nguyễn Văn A",
    Birthday = new DateTime(1990, 1, 1)
};
Console.WriteLine("---Thông tin của E1");
Console.WriteLine(e1);
Console.WriteLine("==>AGE="+e1.TinhTuoi());