using System.ComponentModel.DataAnnotations;

namespace Codebridge_Test.Domain.Entities
{
    public abstract class Entity
    {
        [Required]
        public int Id { get; set; }
    }
}
