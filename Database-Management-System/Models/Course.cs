using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Database_Management_System.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        [DisplayName("Course Name")]
        public string CourseName { get; set; }
        [Required]
        [DisplayName("Course Number")]
        public string CourseNumber {  get; set; }
        [Required]
        [DisplayName("Course Type")]
        public string CourseType {  get; set; }
        [Required]
        [DisplayName("Completed")]
        public bool Coompleted {  get; set; }
        [Required]
        public int StudentId {  get; set; }
        public Student? Student { get; set; }
    }
}
