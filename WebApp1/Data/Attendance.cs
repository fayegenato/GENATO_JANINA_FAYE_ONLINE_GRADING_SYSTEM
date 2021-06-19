using System;
namespace WebApp1.Data
{
    public class Attendance
    {
        public Attendance()
        {
        }
        
        public string student_id { get; set; }
        public string days{ get; set; }
        public string month { get; set; }
        public string days_of_classes { get; set; }
        public string days_of_present { get; set; }
    }
}
