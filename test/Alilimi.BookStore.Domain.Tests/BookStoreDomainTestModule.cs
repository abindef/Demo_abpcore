using Alilimi.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Alilimi.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}