using DotnetStack.Core.Entities;
using DotnetStack.Core.Params;
using DotnetStack.Managers.Quotes;
using Microsoft.AspNetCore.Mvc;

namespace DotnetStack.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteManager _quoteManager;
        public QuoteController(IQuoteManager quoteManager)
        {
            _quoteManager = quoteManager;
        }

        [HttpGet]
        public IActionResult GetQuotes()
        {
            return Ok(_quoteManager.GetQuotes());
        }

        [HttpPost]
        public IActionResult CreateQuote(CreateQuoteParams createQuoteParams)
        {
            var createdQuote = _quoteManager.CreateQuote(createQuoteParams);
            return Ok(createdQuote);
        }
    }
}
