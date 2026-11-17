using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace c__03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #region ass2_question1
            //int pages = 300;
            //double updated_pages = pages;
            //#endregion

            //#region ass2_question2
            //double price = 49.99;
            //int int_price = (int)price;
            //#endregion

            //#region ass2_question3
            //string text = "464";
            //int int_text = Convert.ToInt32(text);
            //#endregion

            //#region ass2_question4
            //string yearText = "2023";
            //int int_year = int.Parse(yearText);
            //string badText = "abc";
            //bool check= int.TryParse(badText,out int result);
            //if (check){
            //    Console.WriteLine("valid number");
            //}else{
            //    Console.WriteLine("invalid number");
            //}
            //#endregion

            //#region ass2_question5
            //int pages = 464;
            //string string_pages = pages.ToString();
            //Console.WriteLine("type:" + string_pages.GetType());
            //#endregion

            //#region ass2_question5
            //int copies = 100;
            //object obj_copies = copies;
            //Console.WriteLine("boxing:" + obj_copies);
            //int int_copies = (int)obj_copies;
            //Console.WriteLine("unboxing" + int_copies);
            //#endregion

            //#region ass2_question7
            //int?year=null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year);
            //#endregion

            //#region ass2_question8
            //string? reviewer = null;
            //bool hasnot_value = reviewer==null;
            //if (hasnot_value) {
            //    Console.WriteLine("null");
            //        }
            //#endregion

            //#region ass2_question9
            //Book? book = null;
            //Console.WriteLine(book.title);
            //#endregion

            //#region ass2_question10
            //Book? book = null;
            //Console.WriteLine(book?.title ?? "Untitled");
            //book.title ??= "Untitled";
            //#endregion

            //#region ass2_question11
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //#endregion

            //#region ass3_question1
            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("long book");
            //}
            //else
            //{
            //    Console.WriteLine("short book");
            //}
            //#endregion

            //#region ass3_question2
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("you can borrow the book");
            //}
            //#endregion

            //#region ass3_question3
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "CleanCode":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //    Console.WriteLine("Never heard of it");
            //        break;
            //}
            //#endregion

            //#region ass3_question4
            //int pages = 464;
            //string statement = (pages > 300) ? "long book" : "short book";
            //#endregion
            #region ass3_question5
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
               for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}:{books[i]}");
            }
            #endregion






        }
    }
}
