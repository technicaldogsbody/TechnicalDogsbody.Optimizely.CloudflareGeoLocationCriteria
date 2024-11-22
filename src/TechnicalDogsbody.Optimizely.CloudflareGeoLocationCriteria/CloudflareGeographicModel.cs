using EPiServer.Data.Dynamic;
using EPiServer.Personalization.VisitorGroups;

namespace TechnicalDogsbody.Optimizely.CloudflareGeoLocationCriteria;

[EPiServerDataStore(AutomaticallyCreateStore = true, AutomaticallyRemapStore = true)]
public class CloudflareGeographicModel : CriterionModelBase
{
    [CriterionPropertyEditor(SelectionFactoryType = typeof(CloudflareGeographicLocationSelectionFactory))]
    public string? CountryCode { get; set; }

	public override ICriterionModel Copy()
    {
        return ShallowCopy();
    }
}