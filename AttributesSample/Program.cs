using System.ComponentModel.DataAnnotations;

namespace AttributesSample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student { Name = "Ivan Ivanov1", Grades = 4, Email = "ivan@example.com" },
                new Student { Name = "Alex Petrov", Grades = 3, Email = "alex@example.com" },
                new Student { Name = "Marry Sidorova", Grades = 5, Email = "mariaexample.com" }
            };

            ValidateStudents(students);
        }

        public static void ValidateStudents(List<Student> students)
        {
            foreach (var student in students)
            {
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(student);

                bool isValid = Validator.TryValidateObject(student, validationContext, validationResults, true);

                if (!isValid)
                {
                    Console.WriteLine($"Validation errors for student {student.Name}:");

                    foreach (var validationResult in validationResults)
                    {
                        Console.WriteLine(validationResult.ErrorMessage);
                    }
                }
            }
        }
    }
}