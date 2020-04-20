using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework.EndpointTests;
using static Tests.Framework.EndpointTests.UrlTester;

namespace Tests.XPack.AsyncSearch.Delete
{
	public class AsyncSearchDeleteTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await DELETE("/_async_search/search_id")
			.Fluent(c => c.AsyncSearch.Delete("search_id", f => f))
			.Request(c => c.AsyncSearch.Delete(new AsyncSearchDeleteRequest("search_id")))
			.FluentAsync(c => c.AsyncSearch.DeleteAsync("search_id", f => f))
			.RequestAsync(c => c.AsyncSearch.DeleteAsync(new AsyncSearchDeleteRequest("search_id")));
	}
}
