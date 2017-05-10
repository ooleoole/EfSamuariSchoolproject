using Microsoft.AspNetCore.Mvc;
using SamuariWEB.Services;

namespace SamuraiWEB.ViewComponents
{
    public class GreetingViewComponent : ViewComponent
    {
        private readonly IGreeter _greeter;

        public GreetingViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetGreeter();
            return View("Default", model);
        }
    }
}