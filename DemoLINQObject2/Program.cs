using System.Text;
using DemoLINQObject2;

Console.OutputEncoding = Encoding.UTF8;

ListProduct lp = new ListProduct();
lp.gen_products();
//Câu 1 : lọc ra các sản phẩm có giá từ a tới b
//sử dungh Method Syntax   và Query Syntax
var result1 = lp.FilterProductsByPrice(200, 300);
Console.WriteLine("Danh sách sản phẩm có giá từ 200-300");
result1.ForEach(p => Console.WriteLine(p));

//câu 2 săp xếp các sản phẩm theo đơn giá giảm dần
var result2 = lp.SortProductByPriceDec2();
Console.WriteLine("Danh sách sản phẩm sau khi sắp xếp");
result2.ForEach(p => Console.WriteLine(p));

//câu 3 tính tổng giá trị sản phẩm trong kho hàng
//var totalVaue = lp.TotalValueOfProducts();
//Console.WriteLine($"Tổng giá trị ");