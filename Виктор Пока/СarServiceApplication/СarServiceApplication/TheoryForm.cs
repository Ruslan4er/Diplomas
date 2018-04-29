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
    public partial class TheoryForm : Form
    {
        private readonly string[] _picturesPassArray;
        private int currentPicture;
        private readonly int chapterId;

        public TheoryForm(string path, string[] pictures,int chapterId)
        {
            InitializeComponent();
            LoadDoc(path);
            _picturesPassArray = pictures;
            this.chapterId = chapterId;
            TheoryPictureBox.Image = Image.FromFile(pictures[0]);

            splitContainer1.IsSplitterFixed = true;
            TheoryPdfViewer.EnableThumbnails = false;
        }

        private void ShowPicture(string[] picturesPassArray)
        {
            TheoryPictureBox.Image = Image.FromFile(picturesPassArray[currentPicture]);
        }
        private void LoadDoc(string path)
        {
            TheoryPdfViewer.LoadDocument(path);
        }
        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var frm = new TestsForm(chapterId);
            frm.ShowDialog();
            Close();
        }

        private void NextPicButton_Click(object sender, EventArgs e)
        {
            if (currentPicture == _picturesPassArray.Length - 1) return;
            currentPicture++;
            ShowPicture(_picturesPassArray);
        }

        private void BackPicButton_Click(object sender, EventArgs e)
        {
            if (currentPicture == 0) return;
            currentPicture--;
            ShowPicture(_picturesPassArray);
            
        }
    }
}
