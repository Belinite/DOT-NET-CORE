using System.Linq;
using Store.Models;

namespace WebApplication.Repositories
{
    public interface IOrdersRepository
    {
        Orders Get(int GoodId);
    }
    public class OrdersRepository : IOrdersRepository
    {
        private StoreContext db = new StoreContext();
        public Orders Get(int id)
        {
            var sql = db.Orders.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
            return sql;
        }
    }

}

