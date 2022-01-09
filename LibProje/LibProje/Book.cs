using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibProje
{
    class Book
    {
        public static int Total = 0;
        public Book(string name, string authorname, int pagecount)
        {
            Total++;
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            Code = Name.ToUpper().Substring(0, 2)+Total;
            
        }
        public string Code;
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (CheckName(value))
                {
                    _name = value;
                }
                else
                {
                    _name = null;
                }
            }
        }
        private string _authorName;
        public string AuthorName
        {
            get
            {
                return _authorName;
            }
            set
            {
                if (CheckName(value))
                {
                    _authorName = value;
                }
                else
                {
                    _authorName = null;
                }
            }
        }
        private double _pageCount;
        public double PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                if (value >= 1)
                {
                    _pageCount = value;
                }

            }
        }
        public bool CheckName(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                if (str.Length > 1)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return $"         Name: {Name}\n " +
                $"        Code: {Code}\n " +
                $" Author Name: {AuthorName}\n " +
                $"  Page Count: {PageCount}\n ";

        }
    }
}
