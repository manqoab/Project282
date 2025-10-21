namespace ProjectPRG282
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            examScoreText = new TextBox();
            ageText = new TextBox();
            superpowerText = new TextBox();
            nameText = new TextBox();
            IdText = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rankButton = new Button();
            saveButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            groupBox2 = new GroupBox();
            threatLevelText = new TextBox();
            rankText = new TextBox();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            age = new DataGridViewTextBoxColumn();
            superpwer = new DataGridViewTextBoxColumn();
            examscore = new DataGridViewTextBoxColumn();
            button3 = new Button();
            btnSummary = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(38, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 51);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(652, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "SUPERHERO REGISTRATION FORM";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(examScoreText);
            groupBox1.Controls.Add(ageText);
            groupBox1.Controls.Add(superpowerText);
            groupBox1.Controls.Add(nameText);
            groupBox1.Controls.Add(IdText);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 230);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ENTER SUPERHERO DETAILS:";
            // 
            // examScoreText
            // 
            examScoreText.BorderStyle = BorderStyle.FixedSingle;
            examScoreText.Location = new Point(326, 190);
            examScoreText.Name = "examScoreText";
            examScoreText.Size = new Size(345, 27);
            examScoreText.TabIndex = 5;
            examScoreText.TextChanged += textBox6_TextChanged;
            // 
            // ageText
            // 
            ageText.BorderStyle = BorderStyle.FixedSingle;
            ageText.Location = new Point(326, 111);
            ageText.Name = "ageText";
            ageText.Size = new Size(345, 27);
            ageText.TabIndex = 3;
            // 
            // superpowerText
            // 
            superpowerText.BorderStyle = BorderStyle.FixedSingle;
            superpowerText.Location = new Point(326, 152);
            superpowerText.Name = "superpowerText";
            superpowerText.Size = new Size(345, 27);
            superpowerText.TabIndex = 4;
            // 
            // nameText
            // 
            nameText.BorderStyle = BorderStyle.FixedSingle;
            nameText.Location = new Point(326, 69);
            nameText.Name = "nameText";
            nameText.Size = new Size(345, 27);
            nameText.TabIndex = 2;
            nameText.TextChanged += textBox3_TextChanged;
            // 
            // IdText
            // 
            IdText.BorderStyle = BorderStyle.FixedSingle;
            IdText.Location = new Point(326, 36);
            IdText.Name = "IdText";
            IdText.Size = new Size(345, 27);
            IdText.TabIndex = 1;
            IdText.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 193);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 4;
            label5.Text = "EXAM SCORE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 155);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 3;
            label4.Text = "SUPERPOWER:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 114);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "AGE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 73);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "NAME:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 39);
            label1.Name = "label1";
            label1.Size = new Size(29, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // rankButton
            // 
            rankButton.BackColor = Color.FromArgb(192, 192, 0);
            rankButton.Location = new Point(882, 105);
            rankButton.Name = "rankButton";
            rankButton.Size = new Size(121, 43);
            rankButton.TabIndex = 2;
            rankButton.Text = " RANK";
            rankButton.UseVisualStyleBackColor = false;
            rankButton.Click += button1_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Cyan;
            saveButton.Location = new Point(882, 154);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(121, 41);
            saveButton.TabIndex = 3;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += button2_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.Location = new Point(882, 201);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(121, 43);
            clearButton.TabIndex = 4;
            clearButton.Text = "CLEAR ALL";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Gray;
            exitButton.Location = new Point(882, 250);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(121, 43);
            exitButton.TabIndex = 5;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(threatLevelText);
            groupBox2.Controls.Add(rankText);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(38, 321);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(825, 117);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // threatLevelText
            // 
            threatLevelText.Location = new Point(326, 77);
            threatLevelText.Name = "threatLevelText";
            threatLevelText.Size = new Size(345, 27);
            threatLevelText.TabIndex = 3;
            threatLevelText.TextChanged += textBox8_TextChanged;
            // 
            // rankText
            // 
            rankText.Location = new Point(326, 36);
            rankText.Name = "rankText";
            rankText.Size = new Size(230, 27);
            rankText.TabIndex = 2;
            rankText.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 77);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 1;
            label7.Text = "THREAT LEVEL:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 39);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 0;
            label6.Text = "RANK:";
            // 
            // button1
            // 
            button1.Location = new Point(882, 321);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 4;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(882, 360);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 7;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, name, age, superpwer, examscore });
            dataGridView1.Location = new Point(190, 444);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(673, 332);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "NAME";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // age
            // 
            age.HeaderText = "AGE";
            age.MinimumWidth = 6;
            age.Name = "age";
            age.Width = 125;
            // 
            // superpwer
            // 
            superpwer.HeaderText = "SUPERPOWER";
            superpwer.MinimumWidth = 6;
            superpwer.Name = "superpwer";
            superpwer.Width = 125;
            // 
            // examscore
            // 
            examscore.HeaderText = "EXAM SCORE";
            examscore.MinimumWidth = 6;
            examscore.Name = "examscore";
            examscore.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(882, 398);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 9;
            button3.Text = "VIEW ALL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnSummary
            // 
            btnSummary.Location = new Point(882, 474);
            btnSummary.Name = "btnSummary";
            btnSummary.Size = new Size(173, 29);
            btnSummary.TabIndex = 10;
            btnSummary.Text = "Summary report";
            btnSummary.UseVisualStyleBackColor = true;
            btnSummary.Click += btnSummary_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 861);
            Controls.Add(btnSummary);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(saveButton);
            Controls.Add(rankButton);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "SUPERHERO REGISTRATION FORM";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox examScoreText;
        private TextBox ageText;
        private TextBox superpowerText;
        private TextBox nameText;
        private TextBox IdText;
        private Label label5;
        private Label label4;
        private Button rankButton;
        private Button saveButton;
        private Button clearButton;
        private Button exitButton;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private TextBox threatLevelText;
        private TextBox rankText;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn age;
        private DataGridViewTextBoxColumn superpwer;
        private DataGridViewTextBoxColumn examscore;
        private Button btnSummary;
    }
}
