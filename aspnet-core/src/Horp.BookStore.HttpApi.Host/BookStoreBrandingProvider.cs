using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Horp.BookStore;

[Dependency(ReplaceServices = true)]
public class BookStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookStore";
}
