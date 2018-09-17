using Microsoft.AspNetCore.Mvc;

namespace TestTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoadCopnentViewWithTaghelper()
        {
            try
            {
                return ViewComponent("Tasks", new { Message = "this view page is from Home/LoadCopnentViewWithTaghelper" });
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message+System.Environment.NewLine+ex.StackTrace);
            }
        }
    }
}