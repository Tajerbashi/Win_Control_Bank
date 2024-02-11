namespace Account.Application.Library.BaseModels
{
    public interface IBaseView
    {
        long Id { get; }
    }
    public abstract class BaseView : IBaseView
    {
        public long Id { get; set; }
    }

}
