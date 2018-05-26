using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarStructureApp.Authorization;
using CarStructureDAL;

namespace CarStructureApp
{
    public partial class PersomalCabinetForm : Form
    {
        public PersomalCabinetForm()
        {
            InitializeComponent();
            UserNameLabel.Text = string.Format("{0} {1}", UserData.SecondName, UserData.Name);
            FillGrid();
        }

        private void FillGrid()
        {
            using (var context = new СarStructureDBEntities())
            {
                var x = from tr in context.TestResults
                    where tr.UserId == UserData.Id
                    select new
                    {
                        Chapter = tr.Chapter,
                        Result = tr.Mark,
                        Date = tr.Date
                    };

                TestResultGridView.DataSource = x.ToList();
                TestResultGridView.Columns[0].HeaderText = @"Глава";
                TestResultGridView.Columns[1].HeaderText = @"Оценка";
                TestResultGridView.Columns[2].HeaderText = @"Дата прохождения";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
