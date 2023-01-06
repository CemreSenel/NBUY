namespace GetCountriesFromApi.Models
{
    public class CountryName : Translation
    {
        public Dictionary<string,Translation>? Translations { get; set; }
    }
}