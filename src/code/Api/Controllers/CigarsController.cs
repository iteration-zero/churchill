using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IterationZero.Churchill.WebApi.Controllers
{
    /// <inheritdoc />
    /// <summary>
    /// API controller for managing cigars.
    /// </summary>
    [Route("api/[controller]")]
    public class CigarsController : Controller
    {
        [HttpPost]
        public async Task Post()
        {
        }
    }
}