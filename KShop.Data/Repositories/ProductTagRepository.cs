using KShop.Data.Inflastructure;
using KShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KShop.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {
    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
