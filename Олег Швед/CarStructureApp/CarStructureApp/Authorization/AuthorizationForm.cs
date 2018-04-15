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
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            var task = new Task<bool>(() => Аuthorization(login, password));
            task.Start();
            //if (!Аuthorization(login, password))
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

        private void RegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new RegistrationForm();
            frm.ShowDialog();
            MessageBox.Show(frm.DialogResult == DialogResult.OK
                ? @"Вы успешно зарегестрированы"
                : @"Регистрация отменена");
        }

        private bool Аuthorization(string login, string password)
        {
            using (var context = new СarStructureDBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login);
                if (user == null || user.Password != password) return false;
                //_userName = user.UserInformation.Name;
                return true;
            }
        }
    }
}
