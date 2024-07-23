using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Database_Management_System.Models
{
    public class Student
    {
        public int StudentId {  get; set; }
        [DisplayName("Student Number")]
        [Required]
        public int StudentNumber {  get; set; }
        [DisplayName("Student Name")]
        [Required]
        public string StudentName { get; set; }
        [DisplayName("Program Name")]
        [Required]
        public string ProgramName {  get; set; }
        [DisplayName("Registration Date")]
        [Required]
        public DateOnly RegistrationDate { get; set; }
        [Required]
        [DisplayName("Student Email")]
        public string StudentEmail {  get; set; }
        public List<Student>? Students { get; set; }
    }
}
