namespace librarymanagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Members MembersInfo = new Members();
            MembersInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Books BooksInfo = new Books();
            BooksInfo.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Record RecordsInfo = new Record();
            RecordsInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
