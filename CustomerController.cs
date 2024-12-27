using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Handlers;
using Shop.Domain.Commands.Requests;

namespace Shop.Controllers {

    [ApiController]
    [Route("v1/customers")]
        public class CustomerController : ControllerBase 
    {
         [HttpPost]
         [Route("")]
         public CreateCustomerResponse Create (
            [FromServices] ICreateCustomerHandler handler,
            [FromBody] CreateCustomerRequest command
         )
        
        {
            return handler.Handler(command);
        }
        
    }
}