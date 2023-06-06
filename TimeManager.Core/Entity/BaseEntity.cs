using System.ComponentModel.DataAnnotations;

namespace TimeManager.Core.Entity
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
