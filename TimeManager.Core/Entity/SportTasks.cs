namespace TimeManager.Core.Entity
{
    public class SportTasks: BaseEntity
    { 
        public string SportTaskName { get; set; }
                
        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }

        public Guid UserId { get; set; }
        public virtual Users User { get; set; }

    }
}
