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
    public partial class ChooseVideoForm : Form
    {
        public ChooseVideoForm()
        {
            InitializeComponent();
        }

        private void OpenVideoForm(string path)
        {
            var frm = new PlayVideoForm(path);
            frm.ShowDialog();
        }


        private void Video1Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\1.mp4");
        }

        private void Video2Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\2.mp4");

        }

        private void Video3Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\3.mp4");

        }

        private void Video4Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\4.mp4");

        }

        private void Video5Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\5.mp4");

        }

        private void Video6Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\6.mp4");

        }

        private void Video7Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\7.mp4");

        }

        private void Video8Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\8.mp4");

        }

        private void Video9Button_Click(object sender, EventArgs e)
        {
            OpenVideoForm(Application.StartupPath + "\\Content\\Video\\9.mp4");

        }

        private void ToMainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
