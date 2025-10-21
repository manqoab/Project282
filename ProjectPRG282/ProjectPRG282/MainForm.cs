using System.Xml.Linq;
using System.IO;

namespace ProjectPRG282
{
    public partial class MainForm : Form
    {
        string filePath = "superheroes.txt";
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filePath = "superheroes.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No data file found to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(IdText.Text))
                {
                    MessageBox.Show("Please enter the ID of the superhero to update.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(examScoreText.Text, out int score) || score < 0 || score > 100)
                {
                    MessageBox.Show("Please enter a valid Exam Score between 0 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Recalculate rank and threat
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

                // Read all lines
                var lines = File.ReadAllLines(filePath).ToList();
                bool updated = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains($"ID:{IdText.Text}"))
                    {
                        lines[i] = $"ID:{IdText.Text}, Name:{nameText.Text}, Age:{ageText.Text}, Superpower:{superpowerText.Text}, Exam Score:{score}, Rank:{rank}, Threat Level:{threat}";
                        updated = true;
                        break;
                    }
                }

                if (updated)
                {
                    File.WriteAllLines(filePath, lines);
                    MessageBox.Show("Superhero information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Superhero with the specified ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating superhero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string filePath = "superheroes.txt";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No data file found to delete from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (string.IsNullOrWhiteSpace(IdText.Text))
                {
                    MessageBox.Show("Please enter the ID of the superhero to delete.", "Missing ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var lines = File.ReadAllLines(filePath).ToList();
                int beforeCount = lines.Count;

                // Remove all lines that match the ID
                lines = lines.Where(line => !line.Contains($"ID:{IdText.Text}")).ToList();

                if (lines.Count == beforeCount)
                {
                    MessageBox.Show("Superhero not found. Please check the ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Superhero deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting superhero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSuperheroes()
        {
            try
            {
                dataGridView1.Rows.Clear();

                if (!File.Exists(filePath))
                    return;

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(',');
                    if (parts.Length >= 7)
                    {
                        string id = parts[0].Split(':')[1].Trim();
                        string name = parts[1].Split(':')[1].Trim();
                        string age = parts[2].Split(':')[1].Trim();
                        string superpower = parts[3].Split(':')[1].Trim();
                        string score = parts[4].Split(':')[1].Trim();
                        string rank = parts[5].Split(':')[1].Trim();
                        string threat = parts[6].Split(':')[1].Trim();

                        dataGridView1.Rows.Add(id, name, age, superpower, score, rank, threat);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading superheroes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    IdText.Text = row.Cells[0].Value?.ToString();
                    nameText.Text = row.Cells[1].Value?.ToString();
                    ageText.Text = row.Cells[2].Value?.ToString();
                    superpowerText.Text = row.Cells[3].Value?.ToString();
                    examScoreText.Text = row.Cells[4].Value?.ToString();
                    rankText.Text = row.Cells[5].Value?.ToString();
                    threatLevelText.Text = row.Cells[6].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LoadSuperheroes1()
        {
            dataGridView1.Rows.Clear();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No superhero records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(',');

                // Make sure each part has a colon and at least 7 parts
                if (parts.Length < 7) continue;

                try
                {
                    string id = parts[0].Contains(":") ? parts[0].Split(':')[1].Trim() : "";
                    string name = parts[1].Contains(":") ? parts[1].Split(':')[1].Trim() : "";
                    string age = parts[2].Contains(":") ? parts[2].Split(':')[1].Trim() : "";
                    string superpower = parts[3].Contains(":") ? parts[3].Split(':')[1].Trim() : "";
                    string score = parts[4].Contains(":") ? parts[4].Split(':')[1].Trim() : "";
                    string rank = parts[5].Contains(":") ? parts[5].Split(':')[1].Trim() : "";
                    string threat = parts[6].Contains(":") ? parts[6].Split(':')[1].Trim() : "";

                    dataGridView1.Rows.Add(id, name, age, superpower, score, rank, threat);
                }
                catch
                {
                    // Skip any malformed line
                    continue;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadSuperheroes1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Make sure a valid row is clicked
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    IdText.Text = row.Cells[0].Value?.ToString();
                    nameText.Text = row.Cells[1].Value?.ToString();
                    ageText.Text = row.Cells[2].Value?.ToString();
                    superpowerText.Text = row.Cells[3].Value?.ToString();
                    examScoreText.Text = row.Cells[4].Value?.ToString();
                    rankText.Text = row.Cells[5].Value?.ToString();
                    threatLevelText.Text = row.Cells[6].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting row: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = "superheroes.txt";
                string summaryPath = "summary.txt";

                if (!File.Exists(filepath))
                {
                    MessageBox.Show("No superhero records found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(filepath);

                if (lines.Length == 0)
                {
                    MessageBox.Show("The superhero file is Empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Variables for Calculation====================================

                int totalHeroes = 0;
                double totalAge = 0;
                double totalScore = 0;
                int sRank = 0, aRank = 0, bRank = 0, cRank = 0;

                foreach (string line in lines) 
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(',');
                    if (parts.Length < 7) continue;

                    try
                    {
                        //Extract Age and Exam Score
                        string agePart = parts[2].Split(':')[1].Trim();
                        string scorePart = parts[4].Split(':')[1].Trim();
                        string rankPart = parts[5].Split(':')[1].Trim();

                        if (int.TryParse(agePart, out int age))
                            totalAge += age;

                        if (int.TryParse(agePart, out int score))
                            totalScore += score;

                        //Count the ranks
                        switch (rankPart)
                        {
                            case "S-Rank": 
                                sRank++; 
                                break;
                            case "A-Rank":
                                aRank++;
                                break;
                            case "B-Rank":
                                bRank++;
                                break;
                            case "C-Rank":
                                cRank++;
                                break;
                            default:
                                break;
                        }

                        totalHeroes++;
                    }
                    catch 
                    {
                        //Skip malformed lines
                        continue;
                    }
                }

                if (totalHeroes == 0)
                {
                    MessageBox.Show("The superhero file is Empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Calculate averages
                double avgAge = totalAge / totalHeroes;
                double avgScore = totalScore / totalHeroes;

                //Create summary text
                string summary = 
                    "================= Superhero Summary Report ===============\n" +
                    $"Total Superheroes: {totalHeroes}\n" +
                    $"Average Age: {avgAge:F2}\n" +
                    $"Average Exam Score: {avgScore:F2}\n" +
                    "------ Heroes Per Rank ------\n" +
                    $"S-Rank: {sRank}\n" +
                    $"A-Rank: {aRank}\n" +
                    $"B-Rank: {bRank}\n" +
                    $"C-Rank: {cRank}\n" +
                    $"=========================================================\n" +
                    $"Repert Generated On: {DateTime.Now}\n";

                //Save the summary to a file
                File.WriteAllText(summaryPath, summary);

                //Show summary message
                MessageBox.Show(
                    "===== Superhero Summary Report =====\n" +
                    $"Total Heroes: {totalHeroes}\n" +
                    $"Average Age: {avgAge:F2}\n" +
                    $"Average Score: {avgScore:F2}", 
                    "Summary Generated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating summary: " + ex.Message, "Summary Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
