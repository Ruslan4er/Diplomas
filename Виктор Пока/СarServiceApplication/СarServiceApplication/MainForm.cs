using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СarServiceApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TestPanel.Visible = false;
            TheoryPanel.Visible = false;
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
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private static void ShowForm(string path, string[] imagePath)
        {
            var frm = new TheoryForm(path,imagePath);
            frm.ShowDialog();
        }

        private void Chapter1LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[0],TheoryContainer.Pictures[0]);
        }

        private void Chapter2LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[1], TheoryContainer.Pictures[1]);
        }

        private void Chapter3LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[2], TheoryContainer.Pictures[2]);
        }

        private void Chapter4LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[3], TheoryContainer.Pictures[3]);
        }

        private void Chapter5LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[4], TheoryContainer.Pictures[4]);
        }

        private void Chapter6LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[5], TheoryContainer.Pictures[5]);
        }

        private void Chapter7LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[6], TheoryContainer.Pictures[6]);
        }

        private void Chapter8LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[7], TheoryContainer.Pictures[7]);
        }

        private void Chapter9LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowForm(TheoryContainer.ChaptersList[8], TheoryContainer.Pictures[8]);
        }
    }
}
