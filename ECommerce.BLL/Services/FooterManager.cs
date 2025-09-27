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
            //Logo = await _dbContext.Logos
            //.OrderByDescending(x => x.CreatedAt)
            //.FirstOrDefaultAsync(),

            Socials = await _dbContext.Socials.ToListAsync(),
           
        };

        return footerViewModel;
    }
}