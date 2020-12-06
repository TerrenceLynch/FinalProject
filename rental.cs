using System;

public class Rental
{
  public Book B;
  public DateTime DateRented { get; set; }
  public DateTime DateDue { get; set; }

  public Rental(Book b, DateTime daterented, DateTime datedue)
  {
    B = b;
    DateRented = DateRented;
    DateDue = datedue;
    Console.WriteLine("Rental has been created");
  }



}