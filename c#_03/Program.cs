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

            #region ass2_question9
            Book? book = null;
            Console.WriteLine(book.title);
            #endregion




        }
    }
}
