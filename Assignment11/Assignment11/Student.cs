using System;

namespace Assignment11
{   
    /// <summary>
    /// enum for student details/attributes
    /// </summary>
    public enum StudentAttribute
    {
        StudentName,
        StudentAge,
        StudentEnrolmentNo,
        StudentMobileNo,
    };

    class Student
    {
        /// <summary>
        /// String to print message
        /// </summary>
        private const string WelComeMsg = "WelCome {0} \n StudentAge= {1} \n StudentEnrolmentNo = {2} \n StudentMobileNo= {3} \n";
        private const string PrintStudentName = "The Name of Student is: {0}";
        private const string PrintStudentAge = "The Age of Student is: {0}";
        private const string PrintStudentEnrolmentNo = "The EnrolmentNo of Student is {0}";
        private const string PrintStudentMobileNo = "The Mobile No of Student is: {0}";

        /// <summary>
        /// Public default constructor
        /// </summary>
        public Student()
        {

        }
        /// <summary>
        /// Public Parametrize constructor
        /// </summary>
        /// <param name="studentName">Name Of the Student</param>
        /// <param name="studentAge">Age of the Student</param>
        /// <param name="studentEnrolmentNo">EnrolmentId of the Student </param>
        /// <param name="studentMobileNo">student Mobile No</param>
        
       public Student(string studentName, int studentAge, int studentEnrolmentNo, int studentMobileNo)
        {
            StudentName = studentName;
            StudentAge = studentAge;
            StudentEnrolmentNo = studentEnrolmentNo;
            StudentMobileNo = studentMobileNo;
        }
        /// <summary>
        /// Private fields of Student Class
        /// </summary>
        private string _StudentName;
        private int _StudentAge;
        private int _StudentEnrolmentNo;
        private int _StudentMobileNo;

        /// <summary>
        /// Public Properties of Student Class
        /// </summary>
        /// 
        /// <summary>
        /// Public property for Student Name
        /// </summary>
        public string StudentName
        { 
            get {
                return _StudentName;
                 }
            set {
                _StudentName = value;
                }
         }
        /// <summary>
        /// Public property for Student Age
        /// </summary>
        public int StudentAge
        {
            get
            {
                return _StudentAge;
            }
            set
            {
                _StudentAge = value;
            }
        }

        /// <summary>
        /// Public property for Student Registraion No
        /// </summary>
        public int StudentEnrolmentNo
        {
            get
            {
                return _StudentEnrolmentNo;
            }
            set
            {
                _StudentEnrolmentNo = value;
            }
        }

        /// <summary>
        /// Public property for Student Mobile No
        /// </summary>
        public int StudentMobileNo
        {
            get
            {
                return _StudentMobileNo;
            }
            set
            {
                _StudentMobileNo = value;
            }
        }


        /// <summary>
        /// Public Methods of Student Class
        /// </summary>       
    
        ///Method to Print Student Detail with WelCome message

        public void Print()
        {
            Console.WriteLine(WelComeMsg, StudentName, StudentAge, StudentEnrolmentNo, StudentMobileNo);
        }

        /// <summary>
        /// Print overloaded method 
        /// </summary>
        /// <param name="studentName">Student Name</param>
        public void print(int choice)
        {
           /// create enum type to save the choice 
            StudentAttribute Choice = (StudentAttribute)choice;

            ///Make decision based on enum value
            switch (Choice)
            {
                case StudentAttribute.StudentName:
                    Console.WriteLine(PrintStudentName, StudentName);
                    break;

                case StudentAttribute.StudentAge:
                    Console.WriteLine(PrintStudentAge, StudentAge);
                    break;

                case StudentAttribute.StudentEnrolmentNo:
                    Console.WriteLine(PrintStudentEnrolmentNo, StudentEnrolmentNo);
                    break;

                case StudentAttribute.StudentMobileNo:
                    Console.WriteLine(PrintStudentMobileNo, StudentMobileNo);
                    break;

            }

            Console.ReadLine();
        }
    }
}
