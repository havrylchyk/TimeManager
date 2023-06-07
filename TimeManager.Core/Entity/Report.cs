namespace TimeManager.Core.Entity
{
    public class Report : BaseEntity
    {
        public Guid UserId { get; set; }
        public virtual ICollection<Users> User { get; set; }

        public Guid TaskId { get; set; }
        public virtual ICollection<SportTasks> Task { get; set; }

        public DateTime ReportDate { get; set; }
        public int TaskTime { get; set; }
    }
}
