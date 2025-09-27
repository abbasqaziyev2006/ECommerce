using ECommerce.BLL.Services.Contracts;
using ECommerce.BLL.ViewModels;
using ECommerce.DAL.DataContext;
using ECommerce.DAL.DataContext.Entities;
using Microsoft.EntityFrameworkCore;

public class HeaderManager : IHeaderService
{
    private readonly AppDbContext _dbContext;

    public HeaderManager(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<HeaderViewModel> GetHeaderAsync()
    {
        var headerViewModel = new HeaderViewModel
        {
            Logo = await _dbContext.Logos
            .OrderByDescending(x => x.CreatedAt)
            .FirstOrDefaultAsync(),

            //ContactInfo = await _dbContext.ContactInfos
            //.OrderByDescending(x => x.CreatedAt)
            //.FirstOrDefaultAsync() ?? new ContactInfo { Phone = "000-00-00", Email = "something@mail.com" },

            SearchInfo = await _dbContext.SearchInfos
            .OrderByDescending(x => x.CreatedAt)
            .FirstOrDefaultAsync() ?? new SearchInfo()
        };

        return headerViewModel;
    }
}