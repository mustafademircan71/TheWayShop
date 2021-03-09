using Core.DataAccess.Abstract;
using TheWayShop.Model.Entity;

namespace TheWayShop.DataAccess.Abstract
{
    public interface IAdminRepository:IRepository<Admin>
    {
        Admin LogIn(string email, string password, params string[] includeList);
    }

   
}
