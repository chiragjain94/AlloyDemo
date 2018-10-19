using EPiServer.Core;

namespace AlloyDemo_Search.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
