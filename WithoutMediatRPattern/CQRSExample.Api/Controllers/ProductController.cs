using CQRSExample.Domain.CQRS.Commands.Request;
using CQRSExample.Domain.CQRS.Handlers.CommandHandlers;
using CQRSExample.Domain.CQRS.Handlers.QueryHandlers;
using CQRSExample.Domain.CQRS.Queries.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CQRSExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
        private readonly GetAllProductQueryHandler _getAllProductQueryHandler;
        private readonly GetByIdProductQueryHandler _getByIdProductQueryHandler;

        public ProductController(ILogger<ProductController> logger,
            CreateProductCommandHandler createProductCommandHandler,
            DeleteProductCommandHandler deleteProductCommandHandler,
            GetAllProductQueryHandler getAllProductQueryHandler,
            GetByIdProductQueryHandler getByIdProductQueryHandler
            )
        {
            _logger = logger;
            _createProductCommandHandler = createProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getAllProductQueryHandler = getAllProductQueryHandler;
            _getByIdProductQueryHandler = getByIdProductQueryHandler;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] GetAllProductQueryRequest requestModel)
        {
            var allProducts = _getAllProductQueryHandler.GetAllProduct(requestModel);
            return Ok(allProducts);
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromQuery] GetByIdProductQueryRequest requestModel)
        {
            var product = _getByIdProductQueryHandler.GetByIdProduct(requestModel);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProductCommandRequest requestModel)
        {
            var response = _createProductCommandHandler.CreateProduct(requestModel);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromQuery] DeleteProductCommandRequest requestModel)
        {
            var response = _deleteProductCommandHandler.DeleteProduct(requestModel);
            return Ok(response);
        }
        
    }
}