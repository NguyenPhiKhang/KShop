using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KShop.Data.Inflastructure
{
    public class DbFactory: Disposable, IDbFactory
    {
        KShopDbContext dbContext;
        public KShopDbContext Init()
        {
            return dbContext ?? (dbContext = new KShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
