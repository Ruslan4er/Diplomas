using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace TechnologicalEquipApp
{
    public partial class TheoryForm : Form
    {
        public TheoryForm()
        {
            InitializeComponent();
            SetTheoryFile();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void SetTheoryFile()
        {
            TheoryPdfViewer.LoadDocument(Application.StartupPath + "\\Content\\Theory\\book.pdf");
        }



        private void ContentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //var selectedNode = ContentTreeView.SelectedNode.Name;
            //SetTheoryFile(selectedNode);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OpenTestsFormButton_Click(object sender, EventArgs e)
        {
            var frm = new TestsForm();
            frm.Show();
            this.Close();
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenUserProfileButton_Click(object sender, EventArgs e)
        {
            var frm = new UserProfileForm();
            frm.Show();
            this.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

            printDialog1.ShowDialog();
            printDocument1.DocumentName = Application.StartupPath + "\\Content\\Theory\\book.pdf";
            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
            printDocument1.PrinterSettings.PrintFileName = Application.StartupPath + "\\Content\\Theory\\book.pdf";
            printDocument1.Print();
        }
    }
}
