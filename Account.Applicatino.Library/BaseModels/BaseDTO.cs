namespace Account.Application.Library.BaseModels
{
    public interface IBaseDTO
    {
        long ID { get; set; }
    }
    public abstract class BaseDTO: IBaseDTO
    {
        public long ID { get; set; }
    }
    public abstract class GeneralDTO : BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
