using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext;
using Microsoft.EntityFrameworkCore;

public class FooterManager : IFooterService
{
    private readonly AppDbContext _dbContext;

    public FooterManager(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<FooterViewModel> GetFooterAsync()
    {
        var footerViewModel = new FooterViewModel
        {


            Socials = await _dbContext.Socials.ToListAsync(),
            Currencies = await _dbContext.Currencies.ToListAsync(),
            ContactInfo = await _dbContext.ContactInfos.FirstOrDefaultAsync(),
            Languages = await _dbContext.Languages.ToListAsync(),
            Categories = await _dbContext.Categories.ToListAsync()


        };

        return footerViewModel;
    }
}