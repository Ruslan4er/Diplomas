using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceDAL;

namespace СarServiceApplication
{
    public partial class TestsForm : Form
    {
        private List<Question> questions;
        private List<List<Answer>> answers;
        private int questionId;
        private int correctAnswers;
        private string chapterName;

        public TestsForm(int chapterId)
        {
            InitializeComponent();
            FillData(chapterId);
            if (questions.Count != 0)
                NextQuestion();
            else
                NextQuestionButton.Enabled = false;
            CloseButton.Enabled = false;
        }

        private void FillData(int chapterId)
        {
            using (var context = new CarServiceDBEntities())
            {
                chapterName = context.Chapters.Find(chapterId).Name;
                var q = from ch in context.Chapters
                        where ch.Id == chapterId
                        select ch.Questions;
                foreach (var element in q)
                    questions = new List<Question>(element);

                answers = new List<List<Answer>>();
                foreach (var question in questions)
                    answers.Add(new List<Answer>(question.Answers));
            }
        }

        private void CheckAnswer()
        {
            Answer correctAnswer = null;
            foreach (var answer in answers[questionId])
                if (answer.IsCorrect)
                    correctAnswer = answer;

            if (Answer1RadioButton.Checked && Answer1RadioButton.Text == correctAnswer.Text)
                correctAnswers++;

            if (Answer2RadioButton.Checked && Answer2RadioButton.Text == correctAnswer.Text)
                correctAnswers++;

            if (Answer3RadioButton.Checked && Answer3RadioButton.Text == correctAnswer.Text)
                correctAnswers++;


            Answer1RadioButton.Checked = false;
            Answer2RadioButton.Checked = false;
            Answer3RadioButton.Checked = false;
        }

        private void NextQuestion()
        {
            if (questionId == questions.Count)
            {
                NextQuestionButton.Enabled = false;
                QuestionLabel.Text = $@"Правильных ответов - {correctAnswers}";
                Answer1RadioButton.Hide();
                Answer2RadioButton.Hide();
                Answer3RadioButton.Hide();

                SaveResult();
                CloseButton.Enabled = true;
                NextQuestionButton.Enabled = false;
                return;
            }
            if (questionId == questions.Count - 1)
                NextQuestionButton.Text = @"Завершить";

            QuestionLabel.Text = questions[questionId].Text;
            Answer1RadioButton.Text = answers[questionId][0].Text;
            Answer2RadioButton.Text = answers[questionId][1].Text;
            Answer3RadioButton.Text = answers[questionId][2].Text;

            CheckAnswer();
            questionId++;
            QuestionCounterLabel.Text = $@"Вопрос {questionId} из {questions.Count}";
        }


        private bool AnswerIsSelected()
        {
            if (Answer1RadioButton.Checked) return true;
            if (Answer2RadioButton.Checked) return true;
            if (Answer3RadioButton.Checked) return true;
            return false;
        }

        private void SaveResult()
        {
            using (var context = new CarServiceDBEntities())
            {
                try
                {
                    context.TestingResults.Add(new TestingResult
                    {
                        Date = DateTime.Now,
                        Mark = correctAnswers,
                        UserId = UserData.UserId,
                        Chapter = chapterName
                    });
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(@"Результат не сохранён. Авторизируйтесь!");
                    MessageBox.Show(e.Message);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (!AnswerIsSelected())
            {
                MessageBox.Show(@"Не выбран ни один ответ!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            NextQuestion();
        }
    }
}
