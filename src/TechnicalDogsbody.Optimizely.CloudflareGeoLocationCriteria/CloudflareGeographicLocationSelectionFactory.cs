using System.Globalization;
using EPiServer.Personalization.VisitorGroups;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria;

public class CloudflareGeographicLocationSelectionFactory : ISelectionFactory
{
	public IEnumerable<SelectListItem> GetSelectListItems(Type propertyType)
	{
        var cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            .Select(c =>
            {
                var region = new RegionInfo(c.Name);

                var item = new SelectListItem
                {
                    Value = c.Name.Split('-').Last(),
                    Text = $"{region.EnglishName} ({region.Name})"
                };

                return item;
			})
            .Where(c => c.Value.ToString().Length == 2).OrderBy(c => c.Text);

        return cultures.DistinctBy(c => c.Value);
	}
}
