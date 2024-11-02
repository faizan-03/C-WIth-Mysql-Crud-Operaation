namespace MIDParactice
{
    public partial class Deleteform : Form
    {
        Dbhelper db = new Dbhelper();
        List<Course> courses = new List<Course>();
        public Deleteform()
        {
            InitializeComponent();
        }

        private void Deleteform_Load(object sender, EventArgs e)
        {
            courses = db.fetchdata();
            show_courseGrid.DataSource = courses;

        }

        private void Cancel_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE you sure you want to delete?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                db.DeleteItems(DeleteText.Text);
                courses = db.fetchdata();
                show_courseGrid.DataSource = courses;
            }
            else
            {
                this.Close();
            }
        }
    }
}
