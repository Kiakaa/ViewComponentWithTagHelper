using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Winter.Component
{
    public class Test : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string message)
        {
            var data = await Task.Run(() => 1 == 1);
            return View("Default", message);
        }
    }
}
