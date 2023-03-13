using Data_Base_Project.Forms;

namespace Data_Base_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (Form_DashBoard fd=new Form_DashBoard())
            {
                fd.ShowDialog();
            }
        }
    }
}