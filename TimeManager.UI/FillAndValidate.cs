using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeManager.UI
{
    public partial class TimeManagerForm : Form
    {
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
            CheckTaskRemindersForm();
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
            CheckTaskRemindersForm();
        }

        private bool ValidateDateTimePicker()
        {
            DateTime startDateTime = StartdateTimePicker.Value;
            DateTime endDateTime = EnddateTimePicker.Value;

            if (startDateTime > endDateTime)
            {
                MessageBox.Show("Початкова дата/час повинна бути ранішою за кінцеву дату/час.");
                return false;
            }

            return true;
        }
        
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
