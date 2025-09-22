using ECommerce.BLL.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Petshop.BLL.ViewModels;

namespace ECommerce.MVC.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly IHomeService _hometService;

        public FooterViewComponent(IHomeService homeervice)
        {
            _homeLayoutService = homeLayoutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _homeLayoutService.GetHomeLayoutDataAsync();

            if (model == null)
            {
                model = new HomeViewModel();
            }

            return View(model);
        }
    }
}
