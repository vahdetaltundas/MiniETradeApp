using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniETradeApp.Application.Repositories;
using MiniETradeApp.Application.Repositories.ProductRepositories;

namespace MiniETradeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _readRepository;
        private readonly IProductWriteRepository _writeRepository;

        public ProductsController(IProductWriteRepository writeRepository, IProductReadRepository readRepository)
        {
            _writeRepository = writeRepository;
            _readRepository = readRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            _writeRepository.AddAsync(new() {Name="Vahdet",Stock=10,Price=10 });
            _writeRepository.SaveAsync();
            return Ok();
        }
    }
}
