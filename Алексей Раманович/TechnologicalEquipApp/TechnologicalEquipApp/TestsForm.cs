using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnologicalEquipApp
{
    public partial class TestsForm : Form
    {
        //private List<Question> questions;
        //private List<List<Answer>> answers;
        private int questionId;
        private int correctAnswers;


        public TestsForm()
        {
            InitializeComponent();
            splitContainer2.Panel2.Hide();
            //FillData(chapterId);
            //if (questions.Count != 0)
            //    NextQuestion();
            //else
            //    NextQuestionButton.Enabled = false;
        }

        private void FillData(int chapterId)
        {
            //using (var context = new LearningToolDBEntities())
            //{
            //    var questions = from ch in context.Chapters
            //        where ch.Id == chapterId
            //        select ch.Questions;
            //    foreach (var q in questions)
            //        questionList = new List<Question>(q);

            //    answersList = new List<List<Answer>>();
            //    foreach (var question in questionList)
            //        answersList.Add(new List<Answer>(question.Answers));
            //}
        }

        private void ShowTestsPanel(int chapterId)
        {
            //questions.Clear();
            //answers.Clear();
            FillData(chapterId);
            NextQuestion();
        }

        private void ContentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = ContentTreeView.SelectedNode.Name;
            if (!int.TryParse(selectedNode, out var a))
                return;
            ShowTestsPanel(int.Parse(selectedNode));
        }


        private void CheckAnswers()
        {
            //    Answer correctAnswer = null;
            //    foreach (var answer in answers[questionId])
            //        if (answer.IsCorrect)
            //            correctAnswer = answer;

            //    if (Answer1RadioButton.Checked && Answer1RadioButton.Text == correctAnswer.Text)
            //        correctAnswers++;

            //    if (Answer2RadioButton.Checked && Answer2RadioButton.Text == correctAnswer.Text)
            //        correctAnswers++;

            //    if (Answer3RadioButton.Checked && Answer3RadioButton.Text == correctAnswer.Text)
            //        correctAnswers++;


            //    Answer1RadioButton.Checked = false;
            //    Answer2RadioButton.Checked = false;
            //    Answer3RadioButton.Checked = false;
        }

        private void NextQuestion()
        {
            //    if (questionId == questions.Count)
            //    {
            //        NextQuestionButton.Enabled = false;
            //        QuestionLabel.Text = $@"Правильных ответов - {correctAnswers}";
            //        Answer1RadioButton.Hide();
            //        Answer2RadioButton.Hide();
            //        Answer3RadioButton.Hide();

            //        return;
            //    }
            //    if (questionId == questions.Count - 1)
            //        NextQuestionButton.Text = @"Завершить";

            //    QuestionLabel.Text = questions[questionId].Text;
            //    Answer1RadioButton.Text = answers[questionId][0].Text;
            //    Answer2RadioButton.Text = answers[questionId][1].Text;
            //    Answer3RadioButton.Text = answers[questionId][2].Text;

            //    CheckAnswers();
            //    questionId++;
            //    QuestionCounterLabel.Text = $@"Вопрос {questionId} из {questions.Count}";

        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }
    }
}
