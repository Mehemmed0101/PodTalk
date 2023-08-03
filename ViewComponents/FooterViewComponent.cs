using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PodTalk.DataAccessLayer;

namespace PodTalk.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _dbContext;

        public FooterViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footer = _dbContext.Footer.Include(x => x.SocialMedia).FirstOrDefault();

            return View(footer);
        }
    }
}