using System;
using System.Collections.Generic;

class Patron : Person
{
  public string LibaryId { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public bool IsAccountActive { get; set; }
  public List<Rental> RentalCart = new List<Rental>();
  public double FineAmountDue { get; set; }

  public Patron(string fname, string lname, string libaryid) : base (fname, lname)
  {
    LibaryId = libaryid;
    FineAmountDue = 0;
    StartDate = DateTime.Today;
    IsAccountActive = true;
    Console.WriteLine("Patron has been created");
  }

  public void Display()
  {
    Console.WriteLine("Patron Id=" + LibaryId + " Name: " + FirstName + " " + LastName);
  }

  public void AddToRentalCart(Book b, DateTime duedate)
  {
    Rental r = new Rental(b, DateTime.Today, duedate);
    RentalCart.Add(r);
    Console.WriteLine("Added to rental cart " + r.B.Title + " for Patron " + FirstName + " " + LastName + ".");
  }

  public void RemoveFromRentalCart(Book b)
  {
    Rental r = RentalCart.Find(x => x.B == b);
    RentalCart.Remove(r);
    Console.WriteLine("Removed book " + r.B.Title + " from rental cart for " + FirstName + " " + LastName + ".");
  }


}