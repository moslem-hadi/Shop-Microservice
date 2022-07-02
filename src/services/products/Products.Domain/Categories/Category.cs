using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain
{
    public class Category:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Link { get; set; }
        public bool Active { get; set; }
        public int Priority { get; set; }
        public string BannerUrl { get; set; }
        public string IconUrl { get; set; }

        public ICollection<Product> Products { get; set; }
        public Category ParentCategory { get; set; }


        public class CategoryConfiguration : IEntityTypeConfiguration<Category>
        {
            public void Configure(EntityTypeBuilder<Category> builder)
            {
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
                builder.Property(x => x.Description).IsRequired().HasMaxLength(5000);
                builder.Property(x => x.Link).IsRequired().HasMaxLength(200);
                builder.Property(x => x.BannerUrl).IsRequired().HasMaxLength(200)
                    .HasDefaultValue("https://via.placeholder.com/500x100.png");
                builder.Property(x => x.IconUrl).IsRequired().HasMaxLength(200)
                    .HasDefaultValue("https://via.placeholder.com/100.png");
                builder.Property(x => x.CreationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(x => x.ModificationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);


                builder.HasData(SeedCategories());
            }
            private List<Category> SeedCategories()
            {
                var categories = new List<Category>();
                string directoryPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                string categorySeedPath = Path.Combine(directoryPath, @"SeedData/CategorySeed.json");
                using (StreamReader r = new StreamReader(categorySeedPath))
                {
                    string json = r.ReadToEnd();
                    categories = JsonSerializer.Deserialize<List<Category>>(json);
                }

                return categories ?? new();
            }

        }
    }
}
