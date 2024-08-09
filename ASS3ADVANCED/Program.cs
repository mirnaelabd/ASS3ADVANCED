namespace ASS3ADVANCED
{
    internal class Program
    {
        public
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("978-1234567890", "C# Programming", new string[] { "John Doe", "Jane Smith" }, new DateTime(2024, 1, 1), 29.99m),
                new Book("978-0987654321", "Learning .NET", new string[] { "Alice Johnson" }, new DateTime(2023, 6, 15), 39.99m)
            };


            // by built in : 
            LibarayEngine.ProcessBooks2(books, BookFunction.GetTitle);
            //
            Func<Book, string> getAuthors = BookFunction.GetAuthors;
            LibarayEngine.ProcessBooks2(books, getAuthors);
            /////////////////////////////////////////////////////////////////////////////
            //by user defiend delagte
            BookFunctionDelegate c = BookFunction.GetTitle;
            LibarayEngine.ProcessBooks(books, c);

            ////////////////Anonymous Method (GetISBN)./////////////////////
            Func<Book, string> getISBN = delegate (Book b) { return b.ISBN; };
            //////////////////Lambda //////////////////////////////////////
            Func<Book, string> getdate =  b =>  b.PublicationDate.ToString();

        }
    }
}
