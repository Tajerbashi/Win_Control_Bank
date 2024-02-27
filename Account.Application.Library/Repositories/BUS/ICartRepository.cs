using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.FilterModel;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Enums;

namespace Account.Application.Library.Repositories.BUS
{
    public interface ICartRepository : IGenericRepository<Cart, CartDTO, CartView>, IBaseQueries
    {
     
        /// <summary>
        /// دریافت کلید و مقدار کارت های بانکی که سر شاخه هستند
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> TitleValuesBankingParent();
       
        /// <summary>
        /// دریافت کلید و مقدار کارت های نقدی که سر شاخه هستند
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> TitleValuesCashableParent();
        
        /// <summary>
        /// دریافت مدل کارت بر اساس شماره کارت
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        CartDTO GetCartByAccountNumber(string number);
        
        /// <summary>
        /// دریافت تمام کارت ها
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> TitleValuesAllCart();
        
        /// <summary>
        /// دریافت تمام کارت ها بر اساس بانک آیذی
        /// </summary>
        /// <param name="bankID"></param>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> TitleValuesCartByBankId(long bankID);
        
        /// <summary>
        /// دریافت کارت های زیر شاخه ها بر اساس کلید کارت سرشاخه
        /// </summary>
        /// <param name="cartID"></param>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> TitleValuesChild(long cartID);
        
        /// <summary>
        /// دریافت کارت های یک کاربر بر اساس کلید کاریر
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> TitleValueByUserID(long customerID);
        
        /// <summary>
        /// دریافت کلید و مقدار کارت های که حساب مشترک یا حساب اصلی هستند
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IEnumerable<KeyValue<long>> TitleValuesMainCarts(long Id);
     
        /// <summary>
        /// بررسی معتبر بودن مقدار تراکنش و موجودی کارت
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="cash"></param>
        /// <returns></returns>
        bool ValidBlancForTransaction(long cartId, double cash);
      
        /// <summary>
        /// جستجو بر اساس کارت آیدی
        /// </summary>
        /// <param name="cartId"></param>
        /// <param name="paging"></param>
        /// <returns></returns>
        string SearchByCartId(long cartId, string paging);

        /// <summary>
        /// نمایش گردش کارت
        /// </summary>
        /// <param name="paging"></param>
        /// <returns></returns>
        string SearchBlancingOfCart(GridFilter filter, string paging);


        /// <summary>
        /// عنوان و مقدار درجه حساب
        /// </summary>
        /// <returns></returns>
        IEnumerable<KeyValue<CartType>> TitleValuesDegreeCart();


        /// <summary>
        /// دریافت تمام کارت ها و موجودی های کنونی
        /// </summary>
        /// <returns></returns>
        IEnumerable<CartView> GetAllCartWithDetails();

    }
}
