namespace Domain.Library.Bases
{
    public interface IBaseEntity
    {
        Guid Guid { get; set; }
    }
    public abstract class BaseEntity<T> : IBaseEntity
    {
        public Guid Guid { get; set; }
        public T ID { get; set; }
        public DateTime CreateDate { get; set; }
        public T CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public T UpdateBy { get; set; }
        public DateTime DeleteDate { get; set; }
        public T DeleteBy { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<long>
    {

    }
    public abstract class GeneralEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
