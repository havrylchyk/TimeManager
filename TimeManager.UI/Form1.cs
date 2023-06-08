using System.Text.RegularExpressions;
using TimeManager.Core.Context;
using TimeManager.Core.Entity;
using TimeManager.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TimeManager.UI
{
    public partial class LoginForm : Form
    {

        private Repository<Users, Guid> usersrepository;

        public LoginForm()
        {
            usersrepository = new Repository<Users, Guid>(new TimeManagerContext());
            InitializeComponent();
        }

        private void AddUser(Users users)
        {
            usersrepository.Create(users);
            usersrepository.Save();
        }
        private void Applaybutton_Click(object sender, EventArgs e)
        {
            string username = UsernametextBox.Text;
            string email = EmailtextBox.Text;
            string password = PasswordtextBox.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Некоректний формат електронної пошти.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsStrongPassword(password))
            {
                MessageBox.Show("Пароль повинен містити букви різних регістрів та цифри.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Users newUser = new Users
            {
                Username = username,
                Email = email,
                Password = password,
            };

            AddUser(newUser);

            //TimeManagerForm timeManagerForm = new TimeManagerForm(newUser);
            //timeManagerForm.Show();
            //this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        private bool IsStrongPassword(string password)
        {
            bool hasLowercase = false;
            bool hasUppercase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsLower(c))
                    hasLowercase = true;
                else if (char.IsUpper(c))
                    hasUppercase = true;
                else if (char.IsDigit(c))
                    hasDigit = true;

                if (hasLowercase && hasUppercase && hasDigit)
                    return true;
            }

            return false;
        }
    }
}