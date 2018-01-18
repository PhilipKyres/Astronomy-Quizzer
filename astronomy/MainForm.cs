using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace astronomy
{
    public partial class MainQuizForm : Form
    {
        public MainQuizForm()
        {
            InitializeComponent();
        }

        private static List<Question> questions;
        private static List<Question> remainingQuestions;
        private static List<Question> wrongQuestions;

        private int total = 0;
        private static Question q;
        private static bool corrected;

        private static int right = 0;
        private static int wrong = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            updateScore();

            loadNext();
        }

        private void init()
        {
            string input = "";
            try
            {
                input = File.ReadAllText("bank.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("\"bank.txt\" must be in the same directory as the exe!");
                Environment.Exit(0);
            }

            string[] lines = input.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            int lineNum = 0;

            wrongQuestions = new List<Question>();
            questions = new List<Question>();
            string chapter = "Chapter ?";
            string section = "?.?";

            while (lineNum < lines.Length)
            {
                Question question = new Question();

                string line = lines[lineNum].Trim();
                while (!Regex.IsMatch(line, "^[0-9]*\\)"))
                {
                    if (line.StartsWith("Chapter "))
                        chapter = line;
                    else if (Regex.IsMatch(line, "^[0-9]*\\.[0-9]* "))
                        section = line;

                    lineNum++;
                    line = lines[lineNum].Trim();
                }

                question.question = line;
                lineNum++;
                line = lines[lineNum].Trim();

                while (!Regex.IsMatch(line, "^[A-F]\\)") && !line.StartsWith("Answer: ") && !Regex.IsMatch(line, "^[0-9]*\\)"))
                {
                    question.question = question.question + " " + line;
                    lineNum++;
                    line = lines[lineNum].Trim();
                }

                if (Regex.IsMatch(line, "^[0-9]*\\)"))
                    continue; 

                List<string> choices = new List<string>();

                while (true)
                {
                    line = lines[lineNum].Trim();
                    lineNum++;

                    if (Regex.IsMatch(line, "^[A-F]\\)"))
                        choices.Add(line);
                    else if (line.StartsWith("Answer: "))
                        break;
                    else
                        choices[choices.Count - 1] = choices[choices.Count - 1] + " " + line;
                }

                string ans = line.Substring(8);

                if (ans.Contains(" "))
                    continue;

                if (choices.Count < 1)
                {
                    choices.Add("TRUE");
                    choices.Add("FALSE");

                    if (ans == "TRUE")
                        question.answer = 0;
                    else if (ans == "FALSE")
                        question.answer = 1;
                }
                else
                    question.answer = ans[0] - 'A';

                if (choices.Count < 1)
                    continue;

                question.chapter = chapter + " - " + section;
                question.choices = choices;
                questions.Add(question);
            }

            total = questions.Count;
            remainingQuestions = questions.ConvertAll(qu => new Question(qu));
        }

        private void loadNext()
        {
            if (remainingQuestions.Count < 1)
            {
                MessageBox.Show("Out of questions! Restarting");
                remainingQuestions = questions.ConvertAll(qu => new Question(qu));
                total = questions.Count;
                wrongQuestions.Clear();
                resetScore();
            }

            var random = new Random();
            int i = random.Next(remainingQuestions.Count);
            q = remainingQuestions[i];
            remainingQuestions.RemoveAt(i);

            this.Text = $"Astronomy Quizzer v1.2 - {q.chapter}";
            int count = total - remainingQuestions.Count;
            totalsLabel.Text = $"{count} of {total}";
            questionTextBox.Text = q.question;

            choicesGridView.DataSource = q.choices.ConvertAll(x => new { Choices = x });
            choicesGridView.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            choicesGridView.ClearSelection();
            choicesGridView.Enabled = true;

            corrected = false;
        }

        private void correct()
        {
            int row = choicesGridView.CurrentCell.RowIndex;
            if (!choicesGridView.Rows[row].Cells[0].Selected)
            {
                MessageBox.Show("Select an answer!");
                return;
            }

            choicesGridView.ClearSelection();
            choicesGridView.Enabled = false;

            if (q.answer == row)
            {
                //correct
                right++;
                choicesGridView.Rows[row].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            else
            {
                //incorrect
                wrong++;
                choicesGridView.Rows[row].DefaultCellStyle.BackColor = Color.IndianRed;
                choicesGridView.Rows[q.answer].DefaultCellStyle.BackColor = Color.LightGreen;
                wrongQuestions.Add(q);
            }

            updateScore();
            corrected = true;
        }

        private void resetScore()
        {
            right = wrong = 0;
            updateScore();
        }

        private void updateScore()
        {
            rightLabel.Text = right.ToString();
            wrongLabel.Text = wrong.ToString();
        }

        private void go()
        {
            if (corrected)
                loadNext();
            else
                correct();

            ActiveControl = done;
        }

        private void keyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Space)
            {
                go();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            if (!choicesGridView.Enabled)
                return;

            if ((e.KeyData == Keys.A || e.KeyData == Keys.D1) && q.choices.Count > 0)
                choicesGridView.Rows[0].Cells[0].Selected = true;
            else if ((e.KeyData == Keys.B || e.KeyData == Keys.D2) && q.choices.Count > 1)
                choicesGridView.Rows[1].Cells[0].Selected = true;
            else if ((e.KeyData == Keys.C || e.KeyData == Keys.D3) && q.choices.Count > 2)
                choicesGridView.Rows[2].Cells[0].Selected = true;
            else if ((e.KeyData == Keys.D || e.KeyData == Keys.D4) && q.choices.Count > 3)
                choicesGridView.Rows[3].Cells[0].Selected = true;
            else if ((e.KeyData == Keys.E || e.KeyData == Keys.D5) && q.choices.Count > 4)
                choicesGridView.Rows[4].Cells[0].Selected = true;
            else if (e.KeyData == Keys.D6)
                choicesGridView.Rows[5].Cells[0].Selected = true;
            else if (e.KeyData == Keys.F)
            {
                if (q.choices.Count == 2)
                    choicesGridView.Rows[1].Cells[0].Selected = true;
                else if (q.choices.Count > 5)
                    choicesGridView.Rows[5].Cells[0].Selected = true;
                else
                    return;
            }
            else if (e.KeyData == Keys.T && q.choices.Count == 2)
                choicesGridView.Rows[0].Cells[0].Selected = true;
            else
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void done_Click(object sender, EventArgs e)
        {
            go();
        }

        private void questionTextBox_Enter(object sender, EventArgs e)
        {
            ActiveControl = choicesGridView;
        }

        private void reviewBtn_Click(object sender, EventArgs e)
        {
            if (wrongQuestions.Count < 1)
                return;

            resetScore();
            remainingQuestions = wrongQuestions.ConvertAll(qu => new Question(qu));
            total = wrongQuestions.Count;
            wrongQuestions.Clear();
            loadNext();
        }
    }

    public struct Question
    {
        public string chapter;
        public string question;
        public List<string> choices;
        public int answer;

        public Question(Question q)
        {
            this.chapter = q.chapter;
            this.question = q.question;
            this.choices = q.choices;
            this.answer = q.answer;
        }
    }
}
