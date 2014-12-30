using System.Web.UI.WebControls;

namespace Assignment32
{
    public partial class Home : System.Web.UI.Page
    {
        //variable to save current user's roleId
        public int RoleId;

        protected void Page_Load(object sender, System.EventArgs e)
        { 
            //current user's roleId
           RoleId = int.Parse(Request.QueryString["RoleID"]);
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            //update the gridview when user inserted
            gvUserDetail.DataBind();
        }

        protected void lblFileUpload_Click(object sender, System.EventArgs e)
        {
            //create the object of EntityFrameworkEntities to call the file upload method
            EntityFrameworkEntities objEntityFrameworkEntities = new EntityFrameworkEntities();
            //upload the file to the database 
            objEntityFrameworkEntities.UploadDocument(fupFileUploader.FileBytes);           
        }

        protected void gvUserDetail_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //show edit/delete/insert buttons visible only for admin
            if (RoleId != 1)
            {
                e.Row.Cells[0].Visible = false;
                mvHomePage.ActiveViewIndex = -1;
            }
        }             
      
    }
}