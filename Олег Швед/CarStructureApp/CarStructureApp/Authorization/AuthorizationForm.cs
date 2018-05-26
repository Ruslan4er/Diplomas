using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarStructureDAL;

namespace CarStructureApp.Authorization
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            Аuthorization("22", "22");
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            var task = new Task<bool>(() => Аuthorization(login, password));
            task.Start();
            if (!task.Result)
                MessageBox.Show(@"Такой пользователь не найден");
            else
            {
                var frm = new MainMenuForm();
                this.Visible = false;
                frm.ShowDialog();
                this.Visible = true;

            }
        }

        private static void RememberUser(User user)
        {
            UserData.Id = user.Id;
            UserData.Login = user.Login;
            UserData.Password = user.Login;
            UserData.Name = user.UserProfile.Name;
            UserData.SecondName = user.UserProfile.SecondName;
            UserData.Groupe = user.UserProfile.Groupe;
        }

        private void RegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new RegistrationForm();
            frm.ShowDialog();
            MessageBox.Show(frm.DialogResult == DialogResult.OK
                ? @"Вы успешно зарегестрированы"
                : @"Регистрация отменена");
        }

        private static bool Аuthorization(string login, string password)
        {
            using (var context = new СarStructureDBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login);
                if (user != null && user.Password == password)
                {
                    RememberUser(user);
                    return true;
                }
                return false;
               
            }
        }
    }
}
