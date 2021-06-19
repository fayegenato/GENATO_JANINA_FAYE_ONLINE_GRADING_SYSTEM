using System;
namespace WebApp1.Data
{
    public class Total_Grades_Subject
    {
        public Total_Grades_Subject()
        {
        }
        
        public string student_id { get; set; }
        public string subject { get; set; }
        public string first_grading { get; set; }
        public string second_grading { get; set; }
        public string third_grading { get; set; }
        public string fourth_grading { get; set; }
        public string quizzes { get; set; }
        public string project_per_grading { get; set; }
        public string final_grade { get; set; }
        public string remarks { get; set; }
    }
}
