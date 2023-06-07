namespace TimeManager.Core.Entity
{
    public class StudyTasks : BaseEntity
    {
        public string StudyTaskName { get; set; }

        public int EstimatedTime { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Guid UserId { get; set; }
        public virtual Users User { get; set; }
    }
}
