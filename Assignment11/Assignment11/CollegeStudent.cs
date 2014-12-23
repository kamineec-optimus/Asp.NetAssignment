
namespace Assignment11
{
    class CollegeStudent: Student
    {
        /// <summary>
        /// Public properties
        /// </summary>

       public string Symester { get; set; }
        /// <summary>
       ///  Proprty to show college student's batchNo
        /// </summary>
       public int BatchNo { get; set; }
        /// <summary>
       ///  Proprty to show college student's Department Id
        /// </summary>
       public int DepartmentId { get; set; }
        /// <summary>
       ///  Proprty to show college student's Branch
        /// </summary>
       public string Branch { get; set; }

        /// <summary>
        /// Method to register a collage student for election
        /// </summary>
        /// <param name="collegeId"></param>

       public void GetRegisteredForElection(string enrollmentNo)
       {
           ///code to register a student for election
       }

        /// <summary>
        /// Method to change a student's current program to a new program
        /// </summary>
        /// <param name="enrollmentNo">Student's enrollment Id</param>
        /// <param name="currentProgram">Student's current program</param>
        /// <param name="newProgram">Student's new program</param>
       public void ChangeProgram(string enrollmentNo, string currentProgram, string newProgram)
       {
           ///code to change a student's current program to other Program
       }



    }
}
