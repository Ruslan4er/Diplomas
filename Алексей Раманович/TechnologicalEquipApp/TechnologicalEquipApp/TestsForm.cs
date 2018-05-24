using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnologicalEqueipAppDAL;
using TechnologicalEquipApp.Authorization;

namespace TechnologicalEquipApp
{
    public partial class TestsForm : Form
    {
        public TestsForm()
        {
            InitializeComponent();
            splitContainer2.Panel2.Hide();
        }

        private List<Question> questionList;
        private List<List<Answer>> answersList;
        private int questionId;
        private int correctAnswers;
        private bool IsFirstOpen = true;
        private string topic;
        private bool temp = false;

        private void FillData(int chapterId)
        {
            using (var context = new TechnologicalEquipAppDBEntities())
            {
                var questions = from ch in context.Chapters
                                where ch.Id == chapterId
                                select ch.Questions;
                foreach (var q in questions)
                    questionList = new List<Question>(q);

                answersList = new List<List<Answer>>();
                foreach (var question in questionList)
                    answersList.Add(new List<Answer>(question.Answers));
            }
        }

        private void ShowTestsPanel(int chapterId)
        {
            try
            {
                if (!IsFirstOpen)
                {
                    questionList.Clear();
                    answersList.Clear();
                }
                FillData(chapterId);
                NextQuestion();
            }
            catch (Exception e)
            {
                QuestionLabel.Text = @"Вопросы по данной теме не найдены";
                QuestionLabel.Text = e.Message;
            }
        }

        private void ContentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = ContentTreeView.SelectedNode.Name;
            if (!int.TryParse(selectedNode, out var a))
                return;
            ShowTestsPanel(int.Parse(selectedNode));

            topic = ContentTreeView.SelectedNode.Text;
            
            splitContainer2.Panel2.Show();
        }

        private void CheckAnswers()
        {
            Answer correctAnswer = null;
            foreach (var answer in answersList[questionId])
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

        private void SaveResult()
        {
            using (var context = new TechnologicalEquipAppDBEntities())
            {
                try
                {
                    context.TestResults.Add(new TestResult
                    {
                        Data = DateTime.Now,
                        Mark = correctAnswers,
                        UserId = UserData.Id,
                        Chapter = topic
                    });
                    context.SaveChanges();
                    }

                catch (Exception e)
                {
                    MessageBox.Show(@"Результат не сохранён. Произошла ошибка либо вы не авторизированы!");
                }
            }
        }

        private void NextQuestion()
        {
            if (questionId == questionList.Count)
            {
                NextQuestionButton.Enabled = false;
                QuestionLabel.Text = $@"Правильных ответов - {correctAnswers}";
                SaveResult();
                Answer1RadioButton.Hide();
                Answer2RadioButton.Hide();
                Answer3RadioButton.Hide();


                return;
            }
            if (questionId == questionList.Count - 1)
                NextQuestionButton.Text = @"Завершить";

            QuestionLabel.Text = questionList[questionId].Text;
            Answer1RadioButton.Text = answersList[questionId][0].Text;
            Answer2RadioButton.Text = answersList[questionId][1].Text;
            Answer3RadioButton.Text = answersList[questionId][2].Text;

            CheckAnswers();
            questionId++;
            QuestionCounterLabel.Text = $@"Вопрос {questionId} из {questionList.Count}";
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void OpenTheoryFormButton_Click(object sender, EventArgs e)
        {
            var frm = new TheoryForm();
            frm.Show();
            this.Close();
        }

        private void OpenUserProfileButton_Click_1(object sender, EventArgs e)
        {
            var frm = new UserProfileForm();
            frm.Show();
            this.Close();
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
