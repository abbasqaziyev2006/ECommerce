using ECommerce.BLL.Services.Contracts;
using ECommerce.DAL.DataContext.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class ProductController : Controller
{
    private readonly IProductService _productService;
    private readonly UserManager<AppUser> _userManager;

    public ProductController(IProductService productService,  UserManager<AppUser> userManager)
    {
        _productService = productService;
        _userManager = userManager;
    }

    public async Task<IActionResult> Details(string id)
    {
        int productId = int.Parse(id.Split('-').Last());

        var model = await _productService.GetAsync(
            x => x.Id == productId && !x.IsDeleted,
            query => query
                .Include(x => x.Category!)
                .Include(x => x.Images)
                .Include(x => x.ProductTags).ThenInclude(x => x.Tag!)
                .ThenInclude(r => r.AppUser!)
        );

        return View(model);
    }
}