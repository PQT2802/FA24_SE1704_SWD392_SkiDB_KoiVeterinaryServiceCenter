using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace KVSC.Infrastructure.DB.Configuration
{
    public class PetServiceConfiguration : IEntityTypeConfiguration<PetService>
    {
        public void Configure(EntityTypeBuilder<PetService> builder)
        {
            builder.HasData
            (
                new PetService
                {
                    Id = new Guid("f6a59f70-c0db-45b4-a598-045a005d42ed"),
                    PetServiceCategoryId = new Guid("3d3bb172-c3d0-4d0f-ac50-713708bc6498"),
                    BasePrice = 150.00m,
                    Duration = "3 hours",
                    ImageUrl = "User/7dc80870-0593-4bdf-bcae-50096866d7ba_15_mau_ho_ca_Koi_mini_dep_phu_hop_voi_moi_khong_gian_05.png",
                    AvailableFrom = DateTime.Now.AddDays(-3), // Cách hiện tại vài ngày
                    AvailableTo = DateTime.Now.AddMonths(2),
                    TravelCost = 30.00m,
                    CreatedDate = DateTime.Now.AddDays(-4), // Nhỏ hơn AvailableFrom
                    IsDeleted = false,
                    Name = "Emergency Care"
                },
                new PetService
                {
                    Id = new Guid("7d80bd0a-7780-4c4c-981b-48d7f8784405"),
                    PetServiceCategoryId = new Guid("da91046c-71d1-429b-ade3-5e8ff9f701a6"),
                    BasePrice = 100.00m,
                    Duration = "2 hours",
                    ImageUrl = "User/86b2e5a0-2c2f-4613-9a87-95c9c1c0d736_90.jpg",
                    AvailableFrom = DateTime.Now.AddDays(-5),
                    AvailableTo = DateTime.Now.AddMonths(3),
                    TravelCost = 25.00m,
                    CreatedDate = DateTime.Now.AddDays(-6),
                    IsDeleted = false,
                    Name = "Parasite Treatment"
                },
                new PetService
                {
                    Id = new Guid("2d95b900-9b04-4f6f-94ec-7d47d2a89ec8"),
                    PetServiceCategoryId = new Guid("75efc332-0e1b-4d35-a609-4897d83c173e"),
                    BasePrice = 20.00m,
                    Duration = "45 minutes",
                    ImageUrl = "User/69df3fd9-3a05-493d-a331-682f85ab1fac_cham-soc-chua-benh-ca-koi-1.jpg",
                    AvailableFrom = DateTime.Now.AddDays(-2),
                    AvailableTo = DateTime.Now.AddMonths(1),
                    TravelCost = 5.00m,
                    CreatedDate = DateTime.Now.AddDays(-3),
                    IsDeleted = false,
                    Name = "Water Quality Testing"
                },
                new PetService
                {
                    Id = new Guid("39ebc58b-6731-491d-949d-82f387dce82e"),
                    PetServiceCategoryId = new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                    BasePrice = 29.99m,
                    Duration = "30 minutes",
                    ImageUrl = "User/e3f49113-32b5-4717-99f5-2b19f26843ee_ho-ca-koi-nhat-ban-4ff43497-b734-4264-8250-72770f0131a9.webp",
                    AvailableFrom = DateTime.Now.AddDays(-3),
                    AvailableTo = DateTime.Now.AddMonths(2),
                    TravelCost = 10.00m,
                    CreatedDate = DateTime.Now.AddDays(-4),
                    IsDeleted = false,
                    Name = "Koi Feeding Service"
                },
                new PetService
                {
                    Id = new Guid("33e71556-d924-4101-bd1f-8707ca0e6f87"),
                    PetServiceCategoryId = new Guid("fe3df183-1f42-4301-a1fb-35e6211c8816"),
                    BasePrice = 30.00m,
                    Duration = "1 hours",
                    ImageUrl = "User/ec0b365c-82a9-4aba-9ad1-0d781647680f_k5-1.jpg",
                    AvailableFrom = DateTime.Now.AddDays(-1),
                    AvailableTo = DateTime.Now.AddMonths(1),
                    TravelCost = 15.00m,
                    CreatedDate = DateTime.Now.AddDays(-2),
                    IsDeleted = false,
                    Name = "Koi Feeding Service"
                },
                new PetService
                {
                    Id = new Guid("2d547de7-d7a0-4c27-a26c-9cf3a7099817"),
                    PetServiceCategoryId = new Guid("a5e47a8f-f6e1-4c7a-8955-4a928744f9bf"),
                    BasePrice = 75.00m,
                    Duration = "1.5 hours",
                    ImageUrl = "User/67b458d2-710a-4763-bbb4-f8a3225acd71_KoiSerrivce.jpg",
                    AvailableFrom = DateTime.Now.AddDays(-7),
                    AvailableTo = DateTime.Now.AddMonths(3),
                    TravelCost = 20.00m,
                    CreatedDate = DateTime.Now.AddDays(-8),
                    IsDeleted = false,
                    Name = "Fungal Treatment"
                },
                new PetService
                {
                    Id = new Guid("8c0ce681-03e2-4ed8-83b2-abc3db694c5b"),
                    PetServiceCategoryId = new Guid("15c55a94-06fb-4dac-8b32-7c1d7af085a3"),
                    BasePrice = 40.00m,
                    Duration = "1 hours",
                    ImageUrl = "User/9ee75b2d-fc24-4b09-8b00-bd33d99b2a82_logo-hinh-3-1617430490365932845093.webp",
                    AvailableFrom = DateTime.Now.AddDays(-6),
                    AvailableTo = DateTime.Now.AddMonths(1),
                    TravelCost = 12.00m,
                    CreatedDate = DateTime.Now.AddDays(-7),
                    IsDeleted = false,
                    Name = "Educational Workshops"
                },
                new PetService
                {
                    Id = new Guid("7253ea62-e419-40dc-bc70-e069611587dd"),
                    PetServiceCategoryId = new Guid("83d70177-2e40-49c9-a0bf-27ce80cce340"),
                    BasePrice = 150.00m,
                    Duration = "2 hours",
                    ImageUrl = "User/7dc80870-0593-4bdf-bcae-50096866d7ba_15_mau_ho_ca_Koi_mini_dep_phu_hop_voi_moi_khong_gian_05.png",
                    AvailableFrom = DateTime.Now.AddDays(-5),
                    AvailableTo = DateTime.Now.AddMonths(4),
                    TravelCost = 20.00m,
                    CreatedDate = DateTime.Now.AddDays(-6),
                    IsDeleted = false,
                    Name = "Koi Fish Health Check Service"
                },
                new PetService
                {
                    Id = new Guid("c33e3a86-0230-468b-8c06-ee91b7e8cc21"),
                    PetServiceCategoryId = new Guid("82b86176-d076-4576-b0f3-60220ca3e5ba"),
                    BasePrice = 60.00m,
                    Duration = "1 hours",
                    ImageUrl = "User/e3f49113-32b5-4717-99f5-2b19f26843ee_ho-ca-koi-nhat-ban-4ff43497-b734-4264-8250-72770f0131a9.webp",
                    AvailableFrom = DateTime.Now.AddDays(-4),
                    AvailableTo = DateTime.Now.AddMonths(1),
                    TravelCost = 15.00m,
                    CreatedDate = DateTime.Now.AddDays(-5),
                    IsDeleted = false,
                    Name = "Pond Maintenance"
                },
                new PetService
                {
                    Id = new Guid("c33e3a87-0230-428b-8c06-ee91b7e8cc21"),
                    PetServiceCategoryId = new Guid("ca4801df-081c-4db5-a416-b04891797d92"),
                    BasePrice = 20.00m,
                    Duration = "1 hours",
                    ImageUrl = "User/ec0b365c-82a9-4aba-9ad1-0d781647680f_k5-1.jpg",
                    AvailableFrom = DateTime.Now.AddDays(-5),
                    AvailableTo = DateTime.Now.AddMonths(2),
                    TravelCost = 0,
                    CreatedDate = DateTime.Now.AddDays(-6),
                    IsDeleted = false,
                    Name = "Koi Care Advisory"
                }
            );
        }
    }
}
