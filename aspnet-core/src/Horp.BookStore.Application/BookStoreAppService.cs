using System;
using System.Collections.Generic;
using System.Text;
using Horp.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Horp.BookStore;

/* Inherit your application services from this class.
 */
public abstract class BookStoreAppService : ApplicationService
{
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
