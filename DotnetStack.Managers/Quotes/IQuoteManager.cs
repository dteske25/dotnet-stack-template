using DotnetStack.Core.Entities;
using DotnetStack.Core.Params;

namespace DotnetStack.Managers.Quotes
{
    public interface IQuoteManager
    {
        Quote CreateQuote(CreateQuoteParams createQuoteParams);
        List<Quote> GetQuotes();
    }
}
