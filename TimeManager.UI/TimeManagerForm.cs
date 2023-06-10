using TimeManager.Core.Context;
using TimeManager.Core.Entity;
using TimeManager.Repositories;

namespace TimeManager.UI
{
    public partial class TimeManagerForm : Form
    {
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
        }

        private void TimeManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Close();
        }

        private void CategorycomboBoxFill()
        {
            List<KeyValuePair<Guid, string>> addItems = new List<KeyValuePair<Guid, string>>();

            foreach (var category in taskCategoryRepository.GetAll())
            {
                addItems.Add(new KeyValuePair<Guid, string>(category.Id, category.CategoryName));
            }

            CategorycomboBox.DataSource = addItems;
            CategorycomboBox.DisplayMember = "Value";
            CategorycomboBox.ValueMember = "Key";

            CategorycomboBoxtwo.DataSource = addItems;
            CategorycomboBoxtwo.DisplayMember = "Value";
            CategorycomboBoxtwo.ValueMember = "Key";
        }

        private void StatuscomboBoxFill()
        {
            List<KeyValuePair<Guid, string>> addItems = new List<KeyValuePair<Guid, string>>();

            foreach (var status in tasksStatusRepository.GetAll())
            {
                addItems.Add(new KeyValuePair<Guid, string>(status.Id, status.StasusName));
            }

            StatuscomboBox.DataSource = addItems;
            StatuscomboBox.DisplayMember = "Value";
            StatuscomboBox.ValueMember = "Key";

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

        private void LoadTasks()
        {
            TaskdataGridView.ClearSelection();
            var userTasks = tasksRepository.GetAll()
                .Where(task => task.UserId == currentUser.Id)
                    .Select(x => new
                    {
                        x.Id,
                        TaskName = x.TaskName,
                        StartTime = x.StartTime,
                        EndTime = x.EndTime,
                        User = x.User.Username,
                        TaskCategory = x.TaskCategory != null ? x.TaskCategory.CategoryName : string.Empty,
                        TaskStatus = x.TaskStatus != null ? x.TaskStatus.StasusName : string.Empty
                    })
                 .ToList();

            TaskdataGridView.DataSource = userTasks;
            TaskdataGridView.Columns["Id"].Visible = false;

            TaskdataGridView.Columns["TaskName"].HeaderText = "Назва завдання";
            TaskdataGridView.Columns["StartTime"].HeaderText = "Початок";
            TaskdataGridView.Columns["EndTime"].HeaderText = "Кінець";
            TaskdataGridView.Columns["User"].HeaderText = "Користувач";
            TaskdataGridView.Columns["TaskCategory"].HeaderText = "Категорія";
            TaskdataGridView.Columns["TaskStatus"].HeaderText = "Статус";

            TaskdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string taskeName = taskNametextBox.Text;
            DateTime startTime = StartdateTimePicker.Value;
            DateTime endTime = EnddateTimePicker.Value;

            Tasks task = new();

            task.TaskName = taskeName;
            task.StartTime = startTime;
            task.EndTime = endTime;
            task.TaskCategory = taskCategoryRepository.Get((Guid)CategorycomboBox.SelectedValue);
            task.TaskStatus = tasksStatusRepository.Get((Guid)StatuscomboBox.SelectedValue);
            task.User = usersRepository.Get(currentUser.Id);

            tasksRepository.Create(task);
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

        private void LoadRegularTasks()
        {
            TaskdataGridView.ClearSelection();
            var userRegularTasks = regularTaskRepository.GetAll()
                .Where(task => task.UserId == currentUser.Id)
                    .Select(x => new
                    {
                        x.Id,
                        TaskName = x.TaskName,
                        Frequency = x.Frequency,
                        LastExecuted = x.LastExecuted,
                        User = x.User.Username,
                        TaskCategory = x.TaskCategory != null ? x.TaskCategory.CategoryName : string.Empty,

                    })
                 .ToList();

            TaskdataGridView.DataSource = userRegularTasks;

            TaskdataGridView.Columns["Id"].Visible = false;
            TaskdataGridView.Columns["TaskName"].HeaderText = "Назва завдання";
            TaskdataGridView.Columns["Frequency"].HeaderText = "Частота";
            TaskdataGridView.Columns["LastExecuted"].HeaderText = "Останнє виконання";
            TaskdataGridView.Columns["User"].HeaderText = "Користувач";
            TaskdataGridView.Columns["TaskCategory"].HeaderText = "Категорія";

            TaskdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Updatenamebutton_Click(object sender, EventArgs e)
        {
            currentUser.Username = UsertextBox.Text;
            currentUser.Email = EmailChangetextBox.Text;

            UpdateUserFields();
            LoadTasks();
            LoadRegularTasks();

            ctx.SaveChanges(); 
        }

        private void UpdateUserFields()
        {
            UsertextBox.Text = currentUser.Username;
            EmailChangetextBox.Text = currentUser.Email;
        }

        private void Addregularbutton_Click(object sender, EventArgs e)
        {
            string taskName = RegularnametextBox.Text;
            int frequency = (int)RegularTasknumericUpDown.Value;
            DateTime lastExecuted = lastdateTimePicker.Value;

            RegularTask regularTask = new RegularTask();

            regularTask.TaskName = taskName;
            regularTask.Frequency = frequency;
            regularTask.LastExecuted = lastExecuted;
            regularTask.TaskCategory = taskCategoryRepository.Get((Guid)CategorycomboBoxtwo.SelectedValue);
            regularTask.User = usersRepository.Get(currentUser.Id);

            regularTaskRepository.Create(regularTask);
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
        }

        private void Updateregularbutton_Click(object sender, EventArgs e)
        {
            if (TaskdataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = TaskdataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = TaskdataGridView.Rows[selectedRowIndex];

                string regularTaskIdString = selectedRow.Cells["Id"].Value.ToString();
                Guid regularTaskId = Guid.Parse(regularTaskIdString);

                RegularTask regularTaskToUpdate = regularTaskRepository.Get(regularTaskId);

                if (regularTaskToUpdate != null)
                {
                    // Оновити значення полів об'єкта regularTaskToUpdate
                    regularTaskToUpdate.TaskName = RegularnametextBox.Text;
                    regularTaskToUpdate.Frequency = Convert.ToInt32(RegularTasknumericUpDown.Value);
                    regularTaskToUpdate.LastExecuted = lastdateTimePicker.Value;
                    regularTaskToUpdate.TaskCategory = taskCategoryRepository.Get((Guid)CategorycomboBoxtwo.SelectedValue);

                    regularTaskRepository.Update(regularTaskToUpdate);
                    LoadRegularTasks();
                }
                else
                {
                    MessageBox.Show("Немає даних для редагування.");
                }
            }
        }
    }
}