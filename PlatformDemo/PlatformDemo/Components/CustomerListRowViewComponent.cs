using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Core.Model;
using PlatformDemo.Models;

namespace PlatformDemo.Components;

public class CustomerListRowViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(Customer model)
    {
        return View(new Selectable<Customer>()
        {
            Item = model
        });
    }
}