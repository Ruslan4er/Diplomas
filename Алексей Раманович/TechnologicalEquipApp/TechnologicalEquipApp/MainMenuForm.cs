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

        private void TestsButton_Click(object sender, EventArgs e)
        {
            var frm = new TestsForm();
            frm.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenTheoryFormButton_Click(object sender, EventArgs e)
        {
            var frm = new TheoryForm();
            frm.Show();
            this.Hide();
        }

        private void OpenUserProfileForm_Click(object sender, EventArgs e)
        {
            var frm = new UserProfileForm();
            frm.Show();
            this.Hide();
        }
    }
}
