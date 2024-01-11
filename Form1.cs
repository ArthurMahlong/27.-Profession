namespace _27._Profession
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Teacher");
            comboBox1.Items.Add("Engineer");
            comboBox1.Items.Add("Lecture");
            comboBox1.Items.Add("Nurse");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string profession = "";

            profession = comboBox1.Text;

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Name or Profession must not be empty ");
            }
            else
            {
                MessageBox.Show("Hi " + textBox1.Text + " Your Profession is " + comboBox1.Text + " and you are a " +
                  profession );
            }

            string gender = "";

            if (rbMale.Checked) 
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            else if (rbOther.Checked) 
            {
                gender = "other";
            }
            else
            {
                gender = "other";   
            }

            



        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }
    }
}
