using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS3ADVANCED
{
   // by user defined deleagte
    public delegate string BookFunctionDelegate(Book b);
    public class BookFunction
    {
        public static string GetTitle (Book b)
        {

        return b.ISBN.ToString ();
        }
        public static string GetAuthors(Book b)
        {

            return b.Authors.ToString();
        }
        public static string GetPrice(Book b)
        {

            return b.Price.ToString();
        }
    }

    
}
