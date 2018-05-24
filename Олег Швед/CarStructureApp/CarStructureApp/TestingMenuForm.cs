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

        private void OpenTestForm(int chapter)
        {
            var frm = new TestForm(chapter,isSaved);
            frm.ShowDialog();
        }

        private void Test1Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(1);
        }

        private void Test2Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(2);
        }

        private void Test3Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(3);
        }

        private void Test4Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(4);
        }

        private void Test5Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(5);
        }

        private void Test6Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(6);
        }

        private void Test7Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(7);
        }

        private void Test8Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(8);
        }

        private void Test9Button_Click(object sender, EventArgs e)
        {
            OpenTestForm(9);
        }

        private void RandomTestButton_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            OpenTestForm(rnd.Next(0, 9));
        }

        private void ToMainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FinalTestButton_Click(object sender, EventArgs e)
        {
            OpenTestForm(10);
        }
    }
}
