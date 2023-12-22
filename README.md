# AttributesSample Application

The AttributesSample application is a C# console application that demonstrates the use of data annotations for validation in the .NET framework.

## Validation Rules

- **Name**: The name must not contain numbers.
- **Grades**: The score should be in the range of 2 to 5.
- **Email**: The email must be valid.

## Getting Started

To run the AttributesSample application, follow these steps:

1. Clone the repository: `git clone https://github.com/BorisMinin/AttributesSample.git`
2. Open the solution in Visual Studio.
3. Build the solution.
4. Run the program.

## Usage

The program creates a list of `Student` objects with sample data and validates each student. If a validation error occurs, the error message is displayed.

```csharp
var students = new List<Student>
{
    new Student { Name = "Ivan Ivanov1", Grades = 4, Email = "ivan@example.com" },
    new Student { Name = "Alex Petrov", Grades = 3, Email = "alex@example.com" },
    new Student { Name = "Marry Sidorova", Grades = 5, Email = "mariaexample.com" }
};

ValidateStudents(students);
