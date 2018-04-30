using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarStructureApp
{
    public partial class TheoryForm : Form
    {
        private static List<string> ChaptersList { get; } = new List<string>
        {
            Application.StartupPath + "\\Content\\Theory\\theory1.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory2.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory3.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory4.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory5.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory6.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory7.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory8.pdf",
            Application.StartupPath + "\\Content\\Theory\\theory9.pdf"
         };

        public TheoryForm()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
            TheoryPdfViewer.EnableThumbnails = false;
        }

        private void LoadDoc(string path)
        {
            TheoryPdfViewer.LoadDocument(path);
        }

        private void Topic1LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[0]);
        }

        private void ExitToMainManuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Topic2LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[1]);
        }

        private void Topic3LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[2]);
        }

        private void Topic4LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[3]);
        }

        private void Topic5LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[4]);
        }

        private void Topic6LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[5]);
        }

        private void Topic7LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[6]);
        }

        private void Topic8LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[7]);
        }

        private void Topic9LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDoc(ChaptersList[8]);
        }
    }
}
