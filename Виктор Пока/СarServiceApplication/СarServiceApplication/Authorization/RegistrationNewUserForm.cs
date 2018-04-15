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

namespace СarServiceApplication.Authorization
{
    public partial class RegistrationNewUserForm : Form
    {
        public RegistrationNewUserForm()
        {
            InitializeComponent();
        }

        private string _login;
        private string _password;
        private string _firstName;
        private string _secondName;
        private string _groupe;

        private bool IsDataCorrect()
        {
            foreach (var pb in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(pb.Text))
                    return false;
            }
            _login = LoginTextBox.Text;
            _password = PasswordTextBox.Text;
            _firstName = FirstNameTextBox.Text;
            _secondName = LastNameTextBox.Text;
            _groupe = GroupeTextBox.Text;

            return true;
        }

        private bool IsUnique()
        {
            using (var context = new CarServiceDBEntities())
            {
                var users = from user in context.Users
                            where user.Login == _login
                            select user;
                return !users.Any();
            }
        }

        private void AddUser()
        {
           using (var context = new CarServiceDBEntities())
            {
                var user = new User
                {
                    Login = _login,
                    Password = _password,
                };
                context.Users.Add(user);
                context.SaveChanges();

                var profile = new UserProfile
                {
                    Name = _firstName,
                    SecondName = _secondName,
                    Groupe = _groupe,
                    Id = user.Id
                };
                context.UserProfiles.Add(profile);
                context.SaveChanges();
            }
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!IsDataCorrect())
                MessageBox.Show(@"Заполните все поля");
            else if (!IsUnique())
                MessageBox.Show(@"Пользователь с таким логином уже существует");
            else
            {
                AddUser();
                DialogResult = DialogResult.OK;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
