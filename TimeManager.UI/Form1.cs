using TimeManager.Core.Context;
using TimeManager.Core.Entity;
using TimeManager.Repositories;

namespace TimeManager.UI
{
    public partial class LoginForm : Form
    {

        private Repository<Users, Guid> users; 
        
        public LoginForm()
        {
            users = new Repository<Users, Guid>(new TimeManagerContext());
            InitializeComponent();
        }

        private void Applaybutton_Click(object sender, EventArgs e)
        {

        }
    }
}