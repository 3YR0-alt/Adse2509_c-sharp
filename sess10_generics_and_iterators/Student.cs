using System;

namespace sess10_generics_and_iterators
{
    /// <summary>
    /// Represents a <see cref="Student"/> with basic details like Student Number, Names, Birthdate,
    /// Gender (binary), email, course, current semester, and Nationality
    /// </summary>
    public class Student : Person
    {
        //=========================================================
        // STUDENT PROPERTIES
        //=========================================================
        /// <summary>
        /// Gets or sets the student's Student Number
        /// </summary>
        public string StudentNo { get; set; }

        /// <summary>
        /// Gets or sets the student's course
        /// </summary>
        public string Course { get; set; }

        /// <summary>
        /// Gets or sets the student's current semester
        /// </summary>
        public byte CurrentSem { get; set; }

        //=========================================================
        // STUDENT CONSTRUCTORS
        //=========================================================
        /// <summary>
        /// Initialises a <see cref="Student"/> object with default values.
        /// </summary>
        public Student() : base()
        {
            this.StudentNo = string.Empty;
            this.Course = "";
            this.CurrentSem = 1;
        }
        /// <summary>
        /// Initialises a <see cref="Student"/> object with specified values.
        /// </summary>
        /// <param name="names">The student's names</param>
        /// <param name="dob">The student's date of birth</param>
        /// <param name="gender">The student's binary gender (m/f)</param>
        /// <param name="email">The student's email address</param>
        /// <param name="nationality">The student's nationality</param>
        /// <param name="studNo">The student's Student Number</param>
        /// <param name="course">The student's course</param>
        /// <param name="currSem">The student's current semester</param>
        public Student(string names, DateTime dob, char gender, string email, string nationality, string studNo, string course, byte currSem) : base(names, dob, gender, email, nationality)
        {
            this.StudentNo = studNo;
            this.Course = course;
            this.CurrentSem = currSem;
        }

        //=========================================================
        // STUDENT OVERIDDEN METHOD(S)
        //=========================================================
        /// <summary>
        /// Returns a formatted string representation of the Student's  details.
        /// </summary>
        /// <returns>
        /// A human-readable representation of the Student's student number, name, birthdate, gender, email, course, current semester, and nationality.
        /// </returns>
        public override string ToString()
        {
            return $"Student's Details" +
                $"\n" + new string('-', 55) +
                $"\nStudent Number: {this.StudentNo}" +
                $"\nNames: {this.Names}" +
                $"\nDate of birth: {this.BirthDate}" +
                $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
                $"\nEmail: {this.Email}" +
                $"\nCourse: {this.Course}" +
                $"\nCurrent Semester: {this.CurrentSem}" +
                $"\nNationality: {this.Nationality}" +
                $"\n" + new string('-', 55);
        }
    }
}