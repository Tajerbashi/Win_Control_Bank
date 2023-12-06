using Infrastructure.Library.Repositories.BUS;

namespace Infrastructure.Library.Services.BUS
{
    public class BankService : BankRepository
    {
        private void ShowData()
        {
            base._gridQuery.Execute(base.ShowAll(base._paging.Order(base._paging.Page)));
        }
    }
}
