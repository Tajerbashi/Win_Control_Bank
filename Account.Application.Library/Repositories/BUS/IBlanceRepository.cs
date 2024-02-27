using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;

namespace Account.Application.Library.Repositories.BUS
{
    public interface IBlanceRepository : IGenericRepository<Blance, BlanceDTO, BlanceView>, IBaseQueries
    {
        #region CashableBlances

        /// <summary>
        /// دریافت 50 تراکنش حساب های نقدی
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        string Show50LastCashableTransactions(string paging);

        /// <summary>
        /// نمایش تراکنش های نقدی بر اساس کارت آیدی
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="paging"></param>
        /// <returns></returns>
        string ShowCashableTransactionsByCartID(long cartId, string paging);

        /// <summary>
        /// دریافت تمام تراکنش های نقدی
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        string ShowAllCashableBlances(string paging);

        /// <summary>
        /// دریافت موجودی نقدی بر اساس کارت آیدی
        /// </summary>
        /// <param name="cartId"></param>
        /// <returns></returns>
        double? GetCashableBlanceByCartId(long cartId);

        /// <summary>
        /// غیرفعال کردن آخرین تراکنش های نقدی فعال بر اساس کارت آیدی
        /// </summary>
        /// <param name="cartId"></param>
        void DisActiveLastCashableBlanceOfCartById(long cartId);

        #endregion

        #region BankingBlances


        /// <summary>
        /// دریافت 50 تراکنش حساب های بانکی
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        string Show50LastBankingTransactions(string paging);

        /// <summary>
        /// نمایش تراکنش های بانکی بر اساس کارت آیدی
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="paging"></param>
        /// <returns></returns>
        string ShowBankingTransactionsByCartID(long cartId, string paging);

        /// <summary>
        /// نمایش تمام تراکنش های بانکی
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        string ShowAllBankingBlances(string paging);

        /// <summary>
        /// دریافت آخرین مووجودی براساس کارت آیدی
        /// </summary>
        /// <param name="cartId"></param>
        /// <returns></returns>
        double? GetBankingBlanceByCartId(long cartId);

        /// <summary>
        /// غیر فعال کردن آخرین تراکنش های بانکی بر اساس کارت آیدی
        /// </summary>
        /// <param name="cartId"></param>
        void DisActiveLastBankingBlanceOfCartById(long cartId);

        #endregion

        /// <summary>
        /// انواع تراکنش ها
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<byte>> TitleValueTransactionType();

        /// <summary>
        /// انواع موجودی ها
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<byte>> TitleValueBlanceType();

       

    }
}
