using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceDAL;

namespace СarServiceApplication
{
    public partial class AccountForm : Form
    {
        private int userId;

        public AccountForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            FillGrid();
           
        }

        private string ConvertDate(DateTime date)
        {
            return date.ToShortDateString();
        }


        private void FillGrid()
        {
            using (var context = new CarServiceDBEntities())
            {
                var x = (from tr in context.TestingResults
                         where tr.UserId == userId
                         select new
                         {
                             Chapter = tr.Chapter,
                             Result = tr.Mark,
                             Date = tr.Date
                         }).ToList().Select(z => new
                         {
                             Chapter = z.Chapter,
                             Result = z.Result,
                             Date = z.Date.ToShortDateString()
                         });

                TestResultDataGridView.DataSource = x.ToList();
                TestResultDataGridView.Columns[0].HeaderText = @"Глава";
                TestResultDataGridView.Columns[1].HeaderText = @"Оценка";
                TestResultDataGridView.Columns[2].HeaderText = @"Дата прохождения";

            }
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
