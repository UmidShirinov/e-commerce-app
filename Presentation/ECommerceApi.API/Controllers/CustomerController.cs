using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IOrdersWriteRepository _ordersWriteRepository;
        public CustomerController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository, IOrdersWriteRepository ordersWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _ordersWriteRepository = ordersWriteRepository;
        }


        [HttpGet]
        public async void Get()
        {   var customerId=Guid.NewGuid();  
            await _customerWriteRepository.AddAsync(new() { Id=customerId,Name="umid"});
           await _ordersWriteRepository.AddAsync(new() {Description="ad" , Id=Guid.NewGuid() , Address="asdad",CustomerId=customerId.ToString()  });
            await _ordersWriteRepository.SaveAsync();
        }
    }
}
