using System;
using System.Windows.Forms;

namespace CarStructureApp
{
    public partial class TestingMenuForm : Form
    {
        private readonly bool isSaved;

        public TestingMenuForm(bool isSaved)
        {
            this.isSaved = isSaved;
            InitializeComponent();
        }

        private void OpenTestForm(int chapter, string text)
        {
            var frm = new TestForm(chapter, isSaved, text);
            frm.ShowDialog();
        }

        private void Test1Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(1, Test1Button.Text);
        }

        private void Test2Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(2, Test2Button.Text);
        }

        private void Test3Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(3, Test3Button.Text);
        }

        private void Test4Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(4, Test4Button.Text);
        }

        private void Test5Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(5, Test5Button.Text);
        }

        private void Test6Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(6, Test6Button.Text);
        }

        private void Test7Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(7, Test7Button.Text);
        }

        private void Test8Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(8, Test8Button.Text);
        }

        private void Test9Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(9, Test1Button.Text);
        }

        private void RandomTestButton_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            OpenTestForm(rnd.Next(1, 9),"Случайный");
        }

        private void ToMainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FinalTestButton_Click(object sender, EventArgs e)
        {
            OpenTestForm(10, FinalTestButton.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
