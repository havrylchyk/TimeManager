using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TimeManager.Core.Entity
{
    public class BaseEntity
    {
        [Browsable(false)]
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
