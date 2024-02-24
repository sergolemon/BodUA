using BlazorServerApp.ViewModels.Catalog;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Pages.Catalog
{
    public partial class Catalog
    {
        [Inject]
        public CatalogVm ViewModel { get; set; }
        [Parameter]
        public string? Categories { get; set; }
    }
}
