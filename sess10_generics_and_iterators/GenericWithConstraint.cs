using System;

namespace sess10_generics_and_iterators
{

    public class GenericWithConstraint<T> where T : Person
    {
        public List<T> genericPersons = new List<T>();
    }

    public class DemoGenericWithConstraint
    {
        static void Main(string[] args)
        {
            // Declare and instantiate generic classes
            GenericWithConstraint<Student> student = new GenericWithConstraint<Student>();
            GenericWithConstraint<Staff> edulinkStaff = new GenericWithConstraint<Staff>();
            // GenericWithConstraint<string> studentNames = new GenericWithConstraint<string>();

            // Prompt the user for the number of students
            Console.WriteLine("How many students are in the class?");
            int n, numOfPersons = int.Parse(Console.ReadLine());

            // Read in the student's details
            try
            {
                for (n = 0; n < numOfPersons; n++)
                {
                    Console.WriteLine($"Please enter the name of student {n + 1}:");
                    string name = Console.ReadLine();
                    Console.WriteLine($"Please enter {name}'s student number -> ");
                    string studentNo = Console.ReadLine();
                    Console.WriteLine($"Please enter {name}'s birth date:");
                    DateTime dob = DateTime.Parse(Console.ReadLine()); // DateTime dob = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine($"Please enter {name}'s binary gender (M/F): ");
                    char gender = char.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {name}'s email address: ");
                    string email = Console.ReadLine();
                    Console.WriteLine($"Please enter {name}'s course:");
                    string course = Console.ReadLine();
                    Console.WriteLine($"Please enter {name}'s current semester: ");
                    int currSem = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter {name}'s nationality: ");
                    string nationality = Console.ReadLine();

                    // Add the above details to the student's list
                    student.genericPersons.Add(new Student(name, dob, gender, email, nationality, studentNo, course, (byte)currSem));
                }

                // Display each student's details
                foreach (Student s in student.genericPersons)
                    Console.WriteLine(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.GetType().ToString().Replace("System.", "")} occurred.");
            }

            // TODO: 1. Prompt user for number of staff  2. Read in and display the names of 3 Edulink staff members
        }
    }
}