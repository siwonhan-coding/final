namespace Database_Management_System.Models
{
    public class Student
    {
        public int StudentId {  get; set; }
        public int StudentNumber {  get; set; }
        public string StudentName { get; set; }
        public string ProgramName {  get; set; }
        public DateOnly RegistrationDate { get; set; }
        public string StudentEmail {  get; set; }
        public List<Student>? Students { get; set; }
    }
}
