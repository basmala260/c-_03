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

            #region ass2_question4
            string yearText = "2023";
            int int_year = int.Parse(yearText);
            string badText = "abc";
            bool check= int.TryParse(badText,out int result);
            if (check){
                Console.WriteLine("valid number");
            }else{
                Console.WriteLine("invalid number");
            }
            #endregion
        }
    }
}
