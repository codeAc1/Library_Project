using System;

namespace LibProje
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LibManager lib = new LibManager();
            

            do
            {
                Console.WriteLine("-------------------------Kitabxana idare edilmesi sistemi---------------------------");
                Console.WriteLine("Etmek Isdediyniz Emeliyyatin Qarsisindaki Nomreni Daxil Edin:");
                Console.WriteLine("1 - Add Book:");
                Console.WriteLine("2 - Show All Books:");
                Console.WriteLine("3 - Find All Books By Name:");
                Console.WriteLine("4 - Remove All Book ByName:");
                Console.WriteLine("5 - Search Books:");
                Console.WriteLine("6 - Find All Books By Page Count Range");
                Console.WriteLine("7 - RemoveByNo:");
                Console.WriteLine("8 - ADD Ready Book list:");
                Console.WriteLine("9 - Exit System:");

                Console.Write("Daxil Et:");
                string choose = Console.ReadLine();
                int chooseNum;
                int.TryParse(choose, out chooseNum);
                switch (chooseNum)
                {
                    case 1:
                        Console.Clear();
                        AddBook(lib);
                        break;
                    case 2:
                        Console.Clear();
                        ShowAllBooks(lib);
                        break;
                    case 3:
                        Console.Clear();
                        ShowAllBooksByName(lib);
                        break;
                    case 4:
                        Console.Clear();
                        RemoveAllBooksByName(lib);

                        break;
                    case 5:
                        Console.Clear();
                        SearchBooks(lib);
                        break;
                    case 6:
                        Console.Clear();
                        ShowAllBooksByPageCountRange(lib);
                        break;
                    case 7:
                        Console.Clear();
                        RemoveBookByNo(lib);
                        break;
                    case 8:
                        Console.Clear();
                        AddList(lib);
                        break;
                    case 9:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Duzgun Daxil Et");
                        break;
                }

            } while (true);

        }
        static void AddBook(LibManager lib)
        {
            Console.Write("Kitabin adini daxil edin: ");
            string bookname = Console.ReadLine();
            Console.Write("Muellifin adini daxil edin: ");
            string authorname = Console.ReadLine();
            Console.Write("Sehife sayini daxil edin: ");
            int pagecount = int.Parse(Console.ReadLine());

            lib.AddBook(bookname, authorname, pagecount);
        }
        static void ShowAllBooks(LibManager lib)
        {
            Console.WriteLine("\n************Kitabxanada olan butun Kitablar************\n");
            lib.ShowAllBooks();
        }
        static void ShowAllBooksByName(LibManager lib)
        {
            if (lib.Books.Count > 0)
            {
                string str;
                bool check = true;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("Kitabin adina uygun Axtaris etmek istediyiniz acar sozu daxil edin:");
                    }
                    else
                    {
                        Console.WriteLine("Axtarilan Acar soze Uygun kitab tapilmadi\nYeniden daxil et");
                    }
                    str = Console.ReadLine();
                    check = false;

                } while (!lib.CheckAllBooksByName(str));
                
                Console.WriteLine("\nDaxil edilen Acar soze uygun olan Kitablar\n");
                lib.ShowAllBooksByName(str);
            }
            else
            {
                Console.WriteLine("Kitabxanada kitab yoxdur");
            }
        }
        static void RemoveAllBooksByName(LibManager lib)
        {
            if (lib.Books.Count > 0)
            {
                string str;
                bool check = true;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("Silmek istediyiniz Kitablarin adina uygun acar sozu daxil edin:");
                    }
                    else
                    {
                        Console.WriteLine("Axtarilan Acar soze Uygun kitab tapilmadi\nYeniden daxil et");
                    }
                    str = Console.ReadLine();
                    check = false;

                } while (!lib.CheckAllBooksByName(str));

                Console.WriteLine("\nKitab adinda axtarilan Acar soze uygun olan Kitablar\n");
                lib.ShowAllBooksByName(str);
                Console.WriteLine("\nYuxaridaki kitablar silindi\n");
                lib.RemoveAllBookByName(str);
                return;
                
            }
            else
            {
                Console.WriteLine("Kitabxanada kitab yoxdur");
            }
        }
        static void SearchBooks(LibManager lib)
        {
            if (lib.Books.Count > 0)
            {
                string str;
                bool check = true;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("Axtaris Ucun Acar sozu daxil edin:");
                    }
                    else
                    {
                        Console.WriteLine("Axtarilan Acar soze Uygun kitab tapilmadi\nYeniden daxil et");
                    }
                    str = Console.ReadLine();
                    check = false;

                } while (!lib.CheckAllBooksByString(str));

                Console.WriteLine("\nDaxil edilen Acar soze uygun olan Kitablar\n");
                lib.SearchAllBooksByString(str);
            }
            else
            {
                Console.WriteLine("Kitabxanada kitab yoxdur");
            }
        }
        static void ShowAllBooksByPageCountRange(LibManager lib)
        {
            if (lib.Books.Count > 0)
            {
                int startPage;
                int endPage;
                bool check = false;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("Axtarilan sehife araliqina uygun kitab yoxudur \nYeniden daxil et\n");
                    }
                    Console.Write("Baslangic sehfeni daxil edin:");
                    startPage = int.Parse(Console.ReadLine());
                    Console.Write("Son sehfeni daxil edin:");
                    endPage = int.Parse(Console.ReadLine());
                    check = true;

                } while (!lib.CheckAllBooksByPageRange(startPage,endPage));

                Console.WriteLine("\nDaxil edilen sehife Araliqina uygun olan Kitablar\n");
                lib.ShowAllBooksByPageInterval(startPage, endPage);

            }
            else
            {
                Console.WriteLine("Kitabxanada kitab yoxdur");
            }
        }
        static void RemoveBookByNo(LibManager lib)
        {


            if (lib.Books.Count > 0)
            {
                lib.ShowAllBooks();
                string str;
                bool check = true;
                do
                {
                    if (check)
                    {
                        Console.Write("Silmek istediyiniz Kitabin Nomresini daxil edin:");
                    }
                    else
                    {
                        Console.Write("Daxil edilen Nomreye Uygun kitab tapilmadi\nYeniden daxil et");
                    }
                    str = Console.ReadLine();
                    check = false;

                } while (!lib.CheckBooksByNo(str));

                Console.WriteLine($"\n{str.ToUpper()}-Nomreli kitab silindi\n");
                lib.RemoveByNo(str);

            }
            else
            {
                Console.WriteLine("Kitabxanada kitab yoxdur");
            }
        }
        static void AddList(LibManager lib)
        {
            
            lib.Books.Add(new Book("Atropatena", "Abdulla Fazili", 216));
            lib.Books.Add(new Book("Atropatenaaaa", "Abdulla Fazili", 216));
            lib.Books.Add(new Book("Kengerler", "Altay Memmedov", 132));
            lib.Books.Add(new Book("Kengerlerrrrr", "Altay Memmedov", 132));
            lib.Books.Add(new Book("Nino", "Kurban Said", 216));
            lib.Books.Add(new Book("Ninooooo", "Kurban Said", 216));
            
        }



    }
}
