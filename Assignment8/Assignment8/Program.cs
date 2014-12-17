using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Program
    {
        /// <summary>
        /// String to print message
        /// </summary>
       
        private const string EnterStudentDetail = "Please Enter The Student Detail: ";
        private const string EnterStudentName = "Please Enter The Student Name: ";
        private const string EnterStudentAge = "Please Enter The Student Age: ";
        private const string EnterStudentMobileNo = "Please Enter The Student Mobile No: ";
        private const string PrintChoice = "Plese Select your choice to print a specific detail of Student (0, 1, 2, 3)\n0-Student Name \n1-Student Age\n2-Student Enrolment No\n3-Student Mobile No";

        
        static void Main(string[] args)
        {

            /// <summary>
            /// Object of Random class to generate student enrolment no
            /// </summary>
            Random StudentEnrolmentNos = new Random();

            /// <summary>
            /// variable to store student details
            /// </summary>            
          
           string StudentName;
           int StudentAge;
           int StudentEnrolmentNo;
           int StudentMobileNo;

           /// <summary>
           /// Take user Input for Student detail
           /// </summary>   

           Console.WriteLine(EnterStudentDetail);
           
            /// <summary>
            ///  Enter Student Name
            /// </summary>

           Console.WriteLine(EnterStudentName);
            StudentName = Console.ReadLine();

            /// <summary>
            ///  Enter Student Age
            /// </summary> 

            Console.WriteLine(EnterStudentAge);
            StudentAge = int.Parse(Console.ReadLine());

            /// <summary>
            ///  Enter Student Student Mobile No
            /// </summary> 

            Console.WriteLine(EnterStudentMobileNo);
            StudentMobileNo = int.Parse(Console.ReadLine());

            /// <summary>
            ///  Take Student Enrolment No from Random class
            /// </summary>           
           
            StudentEnrolmentNo = StudentEnrolmentNos.Next();

            /// <summary>
            ///  Call Parametrize constructor of Student Class to create object
            /// </summary> 
            
            Student objStudent = new Student(StudentName, StudentAge, StudentEnrolmentNo, StudentMobileNo);

            /// <summary>
            ///  Call Student Class's PrintStudentDetail method to print Student Details
            /// </summary>            

            objStudent.Print();

            /// <summary>
            ///  Enter uour choice to print specific details
            /// </summary>
             
            Console.WriteLine(PrintChoice);

            /// <summary>
            ///  variable to save choice of user to print specific detail of student    
            /// </summary>
                    
            int Choice = Int32.Parse(Console.ReadLine());

            /// <summary>
            ///  call print method of student class to print a specific detail about a student
            /// </summary>
            
            objStudent.print(Choice);
            
            Console.ReadLine();

        }
    }
}
