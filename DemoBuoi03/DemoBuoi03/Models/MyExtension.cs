using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DemoBuoi03.Models
{
	public static class MyExtension
	{
		public static string MongToiTet(this DateTime tetHoliday)
		{
			return $"Còn {(tetHoliday - DateTime.Now).Days} ngày nữa đến Tết";
		}

		public static IHtmlContent Welcome(this IHtmlHelper helper, string name="David")
		{
			return new HtmlString($"<h1> Hello, welcome {name} to my class</h1>");
		}

    }
}
