using System.Web.Mvc;
using SampleApplication.Models;
using System.Text;

namespace SampleApplication.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Strings used in program
        /// </summary>
        private const string name = "Your Name is : {0}</br/>";
        private const string userName = "Your UserName is : {0}</br/>";
        private const string emailId = "Your Email is :  {0}</br/>";        
        /// <summary>
        /// This controller will return a model of User Type
        /// </summary>
        /// <returns>View of type User model</returns>
        public ActionResult GetUserInformation()
        {
            SampleApplication.Models.User model = new SampleApplication.Models.User();
            return View(model);
        }

        /// <summary>
        /// This method will display the user information
        /// </summary>
        /// <param name="model">Object of User class</param>
        /// <returns>User information</returns>
        [HttpPost]
        public ActionResult GetUserInformation(User model)
        {
            StringBuilder userInformation = new StringBuilder();
            userInformation.Append(string.Format(name, model.FirstName));
            userInformation.Append(string.Format(userName, model.UserName));
            userInformation.Append(string.Format(emailId, model.EmailId));
            return Content(userInformation.ToString());
        }
    }
}
