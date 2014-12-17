using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace LibraryProject
{
    public partial class LibBooks : System.Web.UI.Page
    {
        /// <summary>
        /// object of Business logic layer of Book
        /// </summary>
        
        Book objBook = new Book();

        /// <summary>
        /// Variable to save previous page URL
        /// </summary>
        static string PrePage = string.Empty;

        /// <summary>
        /// Variable to print message;
        /// </summary>
        public const string msg = "Hello {0}";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserType"].ToString() == "Admin")
                {
                    btnAddBooks.Visible = true;                   
                }
                PrePage = Request.UrlReferrer.ToString();
            }
            lblMsg.Text = string.Format(msg, Session["UserName"]);
            BindGrid();           

        }

        /// <summary>
        /// method to bind gridview
        /// </summary>
        
        public void BindGrid()
        {
            gvBooks.DataSource = objBook.LoadBooks();
            gvBooks.DataBind();
        }
        
        /// <summary>
        /// Add book to Library
        /// </summary>
        
        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            objBook.AddNewBook(txtBookName.Text, txtAuthor.Text, Convert.ToInt32(txtPrice.Text), Convert.ToInt32(txtQuantity.Text));
            BindGrid();
            txtBookName.Text = "";
            txtAuthor.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        /// <summary>
        /// This method will show the Textboxes to returned book
        /// </summary>
 
        protected void btnIssueReturnBook_Click(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 1;
        }

        /// <summary>
        /// This method will show the Textboxes to Add Books
        /// </summary>
        
        protected void btnAddBooks_Click(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 0;
        }

        /// <summary>
        /// This method will insert the book to the database
        /// </summary>
      
        protected void btnIssueBook_Click(object sender, EventArgs e)
        {
            objBook.InsetIssuedBook(txtIssueBookName.Text, txtIssueAuthor.Text, Convert.ToInt32(Session["UserId"]));
            gvIssueBook.DataSource = objBook.LoadIssuedBooks(Convert.ToInt32(Session["UserId"]));
            gvIssueBook.DataBind();
            objBook.UpdateIssuedBook(txtIssueBookName.Text, txtIssueAuthor.Text);
            BindGrid();
            txtIssueAuthor.Text = string.Empty;
            txtIssueBookName.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// This method will return book
        /// </summary>
       
        protected void btnReturnBook_Click(object sender, EventArgs e)
        {
            objBook.RemoveReturnedBook(txtIssueBookName.Text, txtIssueAuthor.Text);
            gvIssueBook.DataSource = objBook.LoadIssuedBooks(Convert.ToInt32(Session["UserId"]));
            gvIssueBook.DataBind();
            objBook.UpdateReturnedBook(txtIssueBookName.Text, txtIssueAuthor.Text);
            BindGrid();
            txtIssueAuthor.Text = string.Empty;
            txtIssueBookName.Text = string.Empty;

        }

        /// <summary>
        /// Method to show issued book 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnShowIssuedBooks_Click(object sender, EventArgs e)
        {
            multiView.ActiveViewIndex = 1;
            gvIssueBook.DataSource = objBook.LoadIssuedBooks(Convert.ToInt32(Session["UserId"]));
            gvIssueBook.DataBind();
        }

        /// <summary>
        /// 
        /// Method to go back to the previous button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        protected void lbtnPrevious_Click(object sender, EventArgs e)
        {
            Response.Redirect(PrePage);
        }

        /// <summary>
        /// Method to logout a user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        protected void lbtnLogout_Click(object sender, EventArgs e)
        {                  
            Session.Abandon();
            Response.Redirect("Login.aspx");
           
        }

    }
}