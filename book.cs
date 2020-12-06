using System;

 public class Book 
 {

   public string ISBN { get; set; }
   public string Title { get; set; }
   public string AuthorInfo { get; set; }
   public DateTime PublishedOn { get; set; }
   public string PublishedBy { get; set; }

  public Book(string isbn, string title, string authorinfo) : this(isbn, title, authorinfo, DateTime.Today, "Unknown")
  {
    Console.WriteLine("Book Created (3 Constructors)");
  }

  public Book(string isbn, string title, string authorinfo, DateTime publishedon, string publishedby)
  {
    ISBN = isbn;
    Title = title;
    AuthorInfo = authorinfo;
    PublishedOn = publishedon;
    PublishedBy = publishedby;
    if(PublishedBy == "Unknown")
    {}
    else
    {Console.WriteLine("Book Created (6 Constructors)");}
  } 

  public void Display()
  {
    Console.WriteLine("Book '" + Title + "' was written by " + AuthorInfo + " and was published on " + PublishedOn + ".");
    Console.WriteLine("Books Displayed");
  }

  
 
 }