using TimeManager.Core.Context;
using TimeManager.Core.Entity;
using TimeManager.Repositories;

namespace TimeManager.UI
{
    public partial class TimeManagerForm : Form
    {
        private Users currentUser;

        private Repository<TaskCategory, Guid> categoryrepository;
        private Repository<TasksStatus, Guid> tasksstatusrepository;
        private Repository<Tasks, Guid> taskRepository;


        public TimeManagerForm(Users users)
        {
            currentUser = users;
            categoryrepository = new Repository<TaskCategory, Guid>(new TimeManagerContext());
            tasksstatusrepository = new Repository<TasksStatus, Guid>(new TimeManagerContext());
            taskRepository = new Repository<Tasks, Guid>(new TimeManagerContext());
            InitializeComponent();
            CategorycomboBoxFill();
            StatuscomboBoxFill();
            LoadTasks();
        }

        private void TimeManagerForm_Load(object sender, EventArgs e)
        {
            UsertextBox.Text = currentUser.Username;
        }

        private void TimeManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm.Instance.Close();
        }

        private void CategorycomboBoxFill()
        {
            try
            {
                var categories = categoryrepository.GetAll().ToList();

                CategorycomboBox.Items.Clear();

                foreach (var category in categories)
                {
                    CategorycomboBox.Items.Add(category.CategoryName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CategorycomboBoxFill: {ex.Message}");
            }
        }

        private void StatuscomboBoxFill()
        {
            try
            {
                var statuses = tasksstatusrepository.GetAll().ToList();

                StatuscomboBox.Items.Clear();

                foreach (var status in statuses)
                {
                    StatuscomboBox.Items.Add(status.StasusName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in CategorycomboBoxFill: {ex.Message}");
            }
        }

        private void LoadTasks()
        {
            var directors = taskRepository.GetAll();
            TaskdataGridView.DataSource = directors;
            

            TaskdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TaskdataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            foreach (DataGridViewColumn column in TaskdataGridView.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            TaskdataGridView.ScrollBars = ScrollBars.Vertical;
        }

        private void AddTask(Tasks task)
        {
            taskRepository.Create(task);
            taskRepository.Save();
            LoadTasks();
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {

            string taskeName = taskNametextBox.Text;
            DateTime startTime = StartdateTimePicker.Value;
            DateTime endTime = EnddateTimePicker.Value;
            string selectedCategory = CategorycomboBox.SelectedItem.ToString();
            string selectedStatus = StatuscomboBox.SelectedItem.ToString();

            Guid categoryId = categoryrepository.GetIdByName(selectedCategory);

            Guid statusId = tasksstatusrepository.GetIdByName(selectedStatus);

            Tasks task = new Tasks
            {
               TaskName = taskeName,
               StartTime = startTime,
               EndTime = endTime,
               TaskCategoryId = categoryId,
               TaskStatusId = statusId,
               UserId = currentUser.Id
            };

            AddTask(task);
        }
       
    }
}