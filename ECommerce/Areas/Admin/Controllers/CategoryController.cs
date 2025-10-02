using ECommerce.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.MVC.Areas.Admin.Controllers
{
    //[Area("Admin")]
    //public class CategoryController : Controller
    //{
    //    private readonly AdminCategoryManager _adminCategoryService;

    //    public CategoryController(AdminCategoryManager adminCategoryService)
    //    {
    //        AdminCategoryManager = adminCategoryService;
    //    }

    //    public async Task<IActionResult> Index()
    //    {
    //        var model = await _adminCategoryService.GetTableAsync();

    //        return View(model);
    //    }

    //    public async Task<IActionResult> Edit(int id)
    //    {
    //        var model = await _adminCategoryService.GetUpdateModel(id);

    //        if (model == null) return NotFound();

    //        return View(model);
    //    }
    //}
}
