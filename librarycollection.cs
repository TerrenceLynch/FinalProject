using System;
using System.Collections.Generic;

class LibraryCollection
{
  private List<Patron> PatronList = new List<Patron>();
  public List<Book> LCBookList = new List<Book>();

  public void AddPatron(Patron p)
  {
    PatronList.Add(p);
    Console.WriteLine("Patron " + p.FirstName + " " + p.LastName + " has been added");
  }

  public void RemovePatron(Patron p)
  {
    Patron p2 = PatronList.Find(x => x.LibaryId == p.LibaryId);
    PatronList.Remove(p2);
    Console.WriteLine("Patron " + p.FirstName + " " + p.LastName + " has been removed");
  }

  public void DisplayPatron()
  {
    foreach(Patron p in PatronList)
    {p.Display();}
  }

  public void AddToCollection(Book b)
  {
    LCBookList.Add(b);
    Console.WriteLine("Book has been added");
  }

  public void RemoveFromCollection(Book b)
  {
      LCBookList.Remove(LCBookList.Find(x => x == b));
      Console.WriteLine("Book has been removed");
  }

  public void DisplayCollection()
  {
    foreach(Book b in LCBookList)
    {b.Display();}
  }

  public void ProcessRental(Patron p)
  {
    foreach(Rental r in p.RentalCart)
    {
      LCBookList.Remove(r.B);
      Console.WriteLine("Book " + r.B.Title + " has been processed as a rental");
    }
  }

 public void ProcessReturn(Patron p, Book b)
 {
   Rental r = p.RentalCart.Find(x => x.B == b);
   int time = DateTime.Compare(r.DateDue, DateTime.Today);
   if (time < 0)
   {
     p.FineAmountDue = p.FineAmountDue + 10;
     Console.WriteLine("You have recived a fine of 10$");
   }
   LCBookList.Add(r.B);
   p.RentalCart.Remove(r);  
 }
 /* I hope you don't mind but I am midly annoyed at a mistake and wanna rant about it before I move on. You can just skip this note, or read it to see my stupidity, but I was trying to remove and add the book from LCBookList, im not sure why this is what I came to, but I was trying to use the AddToCollection/RemoveFromCollection to add or remove a book, for some reason, i fell stupid now that i figured it out, also mad it took 20 MIN. so anyway im going to go do the part three testing, have a good Morning/Day/Afternoon/Night/Whatever(ran out of things) peace.*/



}

