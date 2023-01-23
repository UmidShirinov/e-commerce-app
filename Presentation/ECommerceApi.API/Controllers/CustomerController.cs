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
        public CustomerController(ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;

        }


        [HttpGet]
        public void Get()
        {
            _customerWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid() , CreatedDay=DateTime.UtcNow,Name="Product 1" } }
                );

            _customerWriteRepository.SaveAsync();
        }
    }
}
