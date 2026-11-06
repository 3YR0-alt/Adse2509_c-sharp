using System;

namespace sess01_csharp_intro
{
    /// <summary>
    ///  Represents an employee with an ID, name, and binary gender.
    /// </summary>
    public class SampleEmployeeXMLDocumentation
    {
        
        //Fields
        /// <summary>
        /// Unique identifier for an employee.
        /// </summary>
        private uint _empID;

        /// <summary>
        /// String field to hold the employee's name.
        /// </summary>
        private string _empName;

        /// <summary>
        /// Character field to hold the employee's binary gender
        /// </summary>
        /// <remarks>
        /// The gender is 'M' or 'm' for male and 'F' or 'f' for female.
        /// </remarks>
        private char _gender;

        //Constructors
        /// <summary>
        /// Initialises a new instance of the <seecref="cref="SampleEmployeeXMLDocumentation"/>
        /// This constructor sets default values for the employee's ID, name, and gender.
        /// </summary>
        public SampleEmployeeXMLDocumentation()
        {
            this._empID = 0;
            this._empName = string.Empty; //Same as this._empName = "";
            this._gender = 'M'; //M for male
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="SampleEmployeeXMLDocumentation"/>
        /// with the specified values for the employee's id, name and gender.
        /// </summary>
        /// <param name="empid">The employee's unique ID number.</param>
        /// <param name="name">The employee's name.</param>
        /// <param name="gender">The employee's gender ('M' or 'm' for Male and 'F' or 'f' for female).</param>

        public SampleEmployeeXMLDocumentation(uint empid, string name, char gender)
        {
            this._empID = empid;
            this._empName = name;
            this._gender = gender;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="empID">The employee's unique ID number.</param>
        public void SetID(uint empID)
        {
            this._empID = empID;
        }

        /// <summary>
        /// Retrieves/gets the employee's name.
        /// </summary>
        /// <returns>The employee's name</returns>
        public string GetName()
        {
            return this._empName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this._empName = name;
        }

        /// <summary>
        /// Retrieves/gets the employee's gender.
        /// </summary>
        /// <returns>The employee's gender</returns>
        public char GetGender()
        {
            return this._gender;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gender"></param>
        public void SetGender(char gender)
        {
            this._gender = gender;
        }

        public override string ToString()
        {
            return $"Employee Details" +
                $"\n------------------------------------------------"+
                $"\nID: {this.GetID()}" + 
                $"\nName: {this.GetName()}" +
                $"\nGender: {(this.GetGender()=='M' || this.GetGender() == 'm'? "Male": "Female" )}"+
                $"\n-------------------------------------------------";
        }
      
    }
}
