using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
  public   class Kitab 
    {
        public string bookname;
        public string writer;
        public int page;
        public Kitab( string bookName)
        {
            this.bookname = bookName;  
        }
        public Kitab( int page,string writer)
        {
            this.page = page;
            this.writer = writer;   
        } 
     public void  Getbookname()
        {
            Console.WriteLine($"Bookname{bookname}");
        }
    } 
}
