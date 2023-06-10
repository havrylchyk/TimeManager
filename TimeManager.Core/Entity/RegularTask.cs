namespace TimeManager.Core.Entity
{
    public class RegularTask: BaseEntity
    {        
        public string TaskName { get; set; }

        public int Frequency { get; set; } // Частота виконання 
        
        public DateTime LastExecuted { get; set; } // Останнє виконання

        public Guid TaskCategoryId { get; set; }
        public virtual TaskCategory? TaskCategory { get; set; }

        public Guid UserId { get; set; }
        public virtual Users User { get; set; }
    }
}
