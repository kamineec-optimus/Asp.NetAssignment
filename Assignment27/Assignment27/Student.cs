using System;
namespace Assignment27
{
    [Serializable]
    /// <summary>
    /// student class
    /// </summary>
    public class Student
    {
        /// <summary>
        /// public variable rollno of student
        /// </summary>
        public int RollNo;

        /// <summary>
        /// public variable Name of student
        /// </summary>
        public string Name;

        /// <summary>
        /// public variable TotalMarks of student
        /// </summary>
        public int TotalMarks;

        /// <summary>
        /// Private variable grade of student 
        /// </summary>
        private char _grade;

        /// <summary>
        /// public readonly property for Grade
        /// </summary>
        public char Grade
        { 
            // property returns grade accordingly
           get
           {
                if(TotalMarks>60)
                return ('D');
                else if(TotalMarks>=60 && TotalMarks <80)
                return ('C');
                else if(TotalMarks>=80 && TotalMarks <90)
                return ('B');
                else if(TotalMarks>=90 && TotalMarks <100)
                return ('A');
                else
                return('F');
           }
        }

        /// <summary>
        /// default constructor
        /// </summary>
        public Student()
        {
            Name = "Himanshu";
            RollNo = 101;
            TotalMarks = 96;
        }



        public void Print()
        {
            Console.WriteLine("Name = '{0}'", Name);
            Console.WriteLine("RollNo = '{0}'", RollNo);
            Console.WriteLine("TotalMarks = '{0}'", TotalMarks);
            Console.WriteLine("Grade = '{0}'", Grade);
        }


        /// <summary>
        /// parameterized constructor to initialize objects
        /// </summary>
        /// <param name="name">Name of the student</param>
        /// <param name="rollNo">roll no of the student</param>
        /// <param name="totalMarks">Total marks of the student</param>
        public Student(string name, int rollNo, int totalMarks)
        {
            this.Name = name;
            this.RollNo = rollNo;
            this.TotalMarks = totalMarks;            
        }
    }
}
