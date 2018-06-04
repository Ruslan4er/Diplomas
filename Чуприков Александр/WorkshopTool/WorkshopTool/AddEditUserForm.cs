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
    public partial class AddEditUserForm : Form
    {
        private User editedUser;

        public AddEditUserForm()
        {
            InitializeComponent();
            EditUserButton.Hide(); ;
        }

        public AddEditUserForm(User user)
        {
            InitializeComponent();
            ClientNameTextBox.Text = user.Name;
            ClientSecondNameTextBox.Text = user.SecondName;
            ClientPhoneNumberTextBox.Text = user.MobilePhoneNumber;
            ClientAdressTextBox.Text = user.Adress;
            ClientMailTextBox.Text = user.Mail;
            AddClientButton.Hide();
            editedUser = new User
            {
                Name = user.Name,
                Adress = user.Adress,
                SecondName = user.SecondName,
                Mail = user.Mail,
                MobilePhoneNumber = user.MobilePhoneNumber,
                Id = user.Id
            };

        }

        private bool IsDataCorrect()
        {
            if (!Controls.OfType<TextBox>().Any(pb => string.IsNullOrWhiteSpace(pb.Text))) return true;
            MessageBox.Show(@"Заполните все поля");
            return false;
        }
        

        private void AddUser()
        {
            using (var context = new Entities())
            {
                var user = new User
                {
                    Name = ClientNameTextBox.Text,
                    SecondName = ClientSecondNameTextBox.Text,
                    MobilePhoneNumber = ClientPhoneNumberTextBox.Text,
                    Adress = ClientAdressTextBox.Text,
                    Mail = ClientMailTextBox.Text
                    };
                context.Users.Add(user);
                context.SaveChanges();

            }
        }

        private void EditClient()
        {
            using (var context = new Entities())
            {
                var user = new User
                {
                    Name = ClientNameTextBox.Text,
                    SecondName = ClientSecondNameTextBox.Text,
                    MobilePhoneNumber = ClientPhoneNumberTextBox.Text,
                    Adress = ClientAdressTextBox.Text,
                    Mail = ClientMailTextBox.Text
                };

                var dbUser = context.Users
                    .FirstOrDefault(u => u.Name == editedUser.Name && u.SecondName == editedUser.SecondName && u.Adress == editedUser.Adress);
                
                dbUser.Name = user.Name;
                dbUser.SecondName = user.SecondName;
                dbUser.Adress = user.Adress;
                dbUser.Mail = user.Mail;
                dbUser.MobilePhoneNumber = user.MobilePhoneNumber;
                
                context.SaveChanges();

            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            if (!IsDataCorrect()) return;
            AddUser();
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if (!IsDataCorrect()) return;
            EditClient();
            DialogResult = DialogResult.OK;
        }
    }
}
