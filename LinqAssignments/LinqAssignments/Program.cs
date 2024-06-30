using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using static Day_01_G01.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
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

            #region Element Operators
            #region Get first Product out of Stock 
            //var Result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(Result);
            #endregion

            #region  first product whose Price > 1000, unless there is no match, in which case null is returned 
            //var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(Result);
            #endregion

            #region Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var NumbersGreaterthan5=Arr.Where(num=>num > 5).OrderBy(num=>num);
            //var Result=NumbersGreaterthan5.ElementAt(1);
            //Console.WriteLine(Result);
            #endregion


            #endregion

            #region Aggregate Operators

            #region  Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = Arr.Count(num => num % 2 != 0);
            //Console.WriteLine(Result);
            #endregion

            #region list of customers and how many orders each has.
            //var Result = CustomerList.Select(c => new { cutomre=c, totalOreders=c.Orders.Count() });
            //foreach (var item in Result) {
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Return a list of categories and how many products each has
            //    var Result=ProductList.GroupBy(p=>p.Category).Select(c=>new {category = c.Key ,countProducts= c.Count() });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result=Arr.Sum();
            //Console.WriteLine(Result);
            #endregion

            #region Get the total number of characters of all words in dictionary_english.txt 
            //var Result = EnglishDictionary.Sum(w => w.Length);
            //Console.WriteLine(Result);
            #endregion

            #region  Get the length of the shortest word in dictionary_english.txt
            //var Result = EnglishDictionary.MinBy(w => w.Length);
            //Console.WriteLine(Result.length);
            #endregion

            #region Get the length of the longest word in dictionary_english.txt
            //var Result = EnglishDictionary.MaxBy(w => w.Length);
            //Console.WriteLine(Result.Length);
            #endregion

            #region Get the average length of the words in dictionary_english.txt
            //var Result = EnglishDictionary.Average(w => w.Length);
            //Console.WriteLine(Result);
            #endregion

            #region Get the total units in stock for each product category.
            //var Resulr = ProductList.GroupBy(p => p.Category)
            //                       .Select(c => new { category=c.Key , totalUnites = c.Sum(c=>c.UnitsInStock)});
            //foreach (var item in Resulr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the cheapest price among each category's products
            //var Result = ProductList.GroupBy(p => p.Category)
            //                       .Select(c => new { Category = c.Key, cheapestPrice = c.MinBy(p => p.UnitPrice).UnitPrice });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Get the products with the cheapest price in each category
            //var Result = from p in ProductList
            //             group p by p.Category
            //             into category
            //             select new
            //             {
            //                 category = category.Key,
            //                 cheapestPrice = category.MinBy(p => p.UnitPrice).UnitPrice
            //             };
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the most expensive price among each category's products.
            //var Result = ProductList.GroupBy(p => p.Category)
            //                    .Select(c => new { Category = c.Key, expensivePrice = c.MaxBy(p => p.UnitPrice).UnitPrice });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the products with the most expensive price in each category.
            //var Result = ProductList.GroupBy(p => p.Category)
            //                       .Select(C => new { Category = C.Key, MaxPriceProduct = C.MaxBy(p => p.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the average price of each category's products.
            //var Result = ProductList.GroupBy(p => p.Category)
            //                      .Select(c => new { Category = c.Key, AvgPrice = c.Average(p => p.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Set Operators
            #region  Find the unique Category names from Product List
            //var Result = ProductList.Select(p => p.Category).Distinct();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Produce a Sequence containing the unique first letter from both product and customer names
            //var Result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the common first letter from both product and customer names.
            //var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var Result = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length-3, 3)).Concat(CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length-3, 3)));
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion

            #region Partitioning Operators
            #region Get the first 3 orders from customers in Washington
            //var Result = CustomerList.Where(c => c.Region == "WA").SelectMany(c=>c.Orders).Take(3);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Get all but the first 2 orders from customers in Washington.
            //    var Result=CustomerList.Where(c=>c.Region == "WA").SelectMany(c=>c.Orders).Skip(2);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.TakeWhile((num, index) => num > index);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result = numbers.SkipWhile(num => num % 3 != 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var Result=numbers.SkipWhile((num,index) => num > index);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region Quantifiers
            #region Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //var Result = EnglishDictionary.Any(w => w.Contains("ei"));
            //Console.WriteLine(Result);
            #endregion

            #region Return a grouped a list of products only for categories that have at least one product that is out of stock.

            #endregion

            #region  Return a grouped a list of products only for categories that have all of their products in stock
            //var Result = ProductList.GroupBy(p => p.Category)
            //             .Where(c => c.All(p => p.UnitsInStock > 0))
            //             .Select(c=>c);


            //foreach (var category in Result)
            //{
            //    foreach (var item in category)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion

            #endregion

            #region  Grouping Operators

            #region Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            //var Result = numbers.GroupBy(num => num % 5)
            //                    .Select(remainder => remainder);
            //foreach (var remainder in Result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {remainder} when divided by 5 ");
            //    foreach (var number in remainder)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            #endregion

            #region Uses group by to partition a list of words by their first letter.
            //var Result = EnglishDictionary.GroupBy(w => w[0])
            //               .Select(l=>l);
            //foreach (var letter in Result)
            //{
            //    Console.WriteLine(letter);
            //    foreach (var word in letter)
            //    {
            //        Console.WriteLine(word);
            //    }
            //}

            #endregion

            #region Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            var Result = Arr.GroupBy(w => w.Trim(), new CustomeWordCompaere());
            foreach (var item in Result)
            {
               
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("-------");
            }
            #endregion
            #endregion

        }
    }
}
