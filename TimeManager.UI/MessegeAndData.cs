using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TimeManager.Core.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace TimeManager.UI
{
    public partial class TimeManagerForm : Form
    {
        private void Updateregularbutton_Click(object sender, EventArgs e)
        {
            if (TaskdataGridView.SelectedCells.Count > 0)
            {
                int selectedRowIndex = TaskdataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = TaskdataGridView.Rows[selectedRowIndex];

                string regularTaskIdString = selectedRow.Cells["Id"].Value.ToString();
                Guid regularTaskId = Guid.Parse(regularTaskIdString);

                RegularTask regularTaskToUpdate = regularTaskRepository.Get(regularTaskId);
                if (RegularnametextBox.Text == "" || RegularnametextBox.Text == null)
                {
                    MessageBox.Show("Поле не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (regularTaskToUpdate != null)
                {
                    if (RegularTasknumericUpDown.Value > 0 && RegularTasknumericUpDown.Value < 8)
                    {
                        regularTaskToUpdate.TaskName = RegularnametextBox.Text;
                        regularTaskToUpdate.Frequency = Convert.ToInt32(RegularTasknumericUpDown.Value);
                        regularTaskToUpdate.LastExecuted = lastdateTimePicker.Value;
                        regularTaskToUpdate.TaskCategory = taskCategoryRepository.Get((Guid)CategorycomboBoxtwo.SelectedValue);

                        regularTaskRepository.Update(regularTaskToUpdate);
                    }
                    else
                    {
                        MessageBox.Show("Регулярене завдання не може виконуватись більше раз ніж є днів тижня.");
                    }
                    LoadRegularTasks();
                }
                else
                {
                    MessageBox.Show("Немає даних для редагування.");
                }
            }
        }

        private void Updatenamebutton_Click(object sender, EventArgs e)
        {
            if (UsertextBox.Text == "" || UsertextBox.Text == null)
            {
                MessageBox.Show("Поле з ім'ям не має бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsValidEmail(EmailChangetextBox.Text))
            {
                var user = ctx.Users.Find(currentUser.Id);
                user.Username = UsertextBox.Text;
                user.Email = EmailChangetextBox.Text;

                ctx.SaveChanges();
                LoadTasks();
                LoadRegularTasks();
            }
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            Report reportform = new Report(currentUser);
            reportform.Show();
        }

        private void CheckTaskRemindersForm()
        {
            DateTime currentTime = DateTime.Now;

            List<Tasks> userTasks = tasksRepository.GetAll().Where(t => t.User.Id == currentUser.Id).ToList();

            foreach (Tasks task in userTasks)
            {
                TimeSpan timeUntilStart = task.StartTime - currentTime;

                if (timeUntilStart.TotalMinutes <= 15 && timeUntilStart.TotalMinutes > 0)
                {
                    MessageBox.Show($"Завдання '{task.TaskName}' розпочнеться через 15 хвилин.", "Нагадування", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Reminderbutton_Click(object sender, EventArgs e)
        {
            CheckTaskRemindersForm();
            CheckTaskReminders();
        }

        private void SendNotificationEmail(string taskName, DateTime startTime)
        {
            string smtpAddress = "smtp.gmail.com";
            int smtpPort = 25;
            string email = "TimeManagerMessage@gmail.com";
            string appPassword = "gihuwkpuqkgdunjg";

            // Створюємо SMTP клієнт з допомогою аторизаційного токену
            SmtpClient smtpClient = new SmtpClient(smtpAddress, smtpPort);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(email, appPassword);

            // Створюємо повідомлення
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(email);
            mailMessage.To.Add(EmailChangetextBox.Text);
            mailMessage.Subject = "нагадування";
            mailMessage.Body = $"Ваше завдання {taskName} розпочнеться O {startTime}.";

            try
            {
                // Send the email
                smtpClient.Send(mailMessage);
                MessageBox.Show("Лист надіслано.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка надсилання листа: " + ex.Message);
            }
        }

        private void CheckTaskReminders()
        {
            DateTime currentTime = DateTime.Now;

            List<Tasks> userTasks = tasksRepository.GetAll().Where(t => t.User.Id == currentUser.Id).ToList();

            foreach (Tasks task in userTasks)
            {
                TimeSpan timeUntilStart = task.StartTime - currentTime;

                if (timeUntilStart.TotalMinutes <= 15 && timeUntilStart.TotalMinutes > 0)
                {
                    SendNotificationEmail(task.TaskName, task.StartTime);
                }
            }
        }


    }
    
}
