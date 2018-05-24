using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarStructureDAL;

namespace CarStructureApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private bool IsDataCorrect()
        {
            foreach (var pb in Controls.OfType<TextBox>())
            {
                if (!string.IsNullOrWhiteSpace(pb.Text)) continue;
                MessageBox.Show(@"Заполните все поля");
                return false;
            }
            
            if (PasswordTextBox.Text != CheckPasswordTextBox.Text)
            {
                MessageBox.Show(@"Пароли не совпадают");
                return false;
            }

            return true;
        }

        private bool IsUnique()
        {
            using (var context = new СarStructureDBEntities())
            {
                var users = from user in context.Users
                            where user.Login == LoginTextBox.Text
                            select user;
                return !users.Any();
            }
        }

        private void AddUser()
        {
            using (var context = new СarStructureDBEntities())
            {
                var user = new User
                {
                    Login = LoginTextBox.Text,
                    Password = PasswordTextBox.Text,

                };
                context.Users.Add(user);
                context.SaveChanges();

                var userInfo = new UserProfile()
                {
                    Name = NameTextBox.Text,
                    SecondName = SecondNameTextBox.Text,
                    Groupe = GroupeTextBox.Text,
                    Id = user.Id
                };
                context.UserProfiles.Add(userInfo);
                context.SaveChanges();
            }
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
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

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
