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
            foreach (Book item in Books)
            {
                if (item.Name.ToUpper().Contains(str.ToUpper()))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void RemoveAllBookByName(string str)
        {         
            do
            {
                str1:
                foreach (Book item in Books)
                {
                    if (item.Name.ToUpper().Contains(str.ToUpper()))
                    {
                        Books.Remove(item);
                        goto str1;
                    }
                }
            } while (Books.Count <0);
            return;
        }
        public void ShowAllBooksByPageInterval(int startPage, int endPage)
        {
            foreach (Book item in Books)
            {
                if (item.PageCount >= startPage && item.PageCount <= endPage)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void SearchAllBooksByString(string str)
        {
            foreach (Book item in Books)
            {
                if (item.Name.ToUpper().Contains(str.ToUpper()) || item.AuthorName.ToUpper().Contains(str.ToUpper()) || item.PageCount.ToString() == str)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void RemoveByNo(string str)
        {
            strt1:
            if (Books.Count > 0)
            {
                foreach (Book item in Books)
                {
                    if (item.Code.ToUpper() == str.ToUpper())
                    {
                        Books.Remove(item);
                        goto strt1;
                    }
                }
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
