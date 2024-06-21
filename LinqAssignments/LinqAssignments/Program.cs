using System.Net.Http.Headers;
using System.Reflection.Metadata;

using static Day_01_G01.ListGenerator;
namespace LinqAssignments
{
    class CustomComperar : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filteration or Restiriction
            #region products that are out of stock.
            //var Result = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  products that are in stock and cost more than 3.00 per unit
            //var Result = ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region MyRegion

            #endregion

            #region digits whose name is shorter than their value
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where((W, index) => W.Length < index);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Ordering Operators
            #region list of products by name
            //var Result = ProductList.OrderBy(p => p.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(w => w, new CustomeWordSort());
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region products by units in stock from highest to lowest.
            //var Result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.OrderBy(w => w.Length).ThenBy(w => w);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Reault=words.OrderBy(w=>w.Length).ThenBy(w=>w,new CustomeWordSort());
            //var Reault2 = words.OrderBy(w => w.Length).ThenBy(w => w, new CustomComperar());

            //foreach (var item in Reault)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            //foreach (var item in Reault2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var Result = ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, new CustomeWordSort());
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where(W => W.IndexOf("i") == 1).Reverse();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Transformation Operators

            #region  Return a sequence of just the names of a list of products.
            //var Result = ProductList.Select(p => p.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var Result = words.Select(w => new { uppercase = w.ToUpper(), lowercase = w.ToLower() });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Select((num, index) => $"{num}:{num == index}");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { a, b };
            //Result = numbersA.SelectMany(n => numbersB, (a, b) => new { a, b }).Where(num => num.a < num.b);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.a} is less than {item.b}");
            //}
            #endregion

            #region Select all orders where the order total is less than 500.00.
            //var Result = CustomerList.SelectMany(C => C.Orders).Where(O => O.Total < 500);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Select all orders where the order was made in 1998 or later
            // var Result=CustomerList.SelectMany(C => C.Orders).Where(O=>O.OrderDate >= new DateTime(1998,1,1,0,0,0));
            //foreach(var O in Result)
            //{
            //    Console.WriteLine(O);
            //}
            #endregion
            #endregion

        }
    }
}
