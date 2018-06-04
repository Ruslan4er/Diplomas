using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopToolDAL;
using Microsoft.Office.Interop.Excel;

namespace WorkshopTool
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            FillUsersDataGrid();
            FillOrdersDataGrid();
            FillTransactionsDataGrid();
        }


        private void FillTransactionsDataGrid()
        {
            using (var context = new Entities())
            {
                var orders = from o in context.Transactions
                             select new
                             {
                                 Date = o.Date,
                                 Cost = o.Cost,
                                 Description = o.Description,
                                 Client = o.User.SecondName + " " + o.User.Name,
                             };
                TransactionsDataGridView.DataSource = orders.ToList();
                TransactionsDataGridView.Columns[0].HeaderText = @"Дата транзакции";
                TransactionsDataGridView.Columns[1].HeaderText = @"Сумма";
                TransactionsDataGridView.Columns[2].HeaderText = @"Описание";
                TransactionsDataGridView.Columns[3].HeaderText = @"Клиент";
            }
        }

        private void FillOrdersDataGrid()
        {
            using (var context = new Entities())
            {
                var orders = from o in context.Orders
                             select new
                             {
                                 Id = o.Id,
                                 Date = o.Transaction.Date,
                                 Cost = o.Transaction.Cost,
                                 Client = o.User.SecondName + " " + o.User.Name,
                                 MobilePhone = o.User.MobilePhoneNumber,
                                 Adress = o.User.Adress,
                                 Producer = o.Device.Type,
                                 Model = o.Device.Model,
                                 SerialNumber = o.Device.SerialNumber,
                                 RepairsType = o.Device.RepairsType

                             };
                OrdersDataGridView.DataSource = orders.ToList();
                OrdersDataGridView.Columns[0].HeaderText = @"Номер заказа";
                OrdersDataGridView.Columns[1].HeaderText = @"Дата";
                OrdersDataGridView.Columns[2].HeaderText = @"Стоимость";
                OrdersDataGridView.Columns[3].HeaderText = @"Клиент";
                OrdersDataGridView.Columns[4].HeaderText = @"Номер телефона";
                OrdersDataGridView.Columns[5].HeaderText = @"Адрес";
                OrdersDataGridView.Columns[6].HeaderText = @"Производитель";
                OrdersDataGridView.Columns[7].HeaderText = @"Модель";
                OrdersDataGridView.Columns[8].HeaderText = @"Серийный номер";
                OrdersDataGridView.Columns[9].HeaderText = @"Неисправность";

            }
        }

        private void FillUsersDataGrid()
        {
            using (var context = new Entities())
            {
                var clients = from u in context.Users
                              select new
                              {
                                  Name = u.Name,
                                  SecondName = u.SecondName,
                                  Adress = u.Adress,
                                  MobilePhoneNumber = u.MobilePhoneNumber,
                                  Mail = u.Mail,
                              };
                UsersDataGrid.DataSource = clients.ToList();
                UsersDataGrid.Columns[0].HeaderText = @"Имя";
                UsersDataGrid.Columns[1].HeaderText = @"Фамилия";
                UsersDataGrid.Columns[2].HeaderText = @"Адрес";
                UsersDataGrid.Columns[3].HeaderText = @"Номер телефона";
                UsersDataGrid.Columns[4].HeaderText = @"Электронная почта";

            }
        }

        private void AddNewClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new AddEditUserForm();
                frm.ShowDialog();
                MessageBox.Show(frm.DialogResult == DialogResult.OK
                    ? @"Добавлено"
                    : @"Добавление отменено");
                FillUsersDataGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Упс! Что-то пошло не так!");
            }
        }


        private void RemoveClient()
        {
            using (var context = new Entities())
            {
                var name = UsersDataGrid.SelectedCells[0].Value.ToString();
                var secondName = UsersDataGrid.SelectedCells[1].Value.ToString();
                var adress = UsersDataGrid.SelectedCells[2].Value.ToString();

                var user = context.Users
                    .FirstOrDefault(u => u.Name == name && u.SecondName == secondName && u.Adress == adress);

                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveClient();
                FillUsersDataGrid();
                MessageBox.Show(@"Удалено!");
            }

            catch (DbUpdateException exception)
            {
                MessageBox.Show(@"Невозможно удалить пользователя! Имеются незавершенные заказы. ");
            }

            catch (Exception exception)
            {
                MessageBox.Show(@"Упс! Что-то пошло не так!");
            }
        }

        private User ChooseUser()
        {
            using (var context = new Entities())
            {
                var name = UsersDataGrid.SelectedCells[0].Value.ToString();
                var secondName = UsersDataGrid.SelectedCells[1].Value.ToString();
                var adress = UsersDataGrid.SelectedCells[2].Value.ToString();

                var user = context.Users
                    .FirstOrDefault(u => u.Name == name && u.SecondName == secondName && u.Adress == adress);
                return user;
            }
        }


        private void EditClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = ChooseUser();
                var frm = new AddEditUserForm(user);
                frm.ShowDialog();
                MessageBox.Show(frm.DialogResult == DialogResult.OK
                    ? @"Сохранено"
                    : @"Отмена");
                FillUsersDataGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Упс! Что-то пошло не так!");
            }

        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            var frm = new AddOrderForm();
            frm.ShowDialog();
            MessageBox.Show(frm.DialogResult == DialogResult.OK
                ? @"Добавлено"
                : @"Отмена");
            FillOrdersDataGrid();
            FillTransactionsDataGrid();
            FillUsersDataGrid();
        }

        private void RemoveOrder()
        {
            using (var context = new Entities())
            {
                var id = int.Parse(OrdersDataGridView.SelectedCells[0].Value.ToString());

                var order = context.Orders
                    .FirstOrDefault(o => o.Id == id);

                if (order != null) context.Orders.Remove(order);
                context.SaveChanges();
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveOrder();
                FillOrdersDataGrid();
                FillTransactionsDataGrid();
                FillUsersDataGrid();
                MessageBox.Show(@"Удалено!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Упс! Что-то пошло не так!");
            }
        }


        private void SaveToExcel()
        {
            var ExcelApp = new Microsoft.Office.Interop.Excel.Application();

            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 25;
            ExcelApp.Cells[1, 1] = "Дата";
            ExcelApp.Cells[1, 2] = "Сумма";
            ExcelApp.Cells[1, 3] = "Описание";
            ExcelApp.Cells[1, 4] = "Клиент";

            for (var i = 0; i < TransactionsDataGridView.ColumnCount; i++)
            {
                for (var j = 0; j < TransactionsDataGridView.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (TransactionsDataGridView[i, j].Value).ToString();
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.DisplayFullScreen = true;
        }


        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            SaveToExcel();
            MessageBox.Show(@"Отчет сгенерирован");
        }
    }
}
