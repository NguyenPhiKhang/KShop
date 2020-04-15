using System;

namespace KShop.Data.Inflastructure
{
    public interface IDbFactory : IDisposable
    {
        KShopDbContext Init();
    }
}