using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017Lesson8B
{
    public class Student : Person 
    {
        //private instance variables (fields)
        private string _studentID;
        //public properties
        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID=value;
            }            
        }
        //constructors...................
        /// <summary>
        /// This is the constructor for the student class.
        /// This takes three arguments -name(string)-age(int)-studentID(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            :base(name, age)
        {
            this.StudentID = _studentID;
        }
        //public methods.............
        /// <summary>
        /// This is the Studies method.
        /// Enables the student to study.
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name+ " is studying!");
        }
    }
}
