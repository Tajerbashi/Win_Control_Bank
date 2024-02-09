using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Library.Bases
{
    public interface IBaseEntity
    {
    }
    public abstract class BaseEntity<T> : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T ID { get; set; }

    }
    public abstract class BaseEntity : BaseEntity<long>
    {
        public Guid Guid { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public long CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public long? UpdateBy { get; set; }
    }
    public abstract class GeneralEntity : BaseEntity
    {
        public DateTime? DeleteDate { get; set; }
        public long? DeleteBy { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
