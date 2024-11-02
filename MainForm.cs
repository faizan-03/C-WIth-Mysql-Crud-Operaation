using MySqlConnector;


namespace MIDParactice
{
    public partial class MainForm : Form
    {
        Dbhelper db = new Dbhelper();
        List<Course> courses = new List<Course>();
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            courses = db.fetchdata();
            show_courseGrid.DataSource = courses;

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            var insertform = new inserform();
            if (insertform.ShowDialog() == DialogResult.OK)
            {
                db.InsertItems(insertform.Insert.course_name, insertform.Insert.course_code, insertform.Insert.credits);
                courses = db.fetchdata();
                show_courseGrid.DataSource = null;
                show_courseGrid.DataSource = courses;
            }


        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            var deleteform = new Deleteform();
            if (deleteform.ShowDialog() == DialogResult.OK)
            {
                courses = db.fetchdata();
                show_courseGrid.DataSource = null;
                show_courseGrid.DataSource = courses;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (show_courseGrid.SelectedRows.Count > 0) {

                var select_course = (Course)show_courseGrid.SelectedRows[0].DataBoundItem;
                var updateform = new UpdateForm(select_course);

                if(updateform.ShowDialog() == DialogResult.OK)
                {
                    db.Updatedata(select_course);
                    courses = db.fetchdata();
                    show_courseGrid.DataSource = courses;
                    this.Close();
                }
            
            }
            else
            {
                MessageBox.Show("Please select an item to update");
            }

        }
    }
}
