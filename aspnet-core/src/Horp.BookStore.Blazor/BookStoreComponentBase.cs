using Horp.BookStore.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Horp.BookStore.Blazor;

public abstract class BookStoreComponentBase : AbpComponentBase
{
    protected BookStoreComponentBase()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
