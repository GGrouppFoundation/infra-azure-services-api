namespace GGroupp.Infra;

internal readonly record struct GeolocationSuccessJson
{
    public CountryRegionJson CountryRegion { get; init; }
}