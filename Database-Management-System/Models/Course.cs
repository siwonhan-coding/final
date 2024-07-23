namespace Database_Management_System.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseNumber {  get; set; }
        public string CourseType {  get; set; }
        public bool Coompleted {  get; set; }
        public int StudentId {  get; set; }
        public Student? Student { get; set; }
    }
}
