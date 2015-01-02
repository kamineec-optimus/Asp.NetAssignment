using System;

namespace AdoDotNetObjectCaching
{
    public partial class Home : System.Web.UI.Page
    {
        DataBaseOperation dataBaseOperation = new DataBaseOperation();
        /// <summary>
        /// Strings used in class
        /// </summary>
        private const string cacheMessage = "Data loaded from the Cache";
        private const string databaseMessage = "Data loaded from DataBase";
        private const string removeCacheMessage = "Cached Content has been removed";
        private const string cachedObject = "EmployeeData";

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            // Check if page cache object is null
            if (Cache[cachedObject] == null)
            {               
                // Cache the content in cache object
                Cache[cachedObject] = dataBaseOperation.GetData();
                gvEmployee.DataSource = Cache[cachedObject];
                gvEmployee.DataBind();
                lblMessage.Text = databaseMessage;
            }
            else
            {
                // Use cached object to fill the data
                gvEmployee.DataSource = Cache[cachedObject];
                gvEmployee.DataBind();
                lblMessage.Text = cacheMessage;
            }
                      
        }

        protected void btnClearCache_Click(object sender, EventArgs e)
        {
            // Remove cached object
            if (Cache[cachedObject] != null)
            {
                Cache.Remove(cachedObject);
                lblMessage.Text = removeCacheMessage;
            }        
        }
    }
}