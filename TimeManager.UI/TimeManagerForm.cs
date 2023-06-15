using System.Net.Mail;
using System.Net;
using TimeManager.Core.Context;
using TimeManager.Core.Entity;
using TimeManager.Repositories;

namespace TimeManager.UI
{
    public partial class TimeManagerForm : Form
    {

        //mobilochkaj5439@gmail.com
        private Users currentUser;

        public TimeManagerContext ctx;
        private Repository<TaskCategory, Guid> taskCategoryRepository;
        private Repository<TasksStatus, Guid> tasksStatusRepository;
        private Repository<Tasks, Guid> tasksRepository;
        private Repository<Users, Guid> usersRepository;
        private Repository<RegularTask, Guid> regularTaskRepository;

        public TimeManagerForm(Users users)
        {
            ctx = new TimeManagerContext();
            currentUser = users;
            taskCategoryRepository = new Repository<TaskCategory, Guid>(ctx);
            tasksStatusRepository = new Repository<TasksStatus, Guid>(ctx);
            tasksRepository = new Repository<Tasks, Guid>(ctx);
            usersRepository = new Repository<Users, Guid>(ctx);
            regularTaskRepository = new Repository<RegularTask, Guid>(ctx);

            InitializeComponent();
            CategorycomboBoxFill();
            StatuscomboBoxFill();
            CheckTaskRemindersForm();
            CheckTaskReminders();

        }

        private void TimeManagerForm_Load(object sender, EventArgs e)
        {
            UsertextBox.Text = currentUser.Username;
            EmailChangetextBox.Text = currentUser.Email;

            List<string> customData = new List<string>
            {
                "Завдання",
                "Регулярні завдання",
            };
            CheckdrvcomboBox.Items.AddRange(customData.ToArray());

            CheckdrvcomboBox.SelectedItem = "Завдання";
        }

        private void TimeManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Close();
        }

        private void CheckdrvcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (CheckdrvcomboBox.SelectedItem == "Завдання")
            {
                LoadTasks();
            }
            else if (CheckdrvcomboBox.SelectedItem == "Регулярні завдання")
            {
                LoadRegularTasks();
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string taskeName = taskNametextBox.Text;
            DateTime startTime = StartdateTimePicker.Value;
            DateTime endTime = EnddateTimePicker.Value;

            Tasks task = new();
            if (taskeName == "" || taskeName == null)
            {
                MessageBox.Show("Поле не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidateDateTimePicker() == true)
            {
                task.TaskName = taskeName;
                task.StartTime = startTime;
                task.EndTime = endTime;
                task.TaskCategory = taskCategoryRepository.Get((Guid)CategorycomboBox.SelectedValue);
                task.TaskStatus = tasksStatusRepository.Get((Guid)StatuscomboBox.SelectedValue);
                task.User = usersRepository.Get(currentUser.Id);
                tasksRepository.Create(task);
            }
            LoadTasks();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (TaskdataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = TaskdataGridView.SelectedRows[0].Index;
                Guid taskId = (Guid)TaskdataGridView.Rows[selectedRowIndex].Cells["Id"].Value;

                Tasks taskToDelete = tasksRepository.Get(taskId);
                if (taskToDelete != null)
                {
                    tasksRepository.Delete(taskToDelete);
                    LoadTasks();
                }
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (TaskdataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = TaskdataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = TaskdataGridView.Rows[selectedRowIndex];

                string taskIdString = selectedRow.Cells["Id"].Value.ToString();
                Guid taskId = Guid.Parse(taskIdString);

                Tasks taskToUpdate = tasksRepository.Get(taskId);
                if (taskNametextBox.Text == "" || taskNametextBox.Text == null)
                {
                    MessageBox.Show("Поле не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (taskToUpdate != null)
                {
                    taskToUpdate.TaskName = taskNametextBox.Text;
                    taskToUpdate.StartTime = StartdateTimePicker.Value;
                    taskToUpdate.EndTime = EnddateTimePicker.Value;
                    taskToUpdate.TaskCategory = taskCategoryRepository.Get((Guid)CategorycomboBox.SelectedValue);
                    taskToUpdate.TaskStatus = tasksStatusRepository.Get((Guid)StatuscomboBox.SelectedValue);

                    tasksRepository.Update(taskToUpdate);
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Немає даних для редагування.");
                }
            }
        }

        private void Addregularbutton_Click(object sender, EventArgs e)
        {
            string taskName = RegularnametextBox.Text;
            int frequency = (int)RegularTasknumericUpDown.Value;
            DateTime lastExecuted = lastdateTimePicker.Value;

            RegularTask regularTask = new RegularTask();
            if (taskName == "" || taskName == null)
            {
                MessageBox.Show("Поле не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (frequency > 0 && frequency < 8)
            {
                regularTask.TaskName = taskName;
                regularTask.Frequency = frequency;
                regularTask.LastExecuted = lastExecuted;
                regularTask.TaskCategory = taskCategoryRepository.Get((Guid)CategorycomboBoxtwo.SelectedValue);
                regularTask.User = usersRepository.Get(currentUser.Id);

                regularTaskRepository.Create(regularTask);
            }
            else
            {
                MessageBox.Show("Регулярене завдання не може виконуватись більше раз ніж є днів тижня.");
            }

            LoadRegularTasks();
        }

        private void DeleteRegularbutton_Click(object sender, EventArgs e)
        {
            if (TaskdataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = TaskdataGridView.SelectedRows[0].Index;
                Guid taskId = (Guid)TaskdataGridView.Rows[selectedRowIndex].Cells["Id"].Value;

                RegularTask taskToDelete = regularTaskRepository.Get(taskId);
                if (taskToDelete != null)
                {
                    regularTaskRepository.Delete(taskToDelete);
                    LoadTasks();
                }
            }
            CheckTaskRemindersForm();
        }

    }
}
