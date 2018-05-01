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
    public partial class TheoryForm : Form
    {
        public TheoryForm()
        {
            InitializeComponent();
            theoryContainer = new TheoryContainer();
        }

        private readonly TheoryContainer theoryContainer;

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void SetTheoryFile(string name)
        {
            var path = GetTheoryPath(name);
            if (string.IsNullOrEmpty(path))
                return;
            TheoryPdfViewer.LoadDocument(path);
        }

        private string GetTheoryPath(string name)
        {
            string path = null;
            foreach (var theory in theoryContainer.TheoryList)
                if (theory.Name == name)
                    path = theory.Path;
            return path;
        }

        private void ContentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = ContentTreeView.SelectedNode.Name;
            SetTheoryFile(selectedNode);
        }
    }
}
