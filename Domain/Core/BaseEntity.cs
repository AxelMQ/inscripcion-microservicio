using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Core
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
}