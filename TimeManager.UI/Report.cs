using System.Windows.Forms.DataVisualization.Charting;
using TimeManager.Core.Context;
using TimeManager.Core.Entity;
using TimeManager.Repositories;

namespace TimeManager.UI
{
    public partial class Report : Form
    {
        private Users currentUser;
        private Repository<Tasks, Guid> tasksRepository;


        public Report(Users user)
        {
            InitializeComponent();
            currentUser = user;
            tasksRepository = new Repository<Tasks, Guid>(new TimeManagerContext());
        }

        private void Report_Load(object sender, EventArgs e)
        {
            UsertextBox.Text = currentUser.Username;
            LoadChartStatus();
            LoadChartCategory();
            CalculateTaskStatistics();
        }

        private void LoadChartStatus()
        {
            var taskStatusCounts = tasksRepository.GetAll()
                .Where(task => task.UserId == currentUser.Id)
                .GroupBy(task => task.TaskStatus?.StasusName ?? string.Empty)
                .Select(group => new
                {
                    Status = group.Key,
                    Count = group.Count()
                })
                .ToList();

            var chart = new Chart();
            chart.Width = 300;
            chart.Height = 300;
            chart.Location = new Point(349, 12);

            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            var series = new Series();
            series.ChartType = SeriesChartType.Pie;

            foreach (var statusCount in taskStatusCounts)
            {
                series.Points.AddXY(statusCount.Status, statusCount.Count);
            }

            chart.Series.Add(series);

            this.Controls.Add(chart);
        }

        private void LoadChartCategory()
        {
            var taskCategoryCounts = tasksRepository.GetAll()
                .Where(task => task.UserId == currentUser.Id)
                .GroupBy(task => task.TaskCategory?.CategoryName ?? string.Empty)
                .Select(group => new
                {
                    Category = group.Key,
                    Count = group.Count()
                })
                .ToList();

            var chart = new Chart();
            chart.Width = 300;
            chart.Height = 300;
            chart.Location = new Point(349, 350);
            chart.Palette = ChartColorPalette.Berry;

            var chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            var series = new Series();
            series.ChartType = SeriesChartType.Pie;

            foreach (var categoryCount in taskCategoryCounts)
            {
                series.Points.AddXY(categoryCount.Category, categoryCount.Count);
            }

            chart.Series.Add(series);

            this.Controls.Add(chart);
        }

        private void CalculateTaskStatistics()
        {

            var taskCount = tasksRepository.GetAll()
                .Count(task => task.UserId == currentUser.Id);

            var completedTaskCount = tasksRepository.GetAll()
                .Count(task => task.UserId == currentUser.Id && task.TaskStatus?.StasusName == "Виконано");

            var inProgressTaskCount = tasksRepository.GetAll()
                .Count(task => task.UserId == currentUser.Id && task.TaskStatus?.StasusName == "В процесі");

            var notStartedTaskCount = tasksRepository.GetAll()
                .Count(task => task.UserId == currentUser.Id && task.TaskStatus?.StasusName == "Не розпочато");

            AmountOfTasktextBox.Text = taskCount.ToString();
            DonetextBox.Text = completedTaskCount.ToString();
            ProgrestextBox.Text = inProgressTaskCount.ToString();
            NoStartedtextBox.Text = notStartedTaskCount.ToString();
        }
    }
}

