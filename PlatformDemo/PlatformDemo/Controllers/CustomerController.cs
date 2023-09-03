using Microsoft.AspNetCore.Mvc;
using PlatformDemo.Core.Contracts;
using PlatformDemo.Core.Model;
using PlatformDemo.Models;

namespace PlatformDemo.Controllers;

public class CustomerController: Controller
{
    private readonly IRepository<Customer> _customerRepository;

    public CustomerController(IRepository<Customer> customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public IActionResult GetCustomerListRow(Guid id, bool isSelected)
    {
        var customer = _customerRepository.Get(x => x.Id == id).FirstOrDefault();
        
        return ViewComponent("CustomerListRow", new { model = new Selectable<Customer> 
            { 
                Item = customer, 
                IsSelected = isSelected 
            }
        });
    }
}