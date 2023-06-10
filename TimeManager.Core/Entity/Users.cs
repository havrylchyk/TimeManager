namespace TimeManager.Core.Entity
{
    public class Users :BaseEntity
    {
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string Email { get; set; }
 
        public virtual ICollection<Tasks>? Tasks { get; set; }
    }
}
