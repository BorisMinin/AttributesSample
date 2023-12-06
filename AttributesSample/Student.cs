using System.ComponentModel.DataAnnotations;

namespace AttributesSample
{
    public class Student
    {
        // the name must not contain numbers
        [RegularExpression(@"^[A-Za-z.-]+(\s*[A-Za-z.-]+)*$", ErrorMessage = "The name must not contain a number")]
        public string Name { get; set; }

        // The score should be in the range of 2 to 5
        [Range (2,5, ErrorMessage = "The score must be at least 2 and no more than 5")]
        public int Grades { get; set; }

        // the mail must be valid
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "The email is uncorrect")]
        public string Email { get; set; }
    }
}