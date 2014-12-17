using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;

namespace BusinessLayer
{
    public class Book
    {
        /// <summary>
        ///Create DataLayer Object to call methods 
        /// </summary>
      public  DataLayer objDataLayer = new DataLayer();

        /// <summary>
        /// message to validate property
        /// </summary>
      public const string msgString = "Please enter the required field";
      public const string msgInt = "Please enter the valid value";
      /// <summary>
      /// Private Variables Region
      /// </summary>
     
      private string _BookName;
      private string _AuthorName;
      private int _PriceOfBook;
      private int _QuantityOfBooks;
      private int _IdOfCurrentUser;

        /// <summary>
        /// Method to validate string property value 
        /// </summary>
        /// <param name="str">value</param>
        /// 
      public void ValidateStringProperty(string str)
      {
          if (str == string.Empty)
          {
              throw new Exception(msgString);
          }
      }

      /// <summary>
      /// Method to validate integer property value 
      /// </summary>
      /// <param name="str">value</param>
      /// 
      public void ValidateIntProperty(int value)
      {
          if (value <= 0)
          {
              throw new Exception(msgInt);
          }
      }
        
    /// <summary>
      ///Public Properties
    /// </summary>
    
      /// <summary>
      ///Public property for book name
      /// </summary>     
       
      public string BookName 
      { 
          get {
              return _BookName;
              }
          set {
              ValidateStringProperty(value);
              _BookName = value;
              }
      }

      /// <summary>
      ///Public property for author name
      /// </summary>   
      
      public string AuthorName 
      {
          get {
              return _AuthorName; 
              } 
          set {
              ValidateStringProperty(value);
              _AuthorName= value;
               } 
      }

      /// <summary>
      ///Public property for Book Price
      /// </summary> 
      /// 

      public int PriceOfBook
      {
          get {
              return _PriceOfBook;
              }
          set {
              ValidateIntProperty(value);
              _PriceOfBook = value; 
              }
      }

      /// <summary>
      ///Public property for quantity of the book
      /// </summary> 
      /// 

      public int QuantityOfBooks
      {
          get {
              return _QuantityOfBooks;
              } 
          set {
              ValidateIntProperty(value);
             _QuantityOfBooks = value;
              }
      }

      /// <summary>
      ///Public property for id of the member loged in 
      /// </summary> 
      /// 

      public int IdOfCurrentUser
      {
          get
          {
              return _IdOfCurrentUser;
          }
          set
          {
              ValidateIntProperty(value);
              _IdOfCurrentUser = value;
          }
      }      

      /// Public Methods Region           

        /// <summary>
      /// Method to fetch books from datalayer
        /// </summary>
        /// <returns>Returns books from database</returns>
        
      public Object LoadBooks()
      {
          return objDataLayer.LoadBooks();
      }
       
        /// <summary>
      /// Method to insert book
        /// </summary>
        /// <param name="bookName">Book Name</param>
        /// <param name="authorName">Author Name o</param>
        /// <param name="price">Price of the book</param>
      /// <param name="quantityOfBooks">Quantity Of Books</param>

      public void AddNewBook(string bookName, string authorName, int priceOfBook, int quantityOfBooks)
      {
          BookName = bookName;
          AuthorName = authorName;
          PriceOfBook = priceOfBook;
          QuantityOfBooks = quantityOfBooks;
          objDataLayer.AddNewBook(BookName, AuthorName, PriceOfBook, QuantityOfBooks);
      }

      /// <summary>
      /// Method to insert issued book
      /// </summary>
      /// <param name="bookName">Book Name</param>
      /// <param name="authorName">Author Name o</param>
      /// <param name="idOfCurrentUser">Id of the member</param>

      public void InsetIssuedBook(string bookName, string authorName, int idOfCurrentUser)
      {
          BookName = bookName;
          AuthorName = authorName;
          IdOfCurrentUser = idOfCurrentUser;
          objDataLayer.InsertIssueBook(BookName, AuthorName, IdOfCurrentUser);

      }

      /// <summary>
      /// Method to fetch issued books from datalayer
      /// </summary>
      /// <returns>Returns issued books from database</returns>

      public Object LoadIssuedBooks(int idOfCurrentUser)
      {
          IdOfCurrentUser = idOfCurrentUser;
          return objDataLayer.LoadIssuedBook(IdOfCurrentUser);
      }

      /// <summary>
      /// Update the quantity of the issued book to the library
      /// </summary>
      /// <param name="bookName">Book Name</param>
      /// <param name="authorName">Password</param>
      
      public void UpdateIssuedBook(string bookName, string authorName)
      {
          BookName = bookName;
          AuthorName = authorName;
          objDataLayer.UpdateIssuedBooks(BookName, AuthorName);
      }

        /// <summary>
        /// Add issued book to library
        /// </summary>
        /// <param name="bookName">Book Name</param>
        /// <param name="authorName">Author Name</param>
        
      public void RemoveReturnedBook(string bookName, string authorName)
      {
          BookName = bookName;
          AuthorName = authorName;
          objDataLayer.RemoveReturnedBooks(BookName, AuthorName);
      }

      /// <summary>
      /// Method to update quantity of the issued book
      /// </summary>
      /// <param name="bookName">Book Name</param>
      /// <param name="authorName">Author Name</param>
      
      public void UpdateReturnedBook(string bookName, string authorName)
      {
          BookName = bookName;
          AuthorName = authorName;
          objDataLayer.UpdateReturnedBooks(BookName, AuthorName);
      }
    }
}
