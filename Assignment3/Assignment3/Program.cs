using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        /// <summary>
        /// Enum to store week days value
        /// </summary>
        enum WeekDays { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            /// take a array of type string to save the value of enum
            string[] days = Enum.GetNames(typeof(WeekDays));

            /// Loop through all the enum values to print week days
        foreach (string day in days)
          {
            Console.WriteLine(day);
          }
            Console.ReadLine();
        }
    }
}
