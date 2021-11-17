using DotnetStack.Core.Entities;
using DotnetStack.Core.Interfaces;
using DotnetStack.Core.Params;
using DotnetStack.DataAccessHandlers.Quotes;

namespace DotnetStack.Managers.Quotes
{
    public class QuoteManager: IQuoteManager
    {
        private readonly IQuoteHandler _quoteHandler;
        private readonly IUnitOfWork _unitOfWork;

        public QuoteManager(IQuoteHandler quoteHandler, IUnitOfWork unitOfWork)
        {
            _quoteHandler = quoteHandler;
            _unitOfWork = unitOfWork;
        }


        public Quote CreateQuote(CreateQuoteParams createQuoteParams)
        {
            var quote =  _quoteHandler.Insert(new Quote
            {
                FirstName = createQuoteParams.FirstName,
                LastName = createQuoteParams.LastName,
                Text = createQuoteParams.Text,
            });
            _unitOfWork.Commit();
            return quote;
        }

        public List<Quote> GetQuotes()
        {
            return _quoteHandler.GetAll().ToList();
        }
    }
}