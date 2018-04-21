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
using RadioButton = System.Windows.Controls.RadioButton;

namespace СarServiceApplication
{
    public partial class TestsForm : Form
    {
        private List<Question> questions;
        private List<List<Answer>> answers;
        private int questionId;
        private int correctAnswers;

        public TestsForm(int chapterId)
        {
            InitializeComponent();
            FillData(chapterId);
            NextQuestion();
        }

        private void FillData(int chapterId)
        {
            using (var context = new CarServiceDBEntities())
            {
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

        private void CheckAnswers()
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
            if (questionId == questions.Count - 1)
            {
                NextQuestionButton.Enabled = false;
                QuestionLabel.Text = $@"Правильных ответов - {correctAnswers}";
                return;
            }
            if (questionId == questions.Count - 2)
                NextQuestionButton.Text = @"Завершить";

            QuestionLabel.Text = questions[questionId].Text;
            Answer1RadioButton.Text = answers[questionId][0].Text;
            Answer2RadioButton.Text = answers[questionId][1].Text;
            Answer3RadioButton.Text = answers[questionId][2].Text;

            CheckAnswers();
            questionId++;
            QuestionCounterLabel.Text = $@"Вопрос {questionId} из {questions.Count}";

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }
    }
}
