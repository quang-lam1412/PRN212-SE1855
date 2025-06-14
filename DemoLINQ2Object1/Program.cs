using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
/*
 câu 1 lọc ra các số chẵn

 */
//cách 1 : dùng Extension Method  - Method Syntax
var ar_chan = arr.Where(x => x % 2 == 0);
Console.WriteLine("Các số chẳn mà dùng method syntax: ");
ar_chan.ToList().ForEach(x => Console.WriteLine(x + " "));
//cách 2 : dùng Extension Method - Query Syntax
var ar_chan2 = from x in arr
               where x % 2 == 0
               select x;
Console.WriteLine("Các số chẳn mà dùng query syntax: ");
ar_chan2.ToList().ForEach(x => Console.Write(x + " "));
/*câu 2 tăng các phần tử lẻ lên 2 đơn vị*/
var arr2 = arr.Where(x =>x % 2 != 0).Select(x => x+2);
Console.WriteLine("\nDữ liệu gốc");
foreach (var x in arr)
{
    Console.Write(x+"\t");
    Console.Write("");
}
foreach (var x in arr2)
    Console.WriteLine(x+"\t");


/*câu 3: sắp xeepps các phần tử tăng dần:*/

var arr4 =arr.OrderBy(x => x);
var arr5 = from x in arr
           orderby x
           select x;
Console.WriteLine("\nDữ liệu sắp xếp tăng dần");
foreach (var x in arr5)
{
    Console.Write(x + "\t");
}
/*câu 3: sắp xeepps các phần tử tăng dần:*/

var arr6 = arr.OrderByDescending(x => x);
var arr7 = from x in arr
           orderby x descending
           select x;
/*câu 3: sắp xeepps các phần tử tăng dần:*/

var arr = arr.OrderBy(x => x);
var arr = from x in arr
           orderby x
           select x;
Console.WriteLine("\nDữ liệu sắp xếp tăng dần");
foreach (var x in arr5)
{
    Console.Write(x + "\t");
}

Console.WriteLine($"odd number is {arr.Where(x => x % 2 != 0).Count()}");
int sole = (from x in arr
            where x % 2 != 0
            select x).Count();
Console.WriteLine($"odd number is {sole}");

