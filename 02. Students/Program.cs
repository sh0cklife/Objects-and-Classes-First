namespace _02._Students
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] studentData = command.Split(" ");
                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string homeTown = studentData[3];

                Student currentStudent = new Student(firstName, lastName, age, homeTown); // така заради конструктура

                students.Add(currentStudent);

                command = Console.ReadLine();
            }
            string city = Console.ReadLine();
            List<Student> filteredStudents = students
                .Where(x => x.HomeTown == city)
                .ToList();
            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }
}