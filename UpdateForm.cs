namespace MIDParactice
{
    public partial class UpdateForm : Form
    {
        Dbhelper db = new Dbhelper();

        List<Course> courses = new List<Course>();
        public Course course { get; set; }
        public UpdateForm(Course cours)
        {

            InitializeComponent();
            course = cours;
            UTextcode.Text = cours.course_code;
            UTextname.Text = cours.course_name;
            UTextcredits.Text = cours.credits.ToString();
        }

        private void ucancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            courses = db.fetchdata();
            show_courseGrid.DataSource = courses;
        }

        private void Ubtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE you sure you want to Update?", "Confirm Update ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                course.course_code = UTextcode.Text;
                course.course_name = UTextname.Text;
                course.credits = int.Parse(UTextcredits.Text);
                db.Updatedata(course);
                courses = db.fetchdata();
                show_courseGrid.DataSource = null;
                show_courseGrid.DataSource = courses;
            }
            else
            {
                this.Close();
            }
        }
    }
}
