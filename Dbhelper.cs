using MySqlConnector;

namespace MIDParactice
{

    class Dbhelper
    {


        private string connectionString = "Server=localhost;Database=test;User ID=root;Password=abc1234r;";

        public List<Course> fetchdata()
        {
            List<Course> courses = new List<Course>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM courses";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Course course = new Course()
                        {
                            course_code = reader.GetString("course_code"),
                            course_name = reader.GetString("course_name"),
                            credits = reader.GetInt32("credits")
                        };
                        courses.Add(course);
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e.Message);
                }
                return courses;
            }

        }


        public void InsertItems(string name, string code, int credits)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Insert Into courses (course_code,course_name,credits) Values (@code,@name,@credits)";

                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@credits", credits);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e.Message);
                }


            }


        }

        public void DeleteItems(string code)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Delete from courses where course_code = @code";
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }
                catch (Exception e)
                {

                    MessageBox.Show($" Error {e.Message}");

                }


            }


        }


        public void Updatedata(Course course)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE courses set course_name = @name,credits = @credit where course_code = @code";
                    cmd.Parameters.AddWithValue("@code", course.course_code);
                    cmd.Parameters.AddWithValue("@name", course.course_name);
                    cmd.Parameters.AddWithValue("@credit", course.credits);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show("ERROR", e.Message);
                }

            }

        }
    }
}


