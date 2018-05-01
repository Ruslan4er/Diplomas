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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void TheoryButton_Click(object sender, EventArgs e)
        {
            var frm = new TheoryForm();
            frm.ShowDialog();
        }

        private void TestsButton_Click(object sender, EventArgs e)
        {
            var frm = new TestsForm();
            frm.ShowDialog();
        }
    }
}
