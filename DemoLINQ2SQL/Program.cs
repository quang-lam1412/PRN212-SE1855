using System.Text;
using DemoLINQ2SQL;

Console.OutputEncoding = Encoding.UTF8;

string connectionString = @"server=LAPTOP-BM436BGS\PIEDTEAM;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//câu 1: truy vấn toàn bộ danh mục 
var dsdm = context.Categories.ToList();
Console.WriteLine("Danh sách danh mục");
dsdm.ForEach(x => 
Console.WriteLine(x.CategoryID+"\t"+x.CategoryName));

//câu 2: dùng query syntax để lọc ra toàn bộ sản phẩm
// Câu 2 Dùng querySyntax để lọc ra toàn bộ sp
// lấy hết

var dsp = from p in context.Products
          select p;
Console.WriteLine("List of Products");
foreach (var p in dsp)
{
    Console.WriteLine($"{p.ProductID}\t{p.ProductName}\t{p.UnitPrice}\t{p.UnitsInStock}");
}

//Câu 3: Tìm danh mục khi biết mã danh mục
int categoryid = 3;
Category cate = context.Categories.FirstOrDefault(c => c.CategoryID == categoryid);
if (cate == null)
{
    Console.WriteLine($"Can't find Category ID");
}
else
{
    Console.WriteLine($"CategoryID found :{categoryid}");
    Console.WriteLine(cate.CategoryID + "\t" + cate.CategoryName);
}
//câu 4: lọc ra top 3 sản phẩm có giá lớn nhất
var dssptop3 = context.Products.OrderByDescending(p => p.UnitPrice).Take(3);
foreach (var p in dssptop3)
{
    Console.WriteLine($"{p.ProductID}\t{p.ProductName}\t{p.UnitPrice}\t{p.UnitsInStock}");
}
////câu 5: thêm mới 1 danh mục
//Category c1 = new Category();
//c1.CategoryName = "Hàng điện tử";
//context.Categories.InsertOnSubmit(c1);
//context.SubmitChanges();

//câu 6  sửa tên danh mục 
//bước 1: timfdanh mục
//bước 2: tìm thấy thì sửa
//Category c11 = context.Categories.FirstOrDefault(c => c.CategoryID == 11);
//if (c11 == null)
//{
//    c11.CategoryName = "Hàng gia dụng";
//    context.SubmitChanges();
//}
//câu 7 : xóa danh mục khi biết mã danh mục
//Category c12 = context.Categories.FirstOrDefault(c => c.CategoryID == 11);
//if (c11 != null)
//{
//    context.Categories.DeleteOnSubmit(c11);
//    context.SubmitChanges();
//}//câu 8: cóa tất cả danh mục chưa có bất kỳ sản phẩm nào
//var dssp_empty_product = context.Categories
//    .Where(c => c.Products.Count == 0).ToList();
//context.Categories.DeleteAllOnSubmit(dssp_empty_product);
//context.SubmitChanges();
//câu 9: thêm nhiều daanh mục cùng 1 lúc\
List<Category> list_cate = new List<Category>();
list_cate.Add(new Category { CategoryName = "Gundam Universe Cosmic" });
list_cate.Add(new Category { CategoryName = "Gundam Cosmic Era" });
list_cate.Add(new Category { CategoryName = "Gundam AD" });
list_cate.Add(new Category { CategoryName = "Gundam Calamity Era" });
context.Categories.InsertAllOnSubmit(list_cate);
context.SubmitChanges();