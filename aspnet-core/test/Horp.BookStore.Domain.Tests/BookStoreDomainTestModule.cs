using Volo.Abp.Modularity;

namespace Horp.BookStore;

[DependsOn(
    typeof(BookStoreDomainModule),
    typeof(BookStoreTestBaseModule)
)]
public class BookStoreDomainTestModule : AbpModule
{

}
