namespace Infrastructure.Library.BaseModels
{
    public abstract class BaseDTO
    {
        public long ID { get; set; }
    }
    public abstract class GeneralBaseDTO : BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
