namespace Infrastructure.Library.BaseModels
{
    public abstract class BaseDTO
    {
    }
    public abstract class GeneralBaseDTO : BaseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }

}
