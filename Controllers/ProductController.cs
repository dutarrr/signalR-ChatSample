using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs;
using SignalRChat.Models;


namespace SignalRChat.Controllers
{
    public class ProductController : Controller
    {
        private readonly IHubContext<ProductHub> _hubContext;

        public ProductController(IHubContext<ProductHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public ActionResult Index()
        {
            return View(MemoryCache.Products);
        }

        public ActionResult Add()
        {
            return View(MemoryCache.Products);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Product product)
        {
            MemoryCache.Products.Add(product);

            await _hubContext.Clients.All.SendAsync("ReceiveProductMessage", product);

            return View(MemoryCache.Products);
        }
    }
}