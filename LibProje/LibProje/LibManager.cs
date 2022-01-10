using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibProje
{
    class LibManager
    {
        public List<Book> Books = new List<Book>(0);
        #region Icraci Metodlar
        public void AddBook(string name, string authorname, int pageCount)
        {
            Books.Add(new Book(name, authorname, pageCount));
        }
        public void ShowAllBooks()
        {
            if (Books.Count > 0)
            {
                foreach (Book item in Books)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Kitabxanada Kitab yoxdur");
            }
        }
        public void ShowAllBooksByName(string str)
        {
            var result = Books.FindAll(x => x.Name.ToUpper().Contains(str.ToUpper()));
            foreach (var item in result)
            {
               Console.WriteLine(item);
            }
        }
        
        public void RemoveAllBookByName(string str)
        {
            var result = Books.FindAll(x => x.Name.ToUpper().Contains(str.ToUpper()));
            foreach (var item in result)
            {
                Books.Remove(item);
            }
        }
        public void ShowAllBooksByPageInterval(int startPage, int endPage)
        {
            var result = Books.FindAll(x => x.PageCount >= startPage && x.PageCount <= endPage);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchAllBooksByString(string str)
        {
            var result = Books.FindAll(x => x.Name.ToUpper().Contains(str.ToUpper()) || x.AuthorName.ToUpper().Contains(str.ToUpper()) || x.PageCount.ToString() == str);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public void RemoveByNo(string str)
        {
            var result = Books.FindAll(x => x.Code.ToUpper() == str.ToUpper());
            foreach (var item in result)
            {
                Books.Remove(item);
            }
        }

        #endregion

        #region Yoxlama metodlari
        public bool CheckAllBooksByString(string str)
        {
            if (Books.Exists(x => x.Name.ToUpper().Contains(str.ToUpper()) || x.AuthorName.ToUpper().Contains(str.ToUpper()) || x.PageCount.ToString() == str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckAllBooksByName(string str)
        {
            if (Books.Exists(x => x.Name.ToUpper().Contains(str.ToUpper())))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckAllBooksByPageRange(int startPage, int endPage)
        {
            if (Books.Exists(x => x.PageCount >= startPage && x.PageCount <= endPage))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckBooksByNo(string str)
        {
            if (Books.Exists(x => x.Code.ToUpper() == str.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion





    }
}
