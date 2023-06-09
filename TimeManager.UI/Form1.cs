using System.Text.RegularExpressions;
using TimeManager.Core.Context;
using TimeManager.Core.Entity;
using TimeManager.Repositories;

namespace TimeManager.UI
{
    public partial class LoginForm : Form
    {
        public static LoginForm Instance;
        private Repository<Users, Guid> usersrepository;

        public LoginForm()
        {
            usersrepository = new Repository<Users, Guid>(new TimeManagerContext());
            InitializeComponent();
            Instance = this;
            PasswordtextBox.PasswordChar = '•';
            PasswordtextBox.UseSystemPasswordChar = true;
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

            if (IsUserExists(username, password))
            {
                MessageBox.Show("Користувач вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                AddUser(newUser);
            }

            TimeManagerForm timeManagerForm = new TimeManagerForm(newUser);
            timeManagerForm.Show();
            this.Hide();
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

        private bool IsUserExists(string username, string password)
        {
            return usersrepository.GetAll().Any(u => u.Username == username && u.Password == password);
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string username = UsernametextBox.Text;
            string password = PasswordtextBox.Text;

            var user = usersrepository.GetAll().FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                MessageBox.Show("Користувача з такими даними не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                TimeManagerForm timeManagerForm = new TimeManagerForm(user);
                timeManagerForm.Show();
                this.Hide();
            }

        }

        private void PasswordtextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordtextBox.UseSystemPasswordChar = true;
        }
    }
}