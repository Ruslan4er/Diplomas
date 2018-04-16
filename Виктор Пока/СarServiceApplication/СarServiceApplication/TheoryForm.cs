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
        public TheoryForm()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var frm = new TestsForm();
            frm.ShowDialog();
            Close();
        }
    }
}
