namespace TimeManager.Core.Entity
{
    public class Tasks: BaseEntity
    { 
        public string TaskName { get; set; }
        
        public int EstimatedTime { get; set; }
        
        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }

        public Guid UserId { get; set; }
        public virtual Users User { get; set; }

    }
}
