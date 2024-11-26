namespace TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria.Tests;

using System.Linq;
using CloudflareGeoLocationCriteria;
using Xunit;

public class CloudflareGeographicLocationSelectionFactoryTests
{
    [Fact]
    public void GetSelectListItems_ReturnsNonEmptyList()
    {
        var factory = new CloudflareGeographicLocationSelectionFactory();

        var items = factory.GetSelectListItems(typeof(string)).ToList();

        Assert.NotEmpty(items);
    }

    [Fact]
    public void GetSelectListItems_AllItemsHaveTwoLetterValue()
    {
        var factory = new CloudflareGeographicLocationSelectionFactory();

        var items = factory.GetSelectListItems(typeof(string));

        Assert.All(items, item => Assert.Equal(2, item.Value.Length));
    }

    [Fact]
    public void GetSelectListItems_ReturnsDistinctItems()
    {
        var factory = new CloudflareGeographicLocationSelectionFactory();

        var items = factory.GetSelectListItems(typeof(string)).ToList();
        var distinctItems = items.DistinctBy(c => c.Value).ToList();

        Assert.Equal(items.Count, distinctItems.Count);
    }
}
