namespace TimeManager.Core.Entity
{
    public class Tasks: BaseEntity
    { 
        public string TaskName { get; set; }
                
        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }

        public Guid UserId { get; set; }
        public virtual Users User { get; set; }

        public Guid TaskCategoryId { get; set; }
        public virtual TaskCategory TaskCategory { get; set; }

        public Guid TaskStatusId { get; set; }
        public virtual TasksStatus TaskStatus { get; set; }
    }
}
