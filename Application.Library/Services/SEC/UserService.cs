using Dapper;
using Domain.Library.Entities.SEC;
using Infrastructure.Library.Repositories.SEC;
using System.Data;

namespace Infrastructure.Library.Services.SEC
{
    public class UserService : UserRepository
    {
        public IEnumerable<User> GetList()
        {
            var data = base._query.Execute.Query<User>(@"
SELECT        SEC.Users.ID AS آیدی, SEC.Users.Guid AS کلید, SEC.Users.CreateDate AS [تاریخ ثبت], SEC.Users.CreateBy AS [ثبت توسط], SEC.Users.UpdateDate AS [تاریخ ویرایش], SEC.Users.UpdateBy AS [ویرایش وسط], 
                         SEC.Users.DeleteDate AS [تاریخ حذف], SEC.Users.DeleteBy AS [حذف توسط], SEC.Users.IsActive AS وضعیت
FROM            SEC.Users INNER JOIN
                         SEC.UserRoles ON SEC.Users.ID = SEC.UserRoles.UserID INNER JOIN
                         SEC.Role ON SEC.UserRoles.RoleID = SEC.Role.ID
WHERE        (SEC.Users.IsDeleted = 0)
").ToList();
            return base._query.Execute.Query<User>(@"
SELECT        SEC.Users.ID AS آیدی, SEC.Users.Guid AS کلید, SEC.Users.CreateDate AS [تاریخ ثبت], SEC.Users.CreateBy AS [ثبت توسط], SEC.Users.UpdateDate AS [تاریخ ویرایش], SEC.Users.UpdateBy AS [ویرایش وسط], 
                         SEC.Users.DeleteDate AS [تاریخ حذف], SEC.Users.DeleteBy AS [حذف توسط], SEC.Users.IsActive AS وضعیت
FROM            SEC.Users INNER JOIN
                         SEC.UserRoles ON SEC.Users.ID = SEC.UserRoles.UserID INNER JOIN
                         SEC.Role ON SEC.UserRoles.RoleID = SEC.Role.ID
WHERE        (SEC.Users.IsDeleted = 0)
").ToList();
            
        }
    }

}
