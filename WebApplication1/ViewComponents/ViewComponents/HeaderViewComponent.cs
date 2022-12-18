using WebApplication1.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApplication1.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(HeaderVM headerVM)
        {

            return View(await Task.FromResult(headerVM));
        }
    }

    public class HeaderVM
    {
    }
}