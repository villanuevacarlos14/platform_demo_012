using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Core.Contracts;
using PlatformDemo.Core.Model;
using System.Linq.Expressions;
using System.Linq;

namespace PlatformDemo.Components;

public class CustomerListViewComponent : ViewComponent
{
    private readonly IRepository<Customer> _customerRepository;
    public CustomerListViewComponent(IRepository<Customer> customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public IViewComponentResult Invoke()
    {
        return View(_customerRepository.Get(navigationPaths: x=>x.Orders));
    }
}