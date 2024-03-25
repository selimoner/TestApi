using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Application.Features.Stores.Queries.GetAllStores;

namespace TestApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IMediator mediator;

        public StoreController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStores()
        {
            var response = await mediator.Send(new GetAllStoresQueryRequest());
            return Ok(response);
        }
    }
}
