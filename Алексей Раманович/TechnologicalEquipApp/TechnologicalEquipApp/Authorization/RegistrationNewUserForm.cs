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

namespace TechnologicalEquipApp.Authorization
{
    public partial class RegistrationNewUserForm : Form
    {
        public RegistrationNewUserForm()
        {
            InitializeComponent();
        }

        private bool IsDataCorrect()
        {
            if (Controls.OfType<TextBox>().Any(pb => string.IsNullOrWhiteSpace(pb.Text)))
            {
                MessageBox.Show(@"Заполните все поля");
                return false;
            }

            if (PasswordTextBox.Text == CheckPasswordTextBox.Text) return true;
            MessageBox.Show(@"Пароли не совпадают");
            return false;
        }

        private bool IsUnique()
        {
            using (var context = new TechnologicalEquipAppDBEntities())
            {
                var users = from user in context.Users
                            where user.Login == LoginTextBox.Text
                            select user;
                return !users.Any();
            }

        }

        private void AddUser()
        {
            using (var context = new TechnologicalEquipAppDBEntities())
            {
                var user = new User
                {
                    Login = LoginTextBox.Text,
                    Password = PasswordTextBox.Text,
                    Name = NameTextBox.Text,
                    LastName = SecondNameTextBox.Text,
                    Groupe = GroupeTextBox.Text,
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            if (!IsDataCorrect())
                return;
            if (!IsUnique())
            {
                MessageBox.Show(@"Пользователь с таким логином уже существует");
                return;
            }

            AddUser();
            DialogResult = DialogResult.OK;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
