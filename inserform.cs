namespace MIDParactice
{
    public partial class inserform : Form
    {
        internal Course Insert { get; }   // read only property 

        public inserform()
        {
            InitializeComponent();
            Insert = new Course();   // Create instance of Course to get the acces of data
        }


        void GUITODATA()
        {
            Insert.course_code = Textcode.Text;
            Insert.course_name = Textname.Text;
            Insert.credits = int.Parse(Textcredits.Text);
        }
        private void IcancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUITODATA();

            this.DialogResult = DialogResult.OK;
            this.Close();  
        }
    }
}
