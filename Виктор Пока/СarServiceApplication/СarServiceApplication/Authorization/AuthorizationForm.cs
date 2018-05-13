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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private static bool Аuthorization(string login, string password)
        {
            using (var context = new CarServiceDBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login);
                UserData.UserId = user.Id;
                return user != null && user.Password == password;
                //_userName = user.UserProfile.Name;
            }
        }

        private bool IsDataCorrect()
        {
            return !string.IsNullOrEmpty(LoginTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!IsDataCorrect())
                MessageBox.Show(@"Заполните поля");

            else
            {
                var task = new Task<bool>(() => Аuthorization(
                    LoginTextBox.Text, PasswordTextBox.Text));

                task.Start();

                if (!task.Result)
                    MessageBox.Show(@"Такой пользователь не найден");
                else
                {
                    var frm = new MainForm();
                    this.Visible = false;
                    frm.ShowDialog();
                    this.Visible = true;
                }
            }
        }

        private void RegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new RegistrationNewUserForm();
            frm.ShowDialog();
            MessageBox.Show(frm.DialogResult == DialogResult.OK
                ? @"Вы успешно зарегестрированы"
                : @"Регистрация отменена");
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
