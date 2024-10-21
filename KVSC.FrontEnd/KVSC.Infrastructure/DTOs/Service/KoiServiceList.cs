namespace KVSC.Infrastructure.DTOs.Service
{
    public class KoiServiceList
    {
        public Extensions<List<KoiServicesData>> Extensions { get; set; }
    }

    public class KoiServicesData : IPropertyNameProvider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid PetServiceCategoryId { get; set; }
        public string serviceCategory { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TravelCost { get; set; }
        public string Duration { get; set; }
        public string ImageUrl { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }

        public List<string> GetPropertyNames()
        {
            return new List<string> { nameof(Name), nameof(serviceCategory), nameof(BasePrice), nameof(TravelCost), nameof(Duration) };
        }
    }

}
