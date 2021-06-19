using System;
namespace WebApp1.Data
{
    public class Grades_per_Subjects
    {
        public Grades_per_Subjects()
        {
        }
        
        public string student_id { get; set; }
        public string grade { get; set; }
        public string subject { get; set; }
        public string periodic_grading { get; set; }
        public string grades { get; set; }
    }
}
