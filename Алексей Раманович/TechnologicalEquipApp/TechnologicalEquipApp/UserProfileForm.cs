using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnologicalEqueipAppDAL;
using TechnologicalEquipApp.Authorization;

namespace TechnologicalEquipApp
{
    public partial class UserProfileForm : Form
    {
        public UserProfileForm()
        {
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {
            using (var context = new TechnologicalEquipAppDBEntities())
            {
                var x = from tr in context.TestResults
                        where tr.UserId == UserData.Id
                        select new
                        {
                            Chapter = tr.Chapter,
                            Result = tr.Mark,
                            Date = tr.Data
                        };
                
                TestResultGridView.DataSource = x.ToList();
                TestResultGridView.Columns[0].HeaderText = @"Глава";
                TestResultGridView.Columns[1].HeaderText = @"Оценка";
                TestResultGridView.Columns[2].HeaderText = @"Дата прохождения";

            }
        }

        private void OpenTheoryFormButton_Click(object sender, EventArgs e)
        {
            var frm = new TheoryForm();
            frm.Show();
            this.Close();
        }

        private void OpenTestsForm_Click(object sender, EventArgs e)
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

        }
    }
}
