using System;
namespace WebApp1.Data
{
    public class Student
    {
        public Student()
        {
        }
        
        public string student_id { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string gender { get; set; }
        public string age { get; set; }
        public string email_address { get; set; }
        public string grade { get; set; }
        public string section { get; set; }
        public string school_year { get; set; }
    }
}
