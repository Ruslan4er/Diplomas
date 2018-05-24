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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            Аuthorization("1", "1");
        }

        private static bool Аuthorization(string login, string password)
        {
            using (var context = new TechnologicalEquipAppDBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login);
                if (user == null || user.Password != password) return false;

                RememberUser(user);
                return true;
            }
        }

        private static void RememberUser(User user)
        {
            UserData.Id = user.Id;
            UserData.Login = user.Login;
            UserData.Password = user.Login;
            UserData.Name = user.Name;
            UserData.SecondName = user.LastName;
            UserData.Groupe = user.Groupe;
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            var task = new Task<bool>(() => Аuthorization(login, password));
            task.Start();
            if (!task.Result)
                MessageBox.Show(@"Пользователь с таким логином не найден");
            else
            {
                var frm = new MainMenuForm();
                frm.Closed += (s, args) => this.Show();
                frm.Show();
                this.Hide();
            }
        }

        private void OpenRegistrationFormButton_Click(object sender, EventArgs e)
        {
            var frm = new RegistrationNewUserForm();
            frm.ShowDialog();
            MessageBox.Show(frm.DialogResult == DialogResult.OK
                ? @"Вы успешно зарегестрированы"
                : @"Регистрация отменена");
        }
    }
}
