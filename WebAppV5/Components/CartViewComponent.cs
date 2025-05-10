using Microsoft.AspNetCore.Mvc;

namespace WebAppV5.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
