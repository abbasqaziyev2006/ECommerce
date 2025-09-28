using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.MVC.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly IHeaderService _headerService;

        public HeaderViewComponent(IHeaderService headerService)
        {
            _headerService = headerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _headerService.GetHeaderAsync();

            var basketList = new List<BasketItemViewModel>();

            var basketListJson = Request.Cookies["SUPPLEMENT_ECOMMERCE_BASKET"];

            if (string.IsNullOrEmpty(basketListJson))
            {
                model.BasketItems = basketList;
            }
            else
            {
                model.BasketItems = JsonConvert.DeserializeObject<List<BasketItemViewModel>>(basketListJson);
            }
            return View(model);
        }
    }
}
