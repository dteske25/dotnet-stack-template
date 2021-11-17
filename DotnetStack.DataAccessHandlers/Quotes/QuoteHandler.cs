using DotnetStack.Core.Entities;
using DotnetStack.Core.Interfaces;
using DotnetStack.DataAccessHandlers.Infrastructure.EntityFramework;

namespace DotnetStack.DataAccessHandlers.Quotes
{
    internal class QuoteHandler : BaseEntityHandler<Quote>, IQuoteHandler
    {
        public QuoteHandler(IDbSetFactory dbSetFactory) : base(dbSetFactory)
        {
        }
    }
}
