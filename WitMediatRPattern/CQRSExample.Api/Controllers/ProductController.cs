using CQRSExample.Domain.CQRS.Commands.Request;
using CQRSExample.Domain.CQRS.Handlers.CommandHandlers;
using CQRSExample.Domain.CQRS.Handlers.QueryHandlers;
using CQRSExample.Domain.CQRS.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CQRSExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private IMediator _mediator;

        public ProductController(ILogger<ProductController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest requestModel)
        {
            var allProducts = await _mediator.Send(requestModel);
            return Ok(allProducts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] GetByIdProductQueryRequest requestModel)
        {
            var product = await _mediator.Send(requestModel);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest requestModel)
        {
            var response =await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] DeleteProductCommandRequest requestModel)
        {
            var response =_mediator.Send(requestModel);
            return Ok(response);
        }
    }
}