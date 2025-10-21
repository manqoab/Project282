using System.Xml.Linq
using System.IO;

namespace ProjectPRG282
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            IdText.Clear();
            nameText.Clear();
            ageText.Clear();
            superpowerText.Clear();
            examScoreText.Clear();
            rankText.Text = "";
            threatLevelText.Text = "";
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(examScoreText.Text, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("Please enter a valid Exam Score between 0 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rank, threat;

            if (score >= 81)
            {
                rank = "S-Rank";
                threat = "Finals Week (threat to the entire academy)";
            }
            else if (score >= 61)
            {
                rank = "A-Rank";
                threat = "Midterm Madness (threat to a department)";
            }
            else if (score >= 41)
            {
                rank = "B-Rank";
                threat = "Group Project Gone Wrong (threat to a study group)";
            }
            else
            {
                rank = "C-Rank";
                threat = "Pop Quiz (potential threat to an individual student)";
            }

            rankText.Text = rank;
            threatLevelText.Text = threat;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Input validation
                if (string.IsNullOrWhiteSpace(IdText.Text) ||
                    string.IsNullOrWhiteSpace(nameText.Text) ||
                    string.IsNullOrWhiteSpace(ageText.Text) ||
                    string.IsNullOrWhiteSpace(superpowerText.Text) ||
                    string.IsNullOrWhiteSpace(examScoreText.Text))
                {
                    MessageBox.Show("All fields must be filled in before saving.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(ageText.Text, out int age) || age <= 0)
                {
                    MessageBox.Show("Please enter a valid numeric Age.", "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(examScoreText.Text, out int score) || score < 0 || score > 100)
                {
                    MessageBox.Show("Please enter a valid Exam Score (0–100).", "Invalid Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // calculate rank and threat level of the superhero
                string rank, threat;

                if (score >= 81)
                {
                    rank = "S-Rank";
                    threat = "Finals Week (threat to the entire academy)";
                }
                else if (score >= 61)
                {
                    rank = "A-Rank";
                    threat = "Midterm Madness (threat to a department)";
                }
                else if (score >= 41)
                {
                    rank = "B-Rank";
                    threat = "Group Project Gone Wrong (threat to a study group)";
                }
                else
                {
                    rank = "C-Rank";
                    threat = "Pop Quiz (potential threat to an individual student)";
                }

                // Prepare the data line
                string heroData = $"ID:{IdText.Text}, Name:{nameText.Text}, Age:{age}, Superpower:{superpowerText.Text}, Exam Score:{score}, Rank:{rank},Threat Level:{threat}";

                // Save to text file (appends to existing file)
                
                using (StreamWriter writer = new StreamWriter("superheroes.txt", true))
                {
                    writer.WriteLine(heroData);
                }

                MessageBox.Show("Superhero added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //  Clears the fields after saving
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving superhero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
