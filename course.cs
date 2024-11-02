namespace MIDParactice
{
    public class Course
    {
        public string course_code { get; set; }
        public string course_name { get; set; }

        public int credits { get; set; }

        public Course()
        {
            credits = 0;
            course_code = string.Empty;
            course_name = string.Empty;
        }

    }
}
