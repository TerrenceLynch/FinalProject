using System;
using System.Collections.Generic;


class Author : Person
{
  private List<Book> BookList = new List<Book>();

  public Author() : base()
  {}

  public Author(string fname, string lname) : base(fname, lname)
  {}

  public void DisplayInfo()
  {
    Console.WriteLine("Firstname:" + FirstName);
    Console.WriteLine("Lastname:" + LastName);
    Console.WriteLine("Email:" + Email);
  }

  public void DisplayBooks()
  {
    foreach(Book book in BookList)
    { 
     book.Display();
    }
  }

  public void AddBook(Book b)
  {
    BookList.Add(b);
    b.AuthorInfo = FirstName + " " + LastName;
    Console.WriteLine("Book Added"); 
  } 

  public void RemoveBook(string isbn)
  {
    Book b = BookList.Find(x => x.ISBN == isbn);
    BookList.Remove(b);
    Console.WriteLine("Book Removed");
  }




}