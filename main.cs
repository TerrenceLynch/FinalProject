using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    
    /*Start of Part 1*/
    Book B_ONE = new Book("0001", "Why is time management so hard.", "Colin Smith");
    Book B_TWO = new Book("0002", "How to stay awake for 7 days.", "Iyana Cortez"); 
    Book B_THREE = new Book("0003", "How to do three final projects in a day.", "Moriah Stout"); 
    Book B_FOUR = new Book("0004", "How to build a birdhouse.", "Alannah Cook", Convert.ToDateTime("5/22/1929"), "7/10/1932");
    Book B_FIVE = new Book("0005", "How to cope with sadness.", "Adison Reynolds", Convert.ToDateTime("1/1/2000"), "2/7/2001"); 
    Book B_SIX = new Book("0006", "How to pray for test day.", "Gavyn Humphrey", Convert.ToDateTime("10/2/1982"), "9/9/1969");

    Author A_One = new Author("Kolton", "Alvarez");
    Author A_Two = new Author("Tyler", "Wood");
    A_One.DisplayBooks();
    A_Two.DisplayBooks();
    A_One.AddBook(B_ONE);
    A_One.AddBook(B_THREE);
    A_One.AddBook(B_FIVE);
    A_One.DisplayBooks();
    A_Two.AddBook(B_TWO);
    A_Two.AddBook(B_FOUR);
    A_Two.AddBook(B_SIX);
    A_Two.DisplayBooks();
    A_One.RemoveBook("0001");
    A_One.DisplayBooks();
    /*End of Part 1*/

    /*Start of Part 2*/
    Patron P_One = new Patron("Walter", "Gould", "0001");
    Patron P_Two = new Patron("Stephany", "Shepherd", "0002");
    Patron P_Three = new Patron("Jaidyn", "Miles", "0003");
    Patron P_Four = new Patron("Sadie", "Oneal", "0004");
    Patron P_Five = new Patron("Kenzie", "Duarte", "0005");
    P_One.AddToRentalCart(B_ONE, Convert.ToDateTime("12/30/2020"));
    /* I would have used book 3, but as it was not there before it caused an error, I did test it, if you wanna see what happens:*/ /*P_One.RemoveFromRentalCart(B_THREE);*/
    P_One.RemoveFromRentalCart(B_ONE);
    P_One.Display();
    /*End of Part 2*/


    /*Start of Part 3*/
    LibraryCollection LC = new LibraryCollection();
    LC.AddPatron(P_One);
    LC.AddPatron(P_Two);
    LC.AddPatron(P_Three);
    LC.AddPatron(P_Four);
    LC.AddPatron(P_Five);
    LC.DisplayPatron();
    LC.RemovePatron(P_Five);
    LC.DisplayPatron();
    LC.AddToCollection(B_ONE);
    LC.AddToCollection(B_TWO);
    LC.AddToCollection(B_THREE);
    LC.AddToCollection(B_FOUR);
    LC.AddToCollection(B_FIVE);
    LC.AddToCollection(B_SIX);
    LC.DisplayCollection();
    LC.RemoveFromCollection(B_FIVE);
    LC.DisplayCollection();
    P_One.AddToRentalCart(B_ONE, Convert.ToDateTime("12/10/2020"));
    P_One.AddToRentalCart(B_TWO, Convert.ToDateTime("12/10/2020"));
    P_One.AddToRentalCart(B_THREE, Convert.ToDateTime("12/2/2020"));
    P_One.RemoveFromRentalCart(B_THREE);
    LC.ProcessRental(P_One);
    LC.DisplayCollection();
    LC.ProcessReturn(P_One, B_TWO);
    LC.DisplayCollection();
    /*End of Part 3*/




  }
}