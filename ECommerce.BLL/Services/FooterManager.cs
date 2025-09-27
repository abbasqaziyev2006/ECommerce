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

            //SocialLinks = await _dbContext.SocialLinks.ToListAsync(),

            //Newsletter = await _dbContext.NewsletterInfos
            //.OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync()
            //?? new NewsletterInfo { Title = "Join Us", Description = "Subscribe to newsletter", Icon = "fa-envelope" },

           
        };

        return footerViewModel;
    }
}