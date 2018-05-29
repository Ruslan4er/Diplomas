using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceDAL;

namespace СarServiceApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TestPanel.Visible = false;
            TheoryPanel.Visible = true;
        }

        private void TestsButton_Click(object sender, EventArgs e)
        {
            TestPanel.Visible = true;
            TheoryPanel.Visible = false;
        }

        private void TheoryButton_Click(object sender, EventArgs e)
        {
            TestPanel.Visible = false;
            TheoryPanel.Visible = true;
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            var frm = new AccountForm(UserData.UserId);
            frm.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void ShowForm(string path, string[] imagePath, int chapterId)
        {
            var frm = new TheoryForm(path, imagePath, chapterId);
            frm.ShowDialog();
        }

        private void Chapter1LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[0], TheoryContainer.Pictures[0], 1);
        }

        private void Chapter2LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[1], TheoryContainer.Pictures[1], 2);
        }

        private void Chapter3LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[3], TheoryContainer.Pictures[3], 4);
        }

        private void Chapter4LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[1], TheoryContainer.Pictures[1], 2);
        }

        private void Chapter5LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[2], TheoryContainer.Pictures[2], 3);
        }

        private void Chapter6LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[7], TheoryContainer.Pictures[7], 8);
        }

        private void Chapter7LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[6], TheoryContainer.Pictures[6], 7);
        }

        private void Chapter8LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[4], TheoryContainer.Pictures[4], 5);
        }

        private void Chapter9LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[5], TheoryContainer.Pictures[5], 6);
        }

        private void OpenTestForm(int chapterId)
        {
            var frm = new TestsForm(chapterId);
            frm.ShowDialog();
        }

        private void Test2LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTestForm(2);
        }

        private void Test3LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTestForm(3);
        }

        private void Test4LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTestForm(4);
        }

        private void Test5LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTestForm(5);
        }

        private void Test6LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTestForm(6);
        }

        private void Test7LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTestForm(7);
        }

        private void Test8LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTestForm(8);
        }

        private void Test9LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenTestForm(9);
        }
    }
}
