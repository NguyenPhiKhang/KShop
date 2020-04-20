using KShop.Data.Inflastructure;
using KShop.Model.Models;

namespace KShop.Data.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }

    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}