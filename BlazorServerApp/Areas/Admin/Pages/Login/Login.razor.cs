using BlazorServerApp.Areas.Admin.ViewModels.Login;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Areas.Admin.Pages.Login
{
    public partial class Login
    {
        [Inject]
        public LoginVm ViewModel { get; set; }
    }
}
