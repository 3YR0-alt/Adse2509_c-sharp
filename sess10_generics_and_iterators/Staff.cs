using System;

namespace sess10_generics_and_iterators
{
    /// <summary>
    /// Represents a <see cref="Staff"/> with basic details like StaffID, Names, Birthdate,
    /// Gender (binary), employment date, designation, phone number, email, and Nationality
    /// </summary>
    public class Staff : Person
    {
        //=========================================================
        // STAFF PROPERTIES
        //=========================================================
        /// <summary>
        /// Gets or set's the staff member's Staff ID
        /// </summary>
        public string StaffID { get; set; }
        /// <summary>
        /// Gets or set's the staff member's date of employment
        /// </summary>
        public DateTime EmploymentDate { get; set; }
        /// <summary>
        /// Gets or set's the staff member's designation (job title)
        /// </summary>
        public string Designation { get; set; }
        /// <summary>
        /// Gets or set's the staff member's phone number
        /// </summary>
        public string PhoneNo { get; set; }

        //=========================================================
        // STAFF CONSTRUCTORS
        //=========================================================
        /// <summary>
        /// Initialises a <see cref="Staff"/> object with default values
        /// </summary>
        public Staff() : base()
        {
            this.StaffID = "";
            this.EmploymentDate = new DateTime(); // Current date
            this.Designation = string.Empty;
            this.PhoneNo = string.Empty;
        }

        /// <summary>
        /// Initialises a <see cref="Staff"/> object with the specified values.
        /// </summary>
        /// <param name="names">The staff member's names</param>
        /// <param name="dob">The staff member's date of birth</param>
        /// <param name="gender">The staff member's gender</param>
        /// <param name="email">The staff member's email</param>
        /// <param name="nationality">The staff member's nationality</param>
        /// <param name="staffID">The staff member's staffID</param>
        /// <param name="employmentDate">The staff member's date of employment</param>
        /// <param name="designation">The staff member's designation/job title</param>
        /// <param name="phoneNo">The staff member's phone number</param>
        public Staff(string names, DateTime dob, char gender, string email, string nationality,
            string staffID, DateTime employmentDate, string designation, string phoneNo) :
            base(names, dob, gender, email, nationality)
        {
            this.StaffID = staffID;
            this.EmploymentDate = employmentDate;
            this.Designation = designation;
            this.PhoneNo = phoneNo;
        }

        //=========================================================
        // STAFF OVERIDDEN METHOD(S)
        //=========================================================
        /// <summary>
        /// Returns a formatted string representation of the staff members's  details.
        /// </summary>
        /// <returns>
        /// A human-readable representation of the staff members's staff id, names, birthdate, gender, employment date, designation (job title), years served, email, phone number, and nationality.
        /// </returns>
        public override string ToString()
        {
            return $"Person's Details" +
                $"\n" + new string('-', 55) +
                $"\nStaff ID: {this.StaffID}" +
                $"\nNames: {this.Names}" +
                $"\nDate of birth: {this.BirthDate}" +
                $"\nGender: {(this.Gender is 'M' or 'm' ? "Male" : "Female")}" +
                $"\nEmployment Date: {this.EmploymentDate}" +
                $"\nDesignation/Job Title: {this.Designation}" +
                $"\nYears served: {DateTime.Now.Year - this.EmploymentDate.Year} years." +
                $"\nEmail: {this.Email}" +
                $"\nPhone Number: {this.PhoneNo}" +
                $"\nNationality: {this.Nationality}" +
                $"\n" + new string('-', 55);
        }
    }
}