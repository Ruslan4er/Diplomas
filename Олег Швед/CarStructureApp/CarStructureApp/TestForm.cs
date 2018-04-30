using CarStructureDAL;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarStructureApp
{
    public partial class TestForm : Form
    {
        private List<Question> _questions;
        private List<List<Answer>> _answers;
        private int _questionId;
        private int _correctAnswers;

        public TestForm(int chapterId)
        {
            InitializeComponent();
            FillData(chapterId);
            if (_questions.Count != 0)
                NextQuestion();
            else
                NextQuestionButton.Enabled = false;

        }

        private void FillData(int chapterId)
        {
            using (var context = new СarStructureDBEntities())
            {
                var q = from ch in context.Chapters
                        where ch.id == chapterId
                        select ch.Questions;
                foreach (var element in q)
                    _questions = new List<Question>(element);

                _answers = new List<List<Answer>>();
                foreach (var question in _questions)
                    _answers.Add(new List<Answer>(question.Answers));
                TopicLabel.Text = context.Chapters.Find(chapterId)?.Name;
            }
        }

        private void CheckAnswers()
        {
            Answer correctAnswer = null;
            foreach (var answer in _answers[_questionId])
                if (answer.IsCorrectAnswer)
                    correctAnswer = answer;

            if (Answer1RadioButton.Checked && Answer1RadioButton.Text == correctAnswer.Text)
                _correctAnswers++;

            if (Answer2RadioButton.Checked && Answer2RadioButton.Text == correctAnswer.Text)
                _correctAnswers++;

            if (Answer3RadioButton.Checked && Answer3RadioButton.Text == correctAnswer.Text)
                _correctAnswers++;


            Answer1RadioButton.Checked = false;
            Answer2RadioButton.Checked = false;
            Answer3RadioButton.Checked = false;
        }

        private void NextQuestion()
        {
            if (_questionId == _questions.Count)
            {
                NextQuestionButton.Enabled = false;
                QuestionLabel.Text = $@"Правильных ответов - {_correctAnswers}";
                Answer1RadioButton.Hide();
                Answer2RadioButton.Hide();
                Answer3RadioButton.Hide();

                return;
            }
            if (_questionId == _questions.Count - 1)
                NextQuestionButton.Text = @"Завершить";

            QuestionLabel.Text = _questions[_questionId].Text;
            Answer1RadioButton.Text = _answers[_questionId][0].Text;
            Answer2RadioButton.Text = _answers[_questionId][1].Text;
            Answer3RadioButton.Text = _answers[_questionId][2].Text;

            CheckAnswers();
            _questionId++;
            QuestionCounterLabel.Text = $@"Вопрос {_questionId} из {_questions.Count}";

        }

        private void NextQuestionButton_Click(object sender, System.EventArgs e)
        {
            NextQuestion();
        }

        private void HomeButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
