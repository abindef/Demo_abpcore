using Volo.Abp.Modularity;

namespace Alilimi.BookStore
{
    [DependsOn(
        typeof(BookStoreApplicationModule),
        typeof(BookStoreDomainTestModule)
        )]
    public class BookStoreApplicationTestModule : AbpModule
    {

    }
}