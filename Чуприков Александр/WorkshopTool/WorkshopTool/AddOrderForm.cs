using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkshopToolDAL;

namespace WorkshopTool
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
            FillComboBox();
            AddNewClientСheckBox.Checked = false;

            ClientNameTextBox.Enabled = false;
            ClientSecondNameTextBox.Enabled = false;
            ClientAdressTextBox.Enabled = false;
            ClientMailTextBox.Enabled = false;
            ClientPhoneNumberTextBox.Enabled = false;
        }

        private List<User> usersList;

        private void FillComboBox()
        {
            using (var context = new Entities())
            {
                var users = from u in context.Users
                            select u;

                foreach (var user in users)
                {
                    ClientsComboBox.Items.Add(user.SecondName);
                }
                usersList = new List<User>(users);
            }
        }

        private User ChooseUser()
        {
            using (var context = new Entities())
            {
                if (!AddNewClientСheckBox.Checked)
                {
                    var userName = ClientsComboBox.SelectedItem.ToString();
                    foreach (var usr in usersList)
                    {
                        if (usr.SecondName == userName)
                            return context.Users.FirstOrDefault(u => u.SecondName == usr.SecondName && u.Name == usr.Name && u.Adress == usr.Adress);
                    }
                    return context.Users.FirstOrDefault(u => u.SecondName == userName);
                }

                var user = new User
                {
                    Name = ClientNameTextBox.Text,
                    SecondName = ClientSecondNameTextBox.Text,
                    MobilePhoneNumber = ClientPhoneNumberTextBox.Text,
                    Adress = ClientAdressTextBox.Text,
                    Mail = ClientMailTextBox.Text
                };
                return user;
            }
        }

        private void AddOrder()
        {
            using (var context = new Entities())
            {

                User user;

                if (AddNewClientСheckBox.Checked == false)
                {
                    user = new User();
                    var usr = ChooseUser();
                    user = context.Users.FirstOrDefault(u => u.SecondName == usr.SecondName && u.Name == usr.Name);
                }
                else
                {
                    user = new User()
                    {
                        Name = ClientNameTextBox.Text,
                        SecondName = ClientSecondNameTextBox.Text,
                        Adress = ClientAdressTextBox.Text,
                        MobilePhoneNumber = ClientAdressTextBox.Text,
                        Mail = ClientMailTextBox.Text
                    };
                }

                var transaction = new Transaction()
                {
                    Cost = int.Parse(OrderCostTextBox.Text),
                    Date = OrderDateTimePicker.Value.Date,
                    Description = OrderDescriptionTextBox.Text,
                    User = user
                };
                var device = new Device()
                {
                    Model = DeviceModelTextBox.Text,
                    RepairsType = DevicePolomkaTextBox.Text,
                    SerialNumber = DeviceNumberTextBox.Text,
                    Type = DeviceTypeTextBox.Text
                };
                var order = new Order()
                {
                    User = user,
                    Device = device,
                    Transaction = transaction
                };

                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        private bool IsDataCorrectWithNewClient()
        {
            if (!Controls.OfType<TextBox>().Any(pb => string.IsNullOrWhiteSpace(pb.Text))) return true;
            MessageBox.Show(@"Заполните все поля");
            return false;
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (AddNewClientСheckBox.Checked)
            {
                if (!IsDataCorrectWithNewClient() && !IsCostCorrect()) return;
                AddOrder();
                DialogResult = DialogResult.OK;
            }

            else if (AddNewClientСheckBox.Checked == false)
            {
                if (!IsDataCorrectWithoutNewClient() && !IsCostCorrect()) return;
                AddOrder();
                DialogResult = DialogResult.OK;
            }

        }

        private bool IsCostCorrect()
        {
            if (int.TryParse(OrderCostTextBox.Text, out var a)) return true;
            MessageBox.Show(@"Цена введена неверно");
            return false;
        }

        private bool IsDataCorrectWithoutNewClient()
        {
            var textBoxesList = new List<TextBox>
            {
                OrderCostTextBox,
                DeviceTypeTextBox,
                DeviceModelTextBox,
                DeviceNumberTextBox,
                DevicePolomkaTextBox
            };
            var flag = true;

            foreach (var tb in textBoxesList)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                    flag = false;
            }
            return flag;
        }

        private void AddNewClientСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AddNewClientСheckBox.Checked)
            {
                ClientsComboBox.Enabled = false;
                ClientsComboBox.Text = @"Новый клиент";
                ClientNameTextBox.Enabled = true;
                ClientSecondNameTextBox.Enabled = true;
                ClientAdressTextBox.Enabled = true;
                ClientMailTextBox.Enabled = true;
                ClientPhoneNumberTextBox.Enabled = true;

                ClientNameTextBox.Text = "";
                ClientSecondNameTextBox.Text = "";
                ClientAdressTextBox.Text = "";
                ClientMailTextBox.Text = "";
                ClientPhoneNumberTextBox.Text = "";

                return;
            }

            ClientsComboBox.Enabled = true;

            ClientNameTextBox.Enabled = false;
            ClientSecondNameTextBox.Enabled = false;
            ClientAdressTextBox.Enabled = false;
            ClientMailTextBox.Enabled = false;
            ClientPhoneNumberTextBox.Enabled = false;
        }

        private void ClientsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var user in usersList)
            {
                if (user.SecondName != ClientsComboBox.Text) continue;
                ClientNameTextBox.Text = user.Name;
                ClientSecondNameTextBox.Text = user.SecondName;
                ClientPhoneNumberTextBox.Text = user.MobilePhoneNumber;
                ClientAdressTextBox.Text = user.Adress;
                ClientMailTextBox.Text = user.Mail;
            }
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientSecondNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
