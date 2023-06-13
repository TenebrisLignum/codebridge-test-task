using System.ComponentModel.DataAnnotations;

namespace CodebridgeTest.Domain.Entities
{
    public abstract class Entity
    {
        [Required]
        public int Id { get; set; }
    }
}
